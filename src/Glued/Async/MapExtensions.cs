using System;
using System.Threading.Tasks;

namespace Glued.Async
{
    public static class MapExtensions
    {
        public static async Task<TR> Map<T, TR>(this Task<T> source, Func<T, TR> mapper)
        {
            return mapper(await source);
        }

        public static async Task<TR> Map<T, TR>(this Task<T> source, Func<T, Task<TR>> mapper)
        {
            return await mapper(await source);
        }
    }
}