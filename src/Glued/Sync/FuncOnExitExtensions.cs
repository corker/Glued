using System;

namespace Glued.Sync
{
    public static class FuncOnExitExtensions
    {
        public static Func<TR>
            OnExit<TR>(this Func<TR> source, Action<TR> action)
        {
            return () =>
            {
                var tr = source();
                action(tr);
                return tr;
            };
        }

        public static Func<T, TR>
            OnExit<T, TR>(this Func<T, TR> source, Action<T, TR> action)
        {
            return t =>
            {
                var tr = source(t);
                action(t, tr);
                return tr;
            };
        }

        public static Func<T1, T2, TR>
            OnExit<T1, T2, TR>(this Func<T1, T2, TR> source, Action<T1, T2, TR> action)
        {
            return (t1, t2) =>
            {
                var tr = source(t1, t2);
                action(t1, t2, tr);
                return tr;
            };
        }

        public static Func<T1, T2, T3, TR>
            OnExit<T1, T2, T3, TR>(this Func<T1, T2, T3, TR> source, Action<T1, T2, T3, TR> action)
        {
            return (t1, t2, t3) =>
            {
                var tr = source(t1, t2, t3);
                action(t1, t2, t3, tr);
                return tr;
            };
        }

        public static Func<T1, T2, T3, T4, TR>
            OnExit<T1, T2, T3, T4, TR>(this Func<T1, T2, T3, T4, TR> source, Action<T1, T2, T3, T4, TR> action)
        {
            return (t1, t2, t3, t4) =>
            {
                var tr = source(t1, t2, t3, t4);
                action(t1, t2, t3, t4, tr);
                return tr;
            };
        }
    }
}