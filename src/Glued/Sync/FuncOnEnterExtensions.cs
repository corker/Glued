using System;

namespace Glued.Sync
{
    public static class FuncOnEnterExtensions
    {
        public static Func<TR>
            OnEnter<TR>(this Func<TR> source, Action action)
        {
            return () =>
            {
                action();
                return source();
            };
        }

        public static Func<T, TR>
            OnEnter<T, TR>(this Func<T, TR> source, Action<T> action)
        {
            return t =>
            {
                action(t);
                return source(t);
            };
        }

        public static Func<T1, T2, TR>
            OnEnter<T1, T2, TR>(this Func<T1, T2, TR> source, Action<T1, T2> action)
        {
            return (t1, t2) =>
            {
                action(t1, t2);
                return source(t1, t2);
            };
        }

        public static Func<T1, T2, T3, TR>
            OnEnter<T1, T2, T3, TR>(this Func<T1, T2, T3, TR> source, Action<T1, T2, T3> action)
        {
            return (t1, t2, t3) =>
            {
                action(t1, t2, t3);
                return source(t1, t2, t3);
            };
        }

        public static Func<T1, T2, T3, T4, TR>
            OnEnter<T1, T2, T3, T4, TR>(this Func<T1, T2, T3, T4, TR> source, Action<T1, T2, T3, T4> action)
        {
            return (t1, t2, t3, t4) =>
            {
                action(t1, t2, t3, t4);
                return source(t1, t2, t3, t4);
            };
        }
    }
}