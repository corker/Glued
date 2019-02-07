using System;
using FluentAssertions;

// ReSharper disable InconsistentNaming

namespace Glued.UnitTests.Actions
{
    public partial class describe_Extensions
    {
        public static int T => int.MaxValue;
        public static decimal TR => decimal.MaxValue;
        public static TimeSpan T1 => TimeSpan.MaxValue;
        public static string T2 => "T2";
        public static DateTime T3 => DateTime.MaxValue;
        public static bool T4 => true;

        public static Func<int, decimal> F1 => t =>
        {
            t.Should().Be(T);
            return TR;
        };

        public static Func<int, TimeSpan, decimal> F2 => (t, t1) =>
        {
            t.Should().Be(T);
            t1.Should().Be(T1);
            return TR;
        };

        public static Func<int, TimeSpan, string, decimal> F3 => (t, t1, t2) =>
        {
            t.Should().Be(T);
            t1.Should().Be(T1);
            t2.Should().Be(T2);
            return TR;
        };

        public static Func<int, TimeSpan, string, DateTime, decimal> F4 => (t, t1, t2, t3) =>
        {
            t.Should().Be(T);
            t1.Should().Be(T1);
            t2.Should().Be(T2);
            t3.Should().Be(T3);
            return TR;
        };

        public static Func<int, TimeSpan, string, DateTime, bool, decimal> F5 => (t, t1, t2, t3, t4) =>
        {
            t.Should().Be(T);
            t1.Should().Be(T1);
            t2.Should().Be(T2);
            t3.Should().Be(T3);
            t4.Should().Be(T4);
            return TR;
        };

        public static Action<int> A1 => F1.AsAction();
        public static Action<int, TimeSpan> A2 => F2.AsAction();
        public static Action<int, TimeSpan, string> A3 => F3.AsAction();
        public static Action<int, TimeSpan, string, DateTime> A4 => F4.AsAction();
        public static Action<int, TimeSpan, string, DateTime, bool> A5 => F5.AsAction();

        public static Func<int, Action<TimeSpan>> FA1 => t => A2.Partial(t);
        public static Func<int, Action<TimeSpan, string>> FA2 => t => A3.Partial(t).Uncurry();
        public static Func<int, Action<TimeSpan, string, DateTime>> FA3 => t => A4.Partial(t).Uncurry();
        public static Func<int, Action<TimeSpan, string, DateTime, bool>> FA4 => t => A5.Partial(t).Uncurry();
    }
}