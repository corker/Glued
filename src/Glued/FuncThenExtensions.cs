using System;

namespace Glued
{
    public static class FuncThenExtensions
    {
        public static Func<TR>
            Then<T1, TR>(this Func<T1> source, Func<Func<T1>, TR> next)
        {
            return () => next(source);
        }

        public static Func<TR>
            Then<T1, T2, TR>(this Func<T1, T2> source, Func<Func<T1, T2>, TR> next)
        {
            return () => next(source);
        }

        public static Func<TR>
            Then<T1, T2, T3, TR>(this Func<T1, T2, T3> source, Func<Func<T1, T2, T3>, TR> next)
        {
            return () => next(source);
        }

        public static Func<TR>
            Then<T1, T2, T3, T4, TR>(this Func<T1, T2, T3, T4> source, Func<Func<T1, T2, T3, T4>, TR> next)
        {
            return () => next(source);
        }
    }
}