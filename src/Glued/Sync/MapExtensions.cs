using System;
using System.Collections.Generic;
using System.Linq;

namespace Glued.Sync
{
    public static class MapExtensions
    {
        public static T Map<T>(this Func<T> source)
        {
            return source();
        }

        public static T2 Map<T1, T2>(this Func<T1> source, Func<T1, T2> mapper)
        {
            return mapper(source());
        }

        public static IEnumerable<T> MapEach<T>(this Func<IEnumerable<Func<T>>> source)
        {
            return source().Select(_ => _());
        }

        public static IEnumerable<T2> MapEach<T1, T2>(this Func<IEnumerable<T1>> source, Func<T1, T2> mapper)
        {
            return source().Select(mapper);
        }
    }
}