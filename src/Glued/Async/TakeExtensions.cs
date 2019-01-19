using System;
using System.Threading.Tasks;

namespace Glued.Async
{
    public static class TakeExtensions
    {
        public static async Task<T1> Take<T, T1>(this Task<T> task, Func<T, T1> func)
        {
            return func(await task);
        }

        public static async Task<T1> Take<T, T1>(this Task<T> task, Func<T, Task<T1>> func)
        {
            return await func(await task);
        }
    }
}