using System;
using System.Threading.Tasks;

namespace Glued.Threading.Tasks
{
    public static class DoAsyncExtensions
    {
        public static async Task<T> DoAsync<T>(this Task<T> source, Action<T> action)
        {
            var context = await source;
            action(context);
            return context;
        }

        public static async Task<T> DoAsync<T>(this Task<T> source, Func<T, Task> action)
        {
            var context = await source;
            await action(context);
            return context;
        }
    }
}