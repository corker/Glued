using System;

namespace Glued
{
    public static partial class WhenExtensions
    {
        public static Func<T>
            When<T>(this Func<T> source, Func<T, bool> guard, Action<T> action)
        {
            return source.ThenDo(t =>
            {
                if (guard(t)) action(t);
            });
        }

        public static Func<T1, Func<T>>
            When<T, T1>(this Func<T> source, Func<T, bool> guard, Action<T, T1> action)
        {
            return t1 => source.ThenDo(t =>
            {
                if (guard(t)) action(t, t1);
            });
        }

        public static Func<T1, T2, Func<T>>
            When<T, T1, T2>(this Func<T> source, Func<T, bool> guard, Action<T, T1, T2> action)
        {
            return (t1, t2) => source.ThenDo(t =>
            {
                if (guard(t)) action(t, t1, t2);
            });
        }

        public static Func<T1, T2, T3, Func<T>>
            When<T, T1, T2, T3>(this Func<T> source, Func<T, bool> guard, Action<T, T1, T2, T3> action)
        {
            return (t1, t2, t3) => source.ThenDo(t =>
            {
                if (guard(t)) action(t, t1, t2, t3);
            });
        }

        public static Func<T1, T2, T3, T4, Func<T>>
            When<T, T1, T2, T3, T4>(this Func<T> source, Func<T, bool> guard, Action<T, T1, T2, T3, T4> action)
        {
            return (t1, t2, t3, t4) => source.ThenDo(t =>
            {
                if (guard(t)) action(t, t1, t2, t3, t4);
            });
        }
    }
}