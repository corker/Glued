using System;

namespace Glued
{
    /// <summary>
    ///     https://weblogs.asp.net/dixin/functional-csharp-higher-order-function-currying-and-first-class-function
    /// </summary>
    public static class ActionCurryExtensions
    {
        public static Func<T1, Action<T2>>
            Curry<T1, T2>(this Action<T1, T2> action)
        {
            return t1 => t2 => action(t1, t2);
        }

        public static Func<T1, Func<T2, Action<T3>>>
            Curry<T1, T2, T3>(this Action<T1, T2, T3> action)
        {
            return t1 => t2 => t3 => action(t1, t2, t3);
        }

        public static Func<T1, Func<T2, Func<T3, Action<T4>>>>
            Curry<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> action)
        {
            return t1 => t2 => t3 => t4 => action(t1, t2, t3, t4);
        }
    }
}