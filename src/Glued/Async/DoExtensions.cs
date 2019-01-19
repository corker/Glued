using System;
using System.Threading.Tasks;

namespace Glued.Async
{
    public static class DoExtensions
    {
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
    }
}