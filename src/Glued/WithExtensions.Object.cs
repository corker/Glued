using System;

namespace Glued
{
    public static class WithExtensions
    {
        public static T
            With<T, TR>(this T t, Func<T, TR> mapper, Action<TR> action)
        {
            return t.Map(mapper).Map(action.AsFunc(t));
        }

        public static Func<T1, T>
            With<T, T1, TR>(this T t, Func<T, TR> mapper, Action<TR, T1> action)
        {
            return t.Map(mapper).Map(action.AsFunc(t));
        }

        public static Func<T1, T2, T>
            With<T, T1, T2, TR>(this T t, Func<T, TR> mapper, Action<TR, T1, T2> action)
        {
            return t.Map(mapper).Map(action.AsFunc(t));
        }

        public static Func<T1, T2, T3, T>
            With<T, T1, T2, T3, TR>(this T t, Func<T, TR> mapper, Action<TR, T1, T2, T3> action)
        {
            return t.Map(mapper).Map(action.AsFunc(t));
        }
    }
}