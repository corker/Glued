using System;
using System.Collections.Generic;
using System.Linq;

namespace Glued
{
    public static partial class ForEachExtensions
    {
        public static IEnumerable<T>
            ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            return source.Select(t => t.Do(action));
        }

        public static Func<T1, IEnumerable<T>>
            ForEach<T, T1>(this IEnumerable<T> source, Action<T, T1> action)
        {
            return t1 => source.Select(t => t.Do(action)(t1));
        }

        public static Func<T1, T2, IEnumerable<T>>
            ForEach<T, T1, T2>(this IEnumerable<T> source, Action<T, T1, T2> action)
        {
            return (t1, t2) => source.Select(t => t.Do(action)(t1, t2));
        }

        public static Func<T1, T2, T3, IEnumerable<T>>
            ForEach<T, T1, T2, T3>(this IEnumerable<T> source, Action<T, T1, T2, T3> action)
        {
            return (t1, t2, t3) => source.Select(t => t.Do(action)(t1, t2, t3));
        }
    }
}