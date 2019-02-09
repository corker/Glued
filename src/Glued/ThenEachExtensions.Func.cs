using System;
using System.Collections.Generic;
using System.Linq;

namespace Glued
{
    public static class ThenEachExtensions
    {
        public static Func<IEnumerable<TR>>
            ThenEach<T, TR>(this Func<IEnumerable<T>> source, Func<T, TR> next)
        {
            return () => source().Select(next);
        }

        public static Func<T1, Func<IEnumerable<TR>>>
            ThenEach<T, T1, TR>(this Func<IEnumerable<T>> source, Func<T, T1, TR> next)
        {
            return t1 => () => source().Select(t => next(t, t1));
        }

        public static Func<T1, T2, Func<IEnumerable<TR>>>
            ThenEach<T, T1, T2, TR>(this Func<IEnumerable<T>> source, Func<T, T1, T2, TR> next)
        {
            return (t1, t2) => () => source().Select(t => next(t, t1, t2));
        }

        public static Func<T1, T2, T3, Func<IEnumerable<TR>>>
            ThenEach<T, T1, T2, T3, TR>(this Func<IEnumerable<T>> source, Func<T, T1, T2, T3, TR> next)
        {
            return (t1, t2, t3) => () => source().Select(t => next(t, t1, t2, t3));
        }

        public static Func<T1, T2, T3, T4, Func<IEnumerable<TR>>>
            ThenEach<T, T1, T2, T3, T4, TR>(this Func<IEnumerable<T>> source, Func<T, T1, T2, T3, T4, TR> next)
        {
            return (t1, t2, t3, t4) => () => source().Select(t => next(t, t1, t2, t3, t4));
        }
    }
}