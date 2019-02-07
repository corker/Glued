using System;

namespace Glued
{
    public static partial class WhenExtensions
    {
        public static Func<TR>
            When<TR>(this Func<TR> source, Func<TR, bool> guard, Action<TR> action)
        {
            return () => source().Do(_ =>
            {
                if (guard(_)) action(_);
            });
        }

        public static Func<T1, TR>
            When<T1, TR>(this Func<T1, TR> source, Func<TR, bool> guard, Action<TR> action)
        {
            return t1 => source(t1).Do(tr =>
            {
                if (guard(tr)) action(tr);
            });
        }

        public static Func<T1, T2, TR>
            When<T1, T2, TR>(this Func<T1, T2, TR> source, Func<TR, bool> guard, Action<TR> action)
        {
            return (t1, t2) => source(t1, t2).Do(tr =>
            {
                if (guard(tr)) action(tr);
            });
        }

        public static Func<T1, T2, T3, TR>
            When<T1, T2, T3, TR>(this Func<T1, T2, T3, TR> source, Func<TR, bool> guard, Action<TR> action)
        {
            return (t1, t2, t3) => source(t1, t2, t3).Do(tr =>
            {
                if (guard(tr)) action(tr);
            });
        }

        public static Func<T1, T2, T3, T4, TR>
            When<T1, T2, T3, T4, TR>(this Func<T1, T2, T3, T4, TR> source, Func<TR, bool> guard, Action<TR> action)
        {
            return (t1, t2, t3, t4) => source(t1, t2, t3, t4).Do(tr =>
            {
                if (guard(tr)) action(tr);
            });
        }
    }
}