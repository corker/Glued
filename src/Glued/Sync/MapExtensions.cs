using System;

namespace Glued.Sync
{
    public static class MapExtensions
    {
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
    }
}