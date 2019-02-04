using System;
using System.Threading.Tasks;

namespace Glued.Threading.Tasks
{
    public static class MapAsyncExtensions
    {
        public static async Task<TR> MapAsync<T, TR>(this Task<T> source, Func<T, TR> mapper)
        {
            return mapper(await source);
        }

        public static async Task<TR> MapAsync<T, TR>(this Task<T> source, Func<T, Task<TR>> mapper)
        {
            return await mapper(await source);
        }
    }
}