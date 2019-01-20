using System;

namespace Glued.Sync
{
    public static class ActionOnEnterExtensions
    {
        public static Action<T>
            OnEnter<T>(this Action<T> source, Action<T> action)
        {
            return t =>
            {
                action(t);
                source(t);
            };
        }

        public static Action<T1, T2>
            OnEnter<T1, T2>(this Action<T1, T2> source, Action<T1, T2> action)
        {
            return (t1, t2) =>
            {
                action(t1, t2);
                source(t1, t2);
            };
        }

        public static Action<T1, T2, T3>
            OnEnter<T1, T2, T3>(this Action<T1, T2, T3> source, Action<T1, T2, T3> action)
        {
            return (t1, t2, t3) =>
            {
                action(t1, t2, t3);
                source(t1, t2, t3);
            };
        }

        public static Action<T1, T2, T3, T4>
            OnEnter<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> source, Action<T1, T2, T3, T4> action)
        {
            return (t1, t2, t3, t4) =>
            {
                action(t1, t2, t3, t4);
                source(t1, t2, t3, t4);
            };
        }
    }
}