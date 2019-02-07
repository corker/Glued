using System;

namespace Glued
{
    public static partial class UncurryExtensions
    {
        public static Action<T1, T2>
            Uncurry<T1, T2>(this Func<T1, Action<T2>> source)
        {
            return (t1, t2) => source(t1)(t2);
        }

        public static Action<T1, T2, T3>
            Uncurry<T1, T2, T3>(this Func<T1, Func<T2, Action<T3>>> source)
        {
            return (t1, t2, t3) => source(t1)(t2)(t3);
        }

        public static Action<T1, T2, T3, T4>
            Uncurry<T1, T2, T3, T4>(this Func<T1, Func<T2, Func<T3, Action<T4>>>> source)
        {
            return (t1, t2, t3, t4) => source(t1)(t2)(t3)(t4);
        }
    }
}