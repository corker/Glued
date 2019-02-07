using System;

namespace Glued
{
    public static class DoExtensions
    {
        public static T
            Do<T>(this T t, Action<T> action)
        {
            action(t);
            return t;
        }

        public static Func<T1, T>
            Do<T1, T>(this T t, Action<T, T1> action)
        {
            return t1 =>
            {
                action(t, t1);
                return t;
            };
        }

        public static Func<T1, T2, T>
            Do<T1, T2, T>(this T t, Action<T, T1, T2> action)
        {
            return (t1, t2) =>
            {
                action(t, t1, t2);
                return t;
            };
        }

        public static Func<T1, T2, T3, T>
            Do<T1, T2, T3, T>(this T t, Action<T, T1, T2, T3> action)
        {
            return (t1, t2, t3) =>
            {
                action(t, t1, t2, t3);
                return t;
            };
        }

        public static T
            Do<T, TX>(this T t, Func<T, TX> func)
        {
            func(t);
            return t;
        }

        public static Func<T1, T>
            Do<T1, T, TX>(this T t, Func<T, T1, TX> func)
        {
            return t1 =>
            {
                func(t, t1);
                return t;
            };
        }

        public static Func<T1, T2, T>
            Do<T1, T2, T, TX>(this T t, Func<T, T1, T2, TX> func)
        {
            return (t1, t2) =>
            {
                func(t, t1, t2);
                return t;
            };
        }

        public static Func<T1, T2, T3, T>
            Do<T1, T2, T3, T, TX>(this T t, Func<T, T1, T2, T3, TX> func)
        {
            return (t1, t2, t3) =>
            {
                func(t, t1, t2, t3);
                return t;
            };
        }

        public static Func<T1, T>
            Do<T1, T>(this T t, Func<T, Action<T1>> func)
        {
            return t1 =>
            {
                func(t)(t1);
                return t;
            };
        }

        public static Func<T1, T2, T>
            Do<T1, T2, T>(this T t, Func<T, Action<T1, T2>> func)
        {
            return (t1, t2) =>
            {
                func(t)(t1, t2);
                return t;
            };
        }

        public static Func<T1, T2, T3, T>
            Do<T1, T2, T3, T>(this T t, Func<T, Action<T1, T2, T3>> func)
        {
            return (t1, t2, t3) =>
            {
                func(t)(t1, t2, t3);
                return t;
            };
        }

        public static Func<T1, T2, T3, T4, T>
            Do<T1, T2, T3, T4, T>(this T t, Func<T, Action<T1, T2, T3, T4>> func)
        {
            return (t1, t2, t3, t4) =>
            {
                func(t)(t1, t2, t3, t4);
                return t;
            };
        }
    }
}