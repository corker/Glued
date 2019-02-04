using System;

namespace Glued
{
    public static class DoExtensions
    {
        public static TR
            Do<TR>(this TR tr, Action<TR> action)
        {
            action(tr);
            return tr;
        }

        public static Func<T1, TR>
            Do<T1, TR>(this TR tr, Action<TR, T1> action)
        {
            return t1 =>
            {
                action(tr, t1);
                return tr;
            };
        }

        public static Func<T1, T2, TR>
            Do<T1, T2, TR>(this TR tr, Action<TR, T1, T2> action)
        {
            return (t1, t2) =>
            {
                action(tr, t1, t2);
                return tr;
            };
        }

        public static Func<T1, T2, T3, TR>
            Do<T1, T2, T3, TR>(this TR tr, Action<TR, T1, T2, T3> action)
        {
            return (t1, t2, t3) =>
            {
                action(tr, t1, t2, t3);
                return tr;
            };
        }

        public static Func<T1, T2, T3, T4, TR>
            Do<T1, T2, T3, T4, TR>(this TR tr, Action<TR, T1, T2, T3, T4> action)
        {
            return (t1, t2, t3, t4) =>
            {
                action(tr, t1, t2, t3, t4);
                return tr;
            };
        }

        public static TR
            Do<TR, TX>(this TR tr, Func<TR, TX> func)
        {
            func(tr);
            return tr;
        }

        public static Func<T1, TR>
            Do<T1, TR, TX>(this TR tr, Func<TR, T1, TX> func)
        {
            return t1 =>
            {
                func(tr, t1);
                return tr;
            };
        }

        public static Func<T1, T2, TR>
            Do<T1, T2, TR, TX>(this TR tr, Func<TR, T1, T2, TX> func)
        {
            return (t1, t2) =>
            {
                func(tr, t1, t2);
                return tr;
            };
        }

        public static Func<T1, T2, T3, TR>
            Do<T1, T2, T3, TR, TX>(this TR tr, Func<TR, T1, T2, T3, TX> func)
        {
            return (t1, t2, t3) =>
            {
                func(tr, t1, t2, t3);
                return tr;
            };
        }

        public static Func<T1, T2, T3, T4, TR>
            Do<T1, T2, T3, T4, TR, TX>(this TR tr, Func<TR, T1, T2, T3, T4, TX> func)
        {
            return (t1, t2, t3, t4) =>
            {
                func(tr, t1, t2, t3, t4);
                return tr;
            };
        }

        public static Func<T1, TR>
            Do<T1, TR>(this TR tr, Func<TR, Action<T1>> func)
        {
            return t1 =>
            {
                func(tr)(t1);
                return tr;
            };
        }

        public static Func<T1, T2, TR>
            Do<T1, T2, TR>(this TR tr, Func<TR, Action<T1, T2>> func)
        {
            return (t1, t2) =>
            {
                func(tr)(t1, t2);
                return tr;
            };
        }

        public static Func<T1, T2, T3, TR>
            Do<T1, T2, T3, TR>(this TR tr, Func<TR, Action<T1, T2, T3>> func)
        {
            return (t1, t2, t3) =>
            {
                func(tr)(t1, t2, t3);
                return tr;
            };
        }

        public static Func<T1, T2, T3, T4, TR>
            Do<T1, T2, T3, T4, TR>(this TR tr, Func<TR, Action<T1, T2, T3, T4>> func)
        {
            return (t1, t2, t3, t4) =>
            {
                func(tr)(t1, t2, t3, t4);
                return tr;
            };
        }
    }
}