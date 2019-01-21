using System;
using System.Diagnostics;

namespace Glued.Sync
{
    public static class ActionTimeExtensions
    {
        public static Action<T>
            Stopwatch<T>(this Action<T> source, Action<T, Stopwatch> action)
        {
            return t =>
            {
                var stopwatch = System.Diagnostics.Stopwatch.StartNew();
                source(t);
                stopwatch.Stop();
                action(t, stopwatch);
            };
        }

        public static Action<T1, T2>
            Stopwatch<T1, T2>(this Action<T1, T2> source, Action<T1, T2, Stopwatch> action)
        {
            return (t1, t2) =>
            {
                var stopwatch = System.Diagnostics.Stopwatch.StartNew();
                source(t1, t2);
                stopwatch.Stop();
                action(t1, t2, stopwatch);
            };
        }

        public static Action<T1, T2, T3>
            Stopwatch<T1, T2, T3>(this Action<T1, T2, T3> source, Action<T1, T2, T3, Stopwatch> action)
        {
            return (t1, t2, t3) =>
            {
                var stopwatch = System.Diagnostics.Stopwatch.StartNew();
                source(t1, t2, t3);
                stopwatch.Stop();
                action(t1, t2, t3, stopwatch);
            };
        }

        public static Action<T1, T2, T3, T4>
            Stopwatch<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> source, Action<T1, T2, T3, T4, Stopwatch> action)
        {
            return (t1, t2, t3, t4) =>
            {
                var stopwatch = System.Diagnostics.Stopwatch.StartNew();
                source(t1, t2, t3, t4);
                stopwatch.Stop();
                action(t1, t2, t3, t4, stopwatch);
            };
        }
    }
}