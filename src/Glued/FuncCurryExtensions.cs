using System;

namespace Glued
{
    /// <summary>
    ///     https://weblogs.asp.net/dixin/functional-csharp-higher-order-function-currying-and-first-class-function
    /// </summary>
    public static class FuncCurryExtensions
    {
        public static Func<T1, Func<T2, TR>>
            Curry<T1, T2, TR>(this Func<T1, T2, TR> func)
        {
            return t1 => t2 => func(t1, t2);
        }

        public static Func<T1, Func<T2, Func<T3, TR>>>
            Curry<T1, T2, T3, TR>(this Func<T1, T2, T3, TR> function)
        {
            return t1 => t2 => t3 => function(t1, t2, t3);
        }

        public static Func<T1, Func<T2, Func<T3, Func<T4, TR>>>>
            Curry<T1, T2, T3, T4, TR>(this Func<T1, T2, T3, T4, TR> function)
        {
            return t1 => t2 => t3 => t4 => function(t1, t2, t3, t4);
        }
    }
}