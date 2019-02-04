using System;

namespace Glued
{
    public static class FuncThenDoExtensions
    {
        public static Func<TR>
            ThenDo<TR>(this Func<TR> source, Action<TR> next)
        {
            return () => source().Do(next);
        }

        public static Func<T1, TR>
            ThenDo<T1, TR>(this Func<T1, TR> source, Action<T1, TR> next)
        {
            return t1 => source(t1).Do(tr => next(t1, tr));
        }

        public static Func<T1, T2, TR>
            ThenDo<T1, T2, TR>(this Func<T1, T2, TR> source, Action<T1, T2, TR> next)
        {
            return (t1, t2) => source(t1, t2).Do(tr => next(t1, t2, tr));
        }

        public static Func<T1, T2, T3, TR>
            ThenDo<T1, T2, T3, TR>(this Func<T1, T2, T3, TR> source, Action<T1, T2, T3, TR> next)
        {
            return (t1, t2, t3) => source(t1, t2, t3).Do(tr => next(t1, t2, t3, tr));
        }

        public static Func<T1, T2, T3, T4, TR>
            ThenDo<T1, T2, T3, T4, TR>(this Func<T1, T2, T3, T4, TR> source, Action<T1, T2, T3, T4, TR> next)
        {
            return (t1, t2, t3, t4) => source(t1, t2, t3, t4).Do(tr => next(t1, t2, t3, t4, tr));
        }
    }
}