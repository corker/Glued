using System;
using System.Collections.Generic;

namespace Glued
{
    public static class ThenForEachExtensions
    {
        public static Action
            ThenForEach<T>(this Func<IEnumerable<T>> source, Action<T> action)
        {
            return () =>
            {
                foreach (var t in source()) action(t);
            };
        }

        public static Func<T1, Action>
            ThenForEach<T, T1>(this Func<IEnumerable<T>> source, Action<T, T1> action)
        {
            return t1 => () =>
            {
                foreach (var t in source()) action(t, t1);
            };
        }

        public static Func<T1, T2, Action>
            ThenForEach<T, T1, T2>(this Func<IEnumerable<T>> source, Action<T, T1, T2> action)
        {
            return (t1, t2) => () =>
            {
                foreach (var t in source()) action(t, t1, t2);
            };
        }

        public static Func<T1, T2, T3, Action>
            ThenForEach<T, T1, T2, T3>(this Func<IEnumerable<T>> source, Action<T, T1, T2, T3> action)
        {
            return (t1, t2, t3) => () =>
            {
                foreach (var t in source()) action(t, t1, t2, t3);
            };
        }
    }
}