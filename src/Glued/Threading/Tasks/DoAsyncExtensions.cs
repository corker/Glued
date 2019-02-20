using System;
using System.Threading.Tasks;

namespace Glued.Threading.Tasks
{
    public static class DoAsyncExtensions
    {
        public static async Task<TR>
            DoAsync<TR>(this Task<TR> source, Func<TR, Task> next)
        {
            var tr = await source;
            await next(tr);
            return tr;
        }

        public static Func<T1, Task<TR>>
            DoAsync<T1, TR>(this Func<T1, Task<TR>> source, Func<T1, TR, Task> next)
        {
            return async t1 =>
            {
                var tr = await source(t1);
                await next(t1, tr);
                return tr;
            };
        }

        public static Func<T1, T2, Task<TR>>
            DoAsync<T1, T2, TR>(this Func<T1, T2, Task<TR>> source, Func<T1, T2, TR, Task> next)
        {
            return async (t1, t2) =>
            {
                var tr = await source(t1, t2);
                await next(t1, t2, tr);
                return tr;
            };
        }

        public static Func<T1, T2, T3, Task<TR>>
            DoAsync<T1, T2, T3, TR>(this Func<T1, T2, T3, Task<TR>> source, Func<T1, T2, T3, TR, Task> next)
        {
            return async (t1, t2, t3) =>
            {
                var tr = await source(t1, t2, t3);
                await next(t1, t2, t3, tr);
                return tr;
            };
        }

        public static Func<T1, T2, T3, T4, Task<TR>>
            DoAsync<T1, T2, T3, T4, TR>(this Func<T1, T2, T3, T4, Task<TR>> source, Func<T1, T2, T3, T4, TR, Task> next)
        {
            return async (t1, t2, t3, t4) =>
            {
                var tr = await source(t1, t2, t3, t4);
                await next(t1, t2, t3, t4, tr);
                return tr;
            };
        }

        public static async Task<TR>
            DoAsync<TR>(this Task<TR> source, Action<TR> next)
        {
            return (await source).Do(next);
        }

        public static Func<T1, Task<TR>>
            DoAsync<T1, TR>(this Func<T1, Task<TR>> source, Action<TR, T1> next)
        {
            return async t1 => (await source(t1)).Do(next)(t1);
        }

        public static Func<T1, T2, Task<TR>>
            DoAsync<T1, T2, TR>(this Func<T1, T2, Task<TR>> source, Action<TR, T1, T2> next)
        {
            return async (t1, t2) => (await source(t1, t2)).Do(next)(t1, t2);
        }

        public static Func<T1, T2, T3, Task<TR>>
            DoAsync<T1, T2, T3, TR>(this Func<T1, T2, T3, Task<TR>> source, Action<TR, T1, T2, T3> next)
        {
            return async (t1, t2, t3) => (await source(t1, t2, t3)).Do(next)(t1, t2, t3);
        }
    }
}