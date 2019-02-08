using System;

namespace Glued
{
    public static class AsOptionalExtensions
    {
        public static Action<T1> AsOptional<T1>(this Action<T1> source)
        {
            return source ?? (_ => { });
        }

        public static Action<T1, T2> AsOptional<T1, T2>(this Action<T1, T2> source)
        {
            return source ?? ((t1, t2) => { });
        }

        public static Action<T1, T2, T3> AsOptional<T1, T2, T3>(this Action<T1, T2, T3> source)
        {
            return source ?? ((t1, t2, t3) => { });
        }

        public static Action<T1, T2, T3, T4> AsOptional<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> source)
        {
            return source ?? ((t1, t2, t3, t4) => { });
        }
    }
}