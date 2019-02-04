using System;

namespace Glued
{
    public static class ActionAsFuncExtensions
    {
        public static Func<TR> AsFunc<TR>(this TR @const)
        {
            return () => @const;
        }

        public static Func<T1, TR> AsFunc<T1, TR>(this Action<T1> source, TR @const)
        {
            return t1 =>
            {
                source(t1);
                return @const;
            };
        }

        public static Func<T1, T2, TR> AsFunc<T1, T2, TR>(this Action<T1, T2> source, TR @const)
        {
            return (t1, t2) =>
            {
                source(t1, t2);
                return @const;
            };
        }

        public static Func<T1, T2, T3, TR> AsFunc<T1, T2, T3, TR>(this Action<T1, T2, T3> source, TR @const)
        {
            return (t1, t2, t3) =>
            {
                source(t1, t2, t3);
                return @const;
            };
        }

        public static Func<T1, T2, T3, T4, TR> AsFunc<T1, T2, T3, T4, TR>(this Action<T1, T2, T3, T4> source, TR @const)
        {
            return (t1, t2, t3, t4) =>
            {
                source(t1, t2, t3, t4);
                return @const;
            };
        }
    }
}