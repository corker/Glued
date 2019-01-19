using System;

namespace Glued.Selenium.WebDriver.SpecFlowTests
{
    /// <summary>
    ///     https://weblogs.asp.net/dixin/functional-csharp-higher-order-function-currying-and-first-class-function
    /// </summary>
    public static class ActionExtensions
    {
        // Transform (T1, T2) -> void
        // to T1 => T2 -> void.
        public static Func<T1, Action<T2>>
            Curry<T1, T2>(this Action<T1, T2> function)
        {
            return value1 => value2 => function(value1, value2);
        }

        // Transform (T1, T2, T3) -> void
        // to T1 -> T2 -> T3 -> void.
        public static Func<T1, Func<T2, Action<T3>>>
            Curry<T1, T2, T3>(this Action<T1, T2, T3> function)
        {
            return value1 => value2 => value3 => function(value1, value2, value3);
        }

        // Transform (T1, T2, T3, T4) -> void
        // to T1 -> T2 -> T3 -> T4 -> void.
        public static Func<T1, Func<T2, Func<T3, Action<T4>>>>
            Curry<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> function)
        {
            return value1 => value2 => value3 => value4 => function(value1, value2, value3, value4);
        }
    }
}