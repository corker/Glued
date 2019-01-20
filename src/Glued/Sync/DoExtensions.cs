using System;

namespace Glued.Sync
{
    public static class DoExtensions
    {
        public static T
            Do<T>(this T source, Action<T> action)
        {
            action(source);
            return source;
        }

        public static Func<T1, T>
            Do<T, T1>(this T source, Action<T, T1> action)
        {
            return t1 =>
            {
                action(source, t1);
                return source;
            };
        }

        public static Func<T1, Func<T2, T>>
            Do<T, T1, T2>(this T source, Action<T, T1, T2> action)
        {
            Func<T1, T2, T> func = (t1, t2) =>
            {
                action(source, t1, t2);
                return source;
            };
            return func.Curry();
        }

        public static Func<T1, Func<T2, Func<T3, T>>>
            Do<T, T1, T2, T3>(this T source, Action<T, T1, T2, T3> action)
        {
            Func<T1, T2, T3, T> func = (t1, t2, t3) =>
            {
                action(source, t1, t2, t3);
                return source;
            };
            return func.Curry();
        }

        public static T
            Do<T, TR>(this T source, Func<T, TR> action)
        {
            action(source);
            return source;
        }

        public static Func<T1, T>
            Do<T, T1, TR>(this T source, Func<T, T1, TR> action)
        {
            return t1 =>
            {
                action(source, t1);
                return source;
            };
        }

        public static Func<T1, Func<T2, T>>
            Do<T, T1, T2, TR>(this T source, Func<T, T1, T2, TR> action)
        {
            Func<T1, T2, T> func = (t1, t2) =>
            {
                action(source, t1, t2);
                return source;
            };
            return func.Curry();
        }

        public static Func<T1, Func<T2, Func<T3, T>>>
            Do<T, T1, T2, T3, TR>(this T source, Func<T, T1, T2, T3, TR> action)
        {
            Func<T1, T2, T3, T> func = (t1, t2, t3) =>
            {
                action(source, t1, t2, t3);
                return source;
            };
            return func.Curry();
        }

        public static Func<T1, T>
            Do<T, T1>(this T source, Func<T, Action<T1>> action)
        {
            return t1 =>
            {
                action(source)(t1);
                return source;
            };
        }

        public static Func<T1, Func<T2, T>>
            Do<T, T1, T2>(this T source, Func<T, Action<T1, T2>> action)
        {
            Func<T1, T2, T> func = (t1, t2) =>
            {
                action(source)(t1, t2);
                return source;
            };
            return func.Curry();
        }

        public static Func<T1, Func<T2, Func<T3, T>>>
            Do<T, T1, T2, T3>(this T source, Func<T, Action<T1, T2, T3>> action)
        {
            Func<T1, T2, T3, T> func = (t1, t2, t3) =>
            {
                action(source)(t1, t2, t3);
                return source;
            };
            return func.Curry();
        }
    }
}