using System;

namespace Glued
{
    public static class ThenExtensions
    {
        public static Func<TR>
            Then<T, TR>(this T t, Func<T, TR> next)
        {
            return () => next(t);
        }

        public static Func<T1, TR>
            Then<T, T1, TR>(this T t, Func<T, T1, TR> next)
        {
            return t1 => next(t, t1);
        }

        public static Func<T1, T2, TR>
            Then<T, T1, T2, TR>(this T t, Func<T, T1, T2, TR> next)
        {
            return (t1, t2) => next(t, t1, t2);
        }

        public static Func<T1, T2, T3, TR>
            Then<T, T1, T2, T3, TR>(this T t, Func<T, T1, T2, T3, TR> next)
        {
            return (t1, t2, t3) => next(t, t1, t2, t3);
        }

        public static Func<T1, T2, T3, T4, TR>
            Then<T, T1, T2, T3, T4, TR>(this T t, Func<T, T1, T2, T3, T4, TR> next)
        {
            return (t1, t2, t3, t4) => next(t, t1, t2, t3, t4);
        }
    }
}