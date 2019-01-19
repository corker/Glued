using System;
using System.Threading.Tasks;

namespace Glued.Async
{
    public static class WithExtensions
    {
        public static async Task<T> With<T, T1>(this Task<T> source, Func<T, Task<T1>> mapper, Action<T1> action)
        {
            var context = await source;
            action(await mapper(context));
            return context;
        }

        public static async Task<T> With<T, T1>(this Task<T> source, Func<T, Task<T1>> mapper, Func<T1, Task> action)
        {
            var context = await source;
            await action(await mapper(context));
            return context;
        }
    }
}