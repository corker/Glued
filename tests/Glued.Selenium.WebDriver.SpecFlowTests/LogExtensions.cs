using System;
using System.Diagnostics;
using Glued.Selenium.WebDriver.SpecFlowTests.Services;

namespace Glued.Selenium.WebDriver.SpecFlowTests
{
    public static class LogExtensions
    {
        public static Func<T> Log<T>(this Func<T> source, ILogger logger)
        {
            return () =>
            {
                var stopwatch = Stopwatch.StartNew();
                logger.WriteLine($"in > {source.Method}");
                var tr = source();
                logger.WriteLine($"out< {source.Method} : {tr} ({stopwatch.ElapsedMilliseconds}ms)");
                return tr;
            };
        }

        public static Func<T1, TR> Log<T1, TR>(this Func<T1, TR> source, ILogger logger)
        {
            return t1 =>
            {
                var stopwatch = Stopwatch.StartNew();
                logger.WriteLine($"in > {source.Method} : {t1}");
                var tr = source(t1);
                logger.WriteLine($"out< {source.Method} : {tr} ({stopwatch.ElapsedMilliseconds}ms)");
                return tr;
            };
        }

        public static Func<T1, T2, TR> Log<T1, T2, TR>(this Func<T1, T2, TR> source, ILogger logger)
        {
            return (t1, t2) =>
            {
                var stopwatch = Stopwatch.StartNew();
                logger.WriteLine($"in > {source.Method} : {t1}, {t2}");
                var tr = source(t1, t2);
                logger.WriteLine($"out< {source.Method} : {tr} ({stopwatch.ElapsedMilliseconds}ms)");
                return tr;
            };
        }

        public static Func<T1, T2, T3, TR> Log<T1, T2, T3, TR>(this Func<T1, T2, T3, TR> source, ILogger logger)
        {
            return (t1, t2, t3) =>
            {
                var stopwatch = Stopwatch.StartNew();
                logger.WriteLine($"in > {source.Method} : {t1}, {t2}, {t3}");
                var tr = source(t1, t2, t3);
                logger.WriteLine($"out< {source.Method} : {tr} ({stopwatch.ElapsedMilliseconds}ms)");
                return tr;
            };
        }

        public static Func<T1, T2, T3, T4, TR>
            Log<T1, T2, T3, T4, TR>(this Func<T1, T2, T3, T4, TR> source, ILogger logger)
        {
            return (t1, t2, t3, t4) =>
            {
                var stopwatch = Stopwatch.StartNew();
                logger.WriteLine($"in > {source.Method} : {t1}, {t2}, {t3}, {t4}");
                var tr = source(t1, t2, t3, t4);
                logger.WriteLine($"out< {source.Method} : {tr} ({stopwatch.ElapsedMilliseconds}ms)");
                return tr;
            };
        }
    }
}