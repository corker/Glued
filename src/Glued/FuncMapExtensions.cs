using System;

namespace Glued
{
    public static class FuncMapExtensions
    {
        public static T
            Map<T>(this Func<T> source)
        {
            return source();
        }

        public static TR
            Map<T, TR>(this Func<T> source, Func<T, TR> mapper)
        {
            return mapper(source());
        }

        public static Func<T1, TR>
            Map<T, T1, TR>(this Func<T> source, Func<T, T1, TR> mapper)
        {
            return t1 => mapper(source(), t1);
        }

        public static Func<T1, T2, TR>
            Map<T, T1, T2, TR>(this Func<T> source, Func<T, T1, T2, TR> mapper)
        {
            return (t1, t2) => mapper(source(), t1, t2);
        }

        public static Func<T1, T2, T3, TR>
            Map<T, T1, T2, T3, TR>(this Func<T> source, Func<T, T1, T2, T3, TR> mapper)
        {
            return (t1, t2, t3) => mapper(source(), t1, t2, t3);
        }

        public static Func<T1, T2, T3, T4, TR>
            Map<T, T1, T2, T3, T4, TR>(this Func<T> source, Func<T, T1, T2, T3, T4, TR> mapper)
        {
            return (t1, t2, t3, t4) => mapper(source(), t1, t2, t3, t4);
        }
    }
}