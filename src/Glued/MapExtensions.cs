using System;

namespace Glued
{
    public static class MapExtensions
    {
        public static TR
            Map<T, TR>(this T t, Func<T, TR> mapper)
        {
            return mapper(t);
        }

        public static Func<T1, TR>
            Map<T, T1, TR>(this T t, Func<T, T1, TR> mapper)
        {
            return t1 => mapper(t, t1);
        }

        public static Func<T1, T2, TR>
            Map<T, T1, T2, TR>(this T t, Func<T, T1, T2, TR> mapper)
        {
            return (t1, t2) => mapper(t, t1, t2);
        }

        public static Func<T1, T2, T3, TR>
            Map<T, T1, T2, T3, TR>(this T t, Func<T, T1, T2, T3, TR> mapper)
        {
            return (t1, t2, t3) => mapper(t, t1, t2, t3);
        }

        public static Func<T1, T2, T3, T4, TR>
            Map<T, T1, T2, T3, T4, TR>(this T t, Func<T, T1, T2, T3, T4, TR> mapper)
        {
            return (t1, t2, t3, t4) => mapper(t, t1, t2, t3, t4);
        }
    }
}