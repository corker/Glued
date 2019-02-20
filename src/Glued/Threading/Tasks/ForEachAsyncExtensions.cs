using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Glued.Threading.Tasks
{
    public static class ForEachAsyncExtensions
    {
        public static async Task
            ForEachAsync<T>(this Task<IEnumerable<T>> source, Func<T, Task> action)
        {
            foreach (var t in await source) await action(t);
        }

        public static Func<T1, Task>
            ForEachAsync<T, T1>(this Task<IEnumerable<T>> source, Func<T, T1, Task> action)
        {
            return async t1 =>
            {
                foreach (var t in await source) await action(t, t1);
            };
        }

        public static Func<T1, T2, Task>
            ForEachAsync<T, T1, T2>(this Task<IEnumerable<T>> source, Func<T, T1, T2, Task> action)
        {
            return async (t1, t2) =>
            {
                foreach (var t in await source) await action(t, t1, t2);
            };
        }

        public static Func<T1, T2, T3, Task>
            ForEachAsync<T, T1, T2, T3>(this Task<IEnumerable<T>> source, Func<T, T1, T2, T3, Task> action)
        {
            return async (t1, t2, t3) =>
            {
                foreach (var t in await source) await action(t, t1, t2, t3);
            };
        }
    }
}