using System;

namespace Glued
{
    public static partial class UncurryExtensions
    {
        public static Func<T1, T2, TR>
            Uncurry<T1, T2, TR>(this Func<T1, Func<T2, TR>> source)
        {
            return (t1, t2) => source(t1)(t2);
        }

        public static Func<T1, T2, T3, TR>
            Uncurry<T1, T2, T3, TR>(this Func<T1, Func<T2, Func<T3, TR>>> source)
        {
            return (t1, t2, t3) => source(t1)(t2)(t3);
        }

        public static Func<T1, T2, T3, T4, TR>
            Uncurry<T1, T2, T3, T4, TR>(this Func<T1, Func<T2, Func<T3, Func<T4, TR>>>> source)
        {
            return (t1, t2, t3, t4) => source(t1)(t2)(t3)(t4);
        }
    }
}