using System;

namespace Glued.Sync
{
    public static class FuncAsActionExtensions
    {
        public static Action AsAction<TR>(this Func<TR> source)
        {
            return () => source();
        }

        public static Action<T1> AsAction<T1, TR>(this Func<T1, TR> source)
        {
            return t1 => source(t1);
        }

        public static Action<T1, T2> AsAction<T1, T2, TR>(this Func<T1, T2, TR> source)
        {
            return (t1, t2) => source(t1, t2);
        }

        public static Action<T1, T2, T3> AsAction<T1, T2, T3, TR>(this Func<T1, T2, T3, TR> source)
        {
            return (t1, t2, t3) => source(t1, t2, t3);
        }

        public static Action<T1, T2, T3, T4> AsAction<T1, T2, T3, T4, TR>(this Func<T1, T2, T3, T4, TR> source)
        {
            return (t1, t2, t3, t4) => source(t1, t2, t3, t4);
        }
    }
}