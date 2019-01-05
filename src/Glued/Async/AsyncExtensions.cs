using System;
using System.Threading.Tasks;

namespace Glued.Async
{
    public static class AsyncExtensions
    {
        public static Task<T> AsAsync<T>(this T target)
        {
            return Task.FromResult(target);
        }

        public static async Task<T> Do<T>(this Task<T> task, Action<T> action)
        {
            var target = await task;
            action(target);
            return target;
        }

        public static async Task<T> Do<T>(this Task<T> task, Func<T, Task> func)
        {
            var target = await task;
            await func(target);
            return target;
        }

        public static async Task<T1> Take<T, T1>(this Task<T> task, Func<T, T1> func)
        {
            return func(await task);
        }

        public static async Task<T1> Take<T, T1>(this Task<T> task, Func<T, Task<T1>> func)
        {
            return await func(await task);
        }

        public static async Task<T> With<T, T1>(this Task<T> task, Func<T, Task<T1>> take, Action<T1> @do)
        {
            var target = await task;
            @do(await take(target));
            return target;
        }

        public static async Task<T> With<T, T1>(this Task<T> task, Func<T, Task<T1>> take, Func<T1, Task> @do)
        {
            var target = await task;
            await @do(await take(target));
            return target;
        }
    }
}