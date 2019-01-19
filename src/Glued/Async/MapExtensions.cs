using System;
using System.Threading.Tasks;

namespace Glued.Async
{
    public static class MapExtensions
    {
        public static async Task<T1> Map<T, T1>(this Task<T> source, Func<T, T1> mapper)
        {
            return mapper(await source);
        }

        public static async Task<T1> Map<T, T1>(this Task<T> source, Func<T, Task<T1>> mapper)
        {
            return await mapper(await source);
        }
    }
}