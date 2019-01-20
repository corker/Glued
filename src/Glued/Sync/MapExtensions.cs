using System;
using System.Collections.Generic;
using System.Linq;

namespace Glued.Sync
{
    public static class MapExtensions
    {
        public static T
            Map<T>(this Func<T> source)
        {
            return source();
        }

        public static TR
            Map<T, TR>(this T source, Func<T, TR> mapper)
        {
            return mapper(source);
        }

        public static Func<T1, TR>
            Map<T, T1, TR>(this T source, Func<T, T1, TR> mapper)
        {
            return mapper.Curry()(source);
        }

        public static Func<T1, Func<T2, TR>>
            Map<T, T1, T2, TR>(this T source, Func<T, T1, T2, TR> mapper)
        {
            return mapper.Curry()(source);
        }

        public static Func<T1, Func<T2, Func<T3, TR>>>
            Map<T, T1, T2, T3, TR>(this T source, Func<T, T1, T2, T3, TR> mapper)
        {
            return mapper.Curry()(source);
        }

        public static TR
            Map<T, TR>(this Func<T> source, Func<T, TR> mapper)
        {
            return mapper(source());
        }

        public static Func<T1, TR>
            Map<T, T1, TR>(this Func<T> source, Func<T, T1, TR> mapper)
        {
            return mapper.Curry()(source());
        }

        public static Func<T1, Func<T2, TR>>
            Map<T, T1, T2, TR>(this Func<T> source, Func<T, T1, T2, TR> mapper)
        {
            return mapper.Curry()(source());
        }

        public static Func<T1, Func<T2, Func<T3, TR>>>
            Map<T, T1, T2, T3, TR>(this Func<T> source, Func<T, T1, T2, T3, TR> mapper)
        {
            return mapper.Curry()(source());
        }

        public static IEnumerable<T>
            MapEach<T>(this Func<IEnumerable<Func<T>>> source)
        {
            return source().Select(_ => _());
        }

        public static IEnumerable<TR>
            MapEach<T, TR>(this Func<IEnumerable<T>> source, Func<T, TR> mapper)
        {
            return source().Select(mapper);
        }
    }
}