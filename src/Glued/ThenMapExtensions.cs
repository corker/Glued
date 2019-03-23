using System;

namespace Glued
{
    public static class ThenMapExtensions
    {
        public static Func<TR>
            ThenMap<T, TR>(this Func<T> t, Func<T, TR> mapper)
        {
            return () => mapper(t());
        }

        public static Func<T1, Func<TR>>
            ThenMap<T, T1, TR>(this Func<T> t, Func<T, T1, TR> mapper)
        {
            return t1 => () => mapper(t(), t1);
        }

        public static Func<T1, T2, Func<TR>>
            ThenMap<T, T1, T2, TR>(this Func<T> t, Func<T, T1, T2, TR> mapper)
        {
            return (t1, t2) => () => mapper(t(), t1, t2);
        }

        public static Func<T1, T2, T3, Func<TR>>
            ThenMap<T, T1, T2, T3, TR>(this Func<T> t, Func<T, T1, T2, T3, TR> mapper)
        {
            return (t1, t2, t3) => () => mapper(t(), t1, t2, t3);
        }

        public static Func<T1, T2, T3, T4, Func<TR>>
            ThenMap<T, T1, T2, T3, T4, TR>(this Func<T> t, Func<T, T1, T2, T3, T4, TR> mapper)
        {
            return (t1, t2, t3, t4) => () => mapper(t(), t1, t2, t3, t4);
        }
    }
}