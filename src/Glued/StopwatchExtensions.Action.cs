using System;
using System.Diagnostics;

namespace Glued
{
    public static partial class StopwatchExtensions
    {
        public static Action<T1>
            Stopwatch<T1>(this Action<T1> source, Action<T1, Stopwatch> action)
        {
            return t1 =>
            {
                var stopwatch = System.Diagnostics.Stopwatch.StartNew();
                source(t1);
                stopwatch.Stop();
                action(t1, stopwatch);
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