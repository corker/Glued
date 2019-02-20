using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Glued.Threading.Tasks
{
    public static class MapEachAsyncExtensions
    {
        public static async Task<IEnumerable<TR>>
            MapEachAsync<T, TR>(this Task<IEnumerable<T>> source, Func<T, TR> next)
        {
            return (await source).Select(next);
        }

        public static Func<T1, Task<IEnumerable<TR>>>
            MapEachAsync<T, T1, TR>(this Task<IEnumerable<T>> source, Func<T, T1, TR> next)
        {
            return async t1 => (await source).Select(t => next(t, t1));
        }

        public static Func<T1, T2, Task<IEnumerable<TR>>>
            MapEachAsync<T, T1, T2, TR>(this Task<IEnumerable<T>> source, Func<T, T1, T2, TR> next)
        {
            return async (t1, t2) => (await source).Select(t => next(t, t1, t2));
        }

        public static Func<T1, T2, T3, Task<IEnumerable<TR>>>
            MapEachAsync<T, T1, T2, T3, TR>(this Task<IEnumerable<T>> source, Func<T, T1, T2, T3, TR> next)
        {
            return async (t1, t2, t3) => (await source).Select(t => next(t, t1, t2, t3));
        }

        public static Func<T1, T2, T3, T4, Task<IEnumerable<TR>>>
            MapEachAsync<T, T1, T2, T3, T4, TR>(this Task<IEnumerable<T>> source, Func<T, T1, T2, T3, T4, TR> next)
        {
            return async (t1, t2, t3, t4) => (await source).Select(t => next(t, t1, t2, t3, t4));
        }
    }
}