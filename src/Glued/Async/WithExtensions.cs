using System;
using System.Threading.Tasks;

namespace Glued.Async
{
    public static class WithExtensions
    {
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