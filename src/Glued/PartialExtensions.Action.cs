using System;

namespace Glued
{
    public static partial class PartialExtensions
    {
        public static Action<T2>
            Partial<T1, T2>(this Action<T1, T2> source, T1 t1)
        {
            return t2 => source(t1, t2);
        }

        public static Func<T2, Action<T3>>
            Partial<T1, T2, T3>(this Action<T1, T2, T3> source, T1 t1)
        {
            return t2 => t3 => source(t1, t2, t3);
        }

        public static Func<T2, Func<T3, Action<T4>>>
            Partial<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> source, T1 t1)
        {
            return t2 => t3 => t4 => source(t1, t2, t3, t4);
        }
    }
}