using System;

namespace Glued
{
    public static partial class ThenDoExtensions
    {
        public static Action<T1>
            ThenDo<T1>(this Action<T1> source, Action<T1> next)
        {
            return t1 =>
            {
                source(t1);
                next(t1);
            };
        }

        public static Action<T1, T2>
            ThenDo<T1, T2>(this Action<T1, T2> source, Action<T1, T2> next)
        {
            return (t1, t2) =>
            {
                source(t1, t2);
                next(t1, t2);
            };
        }

        public static Action<T1, T2, T3>
            ThenDo<T1, T2, T3>(this Action<T1, T2, T3> source, Action<T1, T2, T3> next)
        {
            return (t1, t2, t3) =>
            {
                source(t1, t2, t3);
                next(t1, t2, t3);
            };
        }

        public static Action<T1, T2, T3, T4>
            ThenDo<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> source, Action<T1, T2, T3, T4> next)
        {
            return (t1, t2, t3, t4) =>
            {
                source(t1, t2, t3, t4);
                next(t1, t2, t3, t4);
            };
        }
    }
}