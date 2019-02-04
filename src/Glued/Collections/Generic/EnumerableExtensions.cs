using System.Collections.Generic;
using System.Linq;

namespace Glued.Collections.Generic
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<T> AsEnumerable<T>(this T source)
        {
            return Enumerable.Repeat(source, 1);
        }

        public static IEnumerable<T> Union<T>(this T first, IEnumerable<T> second)
        {
            return first.AsEnumerable().Union(second);
        }
    }
}