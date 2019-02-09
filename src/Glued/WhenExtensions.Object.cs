using System;

namespace Glued
{
    public static partial class WhenExtensions
    {
        public static T
            When<T>(this T t, Func<T, bool> guard, Action<T> action)
        {
            return t.Do(_ =>
            {
                if (guard(_)) action(_);
            });
        }

        public static Func<T1, T>
            When<T, T1>(this T t, Func<T, bool> guard, Action<T, T1> action)
        {
            return t1 => t.Do(_ =>
            {
                if (guard(_)) action(_, t1);
            });
        }

        public static Func<T1, T2, T>
            When<T, T1, T2>(this T t, Func<T, bool> guard, Action<T, T1, T2> action)
        {
            return (t1, t2) => t.Do(_ =>
            {
                if (guard(_)) action(_, t1, t2);
            });
        }

        public static Func<T1, T2, T3, T>
            When<T, T1, T2, T3>(this T t, Func<T, bool> guard, Action<T, T1, T2, T3> action)
        {
            return (t1, t2, t3) => t.Do(_ =>
            {
                if (guard(_)) action(_, t1, t2, t3);
            });
        }

        public static Func<T1, T2, T3, T4, T>
            When<T, T1, T2, T3, T4>(this T t, Func<T, bool> guard, Action<T, T1, T2, T3, T4> action)
        {
            return (t1, t2, t3, t4) => t.Do(_ =>
            {
                if (guard(_)) action(_, t1, t2, t3, t4);
            });
        }
    }
}