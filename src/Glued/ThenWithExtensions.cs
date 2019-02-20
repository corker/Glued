using System;

namespace Glued
{
    public static class ThenWithExtensions
    {
        public static Func<T>
            ThenWith<T, TR>(this Func<T> source, Func<T, TR> mapper, Action<TR> action)
        {
            return source.ThenDo(_ => _.Map(mapper).Do(action));
        }

        public static Func<T1, Func<T>>
            ThenWith<T, T1, TR>(this Func<T> source, Func<T, TR> mapper, Action<TR, T1> action)
        {
            return t1 => source.ThenDo(_ => _.Map(mapper).Do(action)(t1));
        }

        public static Func<T1, T2, Func<T>>
            ThenWith<T, T1, T2, TR>(this Func<T> source, Func<T, TR> mapper, Action<TR, T1, T2> action)
        {
            return (t1, t2) => source.ThenDo(_ => _.Map(mapper).Do(action)(t1, t2));
        }

        public static Func<T1, T2, T3, Func<T>>
            ThenWith<T, T1, T2, T3, TR>(this Func<T> source, Func<T, TR> mapper, Action<TR, T1, T2, T3> action)
        {
            return (t1, t2, t3) => source.ThenDo(_ => _.Map(mapper).Do(action)(t1, t2, t3));
        }
    }
}