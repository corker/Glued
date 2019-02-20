using System;
using System.Threading.Tasks;

namespace Glued.Threading.Tasks
{
    public static class WhenAsyncExtensions
    {
        public static Task<T>
            WhenAsync<T>(this Task<T> source, bool guard, Func<T, Task> action)
        {
            return source.DoAsync(async t =>
            {
                if (guard) await action(t);
            });
        }

        public static Func<T1, Task<T>>
            WhenAsync<T, T1>(this Task<T> source, bool guard, Func<T, T1, Task> action)
        {
            return t1 => source.DoAsync(async t =>
            {
                if (guard) await action(t, t1);
            });
        }

        public static Func<T1, T2, Task<T>>
            WhenAsync<T, T1, T2>(this Task<T> source, bool guard, Func<T, T1, T2, Task> action)
        {
            return (t1, t2) => source.DoAsync(async t =>
            {
                if (guard) await action(t, t1, t2);
            });
        }

        public static Func<T1, T2, T3, Task<T>>
            WhenAsync<T, T1, T2, T3>(this Task<T> source, bool guard, Func<T, T1, T2, T3, Task> action)
        {
            return (t1, t2, t3) => source.DoAsync(async t =>
            {
                if (guard) await action(t, t1, t2, t3);
            });
        }

        public static Func<T1, T2, T3, T4, Task<T>>
            WhenAsync<T, T1, T2, T3, T4>(this Task<T> source, bool guard, Func<T, T1, T2, T3, T4, Task> action)
        {
            return (t1, t2, t3, t4) => source.DoAsync(async t =>
            {
                if (guard) await action(t, t1, t2, t3, t4);
            });
        }

        public static Task<T>
            WhenAsync<T>(this Task<T> source, Func<T, bool> guard, Func<T, Task> action)
        {
            return source.DoAsync(async t =>
            {
                if (guard(t)) await action(t);
            });
        }

        public static Func<T1, Task<T>>
            WhenAsync<T, T1>(this Task<T> source, Func<T, bool> guard, Func<T, T1, Task> action)
        {
            return t1 => source.DoAsync(async t =>
            {
                if (guard(t)) await action(t, t1);
            });
        }

        public static Func<T1, T2, Task<T>>
            WhenAsync<T, T1, T2>(this Task<T> source, Func<T, bool> guard, Func<T, T1, T2, Task> action)
        {
            return (t1, t2) => source.DoAsync(async t =>
            {
                if (guard(t)) await action(t, t1, t2);
            });
        }

        public static Func<T1, T2, T3, Task>
            WhenAsync<T, T1, T2, T3>(this Task<T> source, Func<T, bool> guard, Func<T, T1, T2, T3, Task> action)
        {
            return (t1, t2, t3) => source.DoAsync(async t =>
            {
                if (guard(t)) await action(t, t1, t2, t3);
            });
        }

        public static Func<T1, T2, T3, T4, Task<T>>
            WhenAsync<T, T1, T2, T3, T4>(this Task<T> source, Func<T, bool> guard, Func<T, T1, T2, T3, T4, Task> action)
        {
            return (t1, t2, t3, t4) => source.DoAsync(async t =>
            {
                if (guard(t)) await action(t, t1, t2, t3, t4);
            });
        }
    }
}