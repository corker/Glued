using System;

namespace Glued.Selenium.WebDriver.SpecFlowTests
{
    /// <summary>
    ///     https://weblogs.asp.net/dixin/functional-csharp-higher-order-function-currying-and-first-class-function
    /// </summary>
    public static class FuncExtensions
    {
        // Transform (T1, T2) -> TResult
        // to T1 -> T2 -> TResult.
        public static Func<T1, Func<T2, TResult>>
            Curry<T1, T2, TResult>(this Func<T1, T2, TResult> function)
        {
            return value1 => value2 => function(value1, value2);
        }

        // Transform (T1, T2, T3) -> TResult
        // to T1 -> T2 -> T3 -> TResult.
        public static Func<T1, Func<T2, Func<T3, TResult>>>
            Curry<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> function)
        {
            return value1 => value2 => value3 => function(value1, value2, value3);
        }

        // Transform (T1, T2, T3, T4) => TResult
        // to T1 -> T2 -> T3 -> T4 -> TResult.
        public static Func<T1, Func<T2, Func<T3, Func<T4, TResult>>>>
            Curry<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> function)
        {
            return value1 => value2 => value3 => value4 => function(value1, value2, value3, value4);
        }
    }
}