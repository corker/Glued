using System;

namespace Glued
{
    public static partial class PartialExtensions
    {
        public static Func<T2, TR>
            Partial<T1, T2, TR>(this Func<T1, T2, TR> source, T1 t1)
        {
            return t2 => source(t1, t2);
        }

        public static Func<T2, Func<T3, TR>>
            Partial<T1, T2, T3, TR>(this Func<T1, T2, T3, TR> source, T1 t1)
        {
            return t2 => t3 => source(t1, t2, t3);
        }

        public static Func<T2, Func<T3, Func<T4, TR>>>
            Partial<T1, T2, T3, T4, TR>(this Func<T1, T2, T3, T4, TR> source, T1 t1)
        {
            return t2 => t3 => t4 => source(t1, t2, t3, t4);
        }
    }
}