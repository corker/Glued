using System;
using System.Diagnostics;

namespace Glued
{
    public static partial class StopwatchExtensions
    {
        public static Func<TR>
            Stopwatch<TR>(this Func<TR> source, Action<TR, Stopwatch> action)
        {
            return () =>
            {
                var stopwatch = System.Diagnostics.Stopwatch.StartNew();
                var tr = source();
                stopwatch.Stop();
                action(tr, stopwatch);
                return tr;
            };
        }

        public static Func<T1, TR>
            Stopwatch<T1, TR>(this Func<T1, TR> source, Action<T1, TR, Stopwatch> action)
        {
            return t =>
            {
                var stopwatch = System.Diagnostics.Stopwatch.StartNew();
                var tr = source(t);
                stopwatch.Stop();
                action(t, tr, stopwatch);
                return tr;
            };
        }

        public static Func<T1, T2, TR>
            Stopwatch<T1, T2, TR>(this Func<T1, T2, TR> source, Action<T1, T2, TR, Stopwatch> action)
        {
            return (t1, t2) =>
            {
                var stopwatch = System.Diagnostics.Stopwatch.StartNew();
                var tr = source(t1, t2);
                stopwatch.Stop();
                action(t1, t2, tr, stopwatch);
                return tr;
            };
        }

        public static Func<T1, T2, T3, TR>
            Stopwatch<T1, T2, T3, TR>(this Func<T1, T2, T3, TR> source, Action<T1, T2, T3, TR, Stopwatch> action)
        {
            return (t1, t2, t3) =>
            {
                var stopwatch = System.Diagnostics.Stopwatch.StartNew();
                var tr = source(t1, t2, t3);
                stopwatch.Stop();
                action(t1, t2, t3, tr, stopwatch);
                return tr;
            };
        }

        public static Func<T1, T2, T3, T4, TR>
            Stopwatch<T1, T2, T3, T4, TR>(this Func<T1, T2, T3, T4, TR> source, Action<T1, T2, T3, T4, TR, Stopwatch> action)
        {
            return (t1, t2, t3, t4) =>
            {
                var stopwatch = System.Diagnostics.Stopwatch.StartNew();
                var tr = source(t1, t2, t3, t4);
                stopwatch.Stop();
                action(t1, t2, t3, t4, tr, stopwatch);
                return tr;
            };
        }
    }
}