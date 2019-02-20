using System;
using System.Collections.Generic;

namespace Glued
{
    public static class ForEachExtensions
    {
        public static void
            ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach (var t in source) action(t);
        }

        public static Action<T1>
            ForEach<T, T1>(this IEnumerable<T> source, Action<T, T1> action)
        {
            return t1 =>
            {
                foreach (var t in source) action(t, t1);
            };
        }

        public static Action<T1, T2>
            ForEach<T, T1, T2>(this IEnumerable<T> source, Action<T, T1, T2> action)
        {
            return (t1, t2) =>
            {
                foreach (var t in source) action(t, t1, t2);
            };
        }

        public static Action<T1, T2, T3>
            ForEach<T, T1, T2, T3>(this IEnumerable<T> source, Action<T, T1, T2, T3> action)
        {
            return (t1, t2, t3) =>
            {
                foreach (var t in source) action(t, t1, t2, t3);
            };
        }
    }
}