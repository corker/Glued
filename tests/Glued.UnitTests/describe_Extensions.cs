using System;
using FluentAssertions;
using NSpec;
using Xunit;
using Xunit.Abstractions;

// ReSharper disable InconsistentNaming

namespace Glued.UnitTests
{
    public partial class describe_Extensions : nspec
    {
        public static int T => int.MaxValue;
        public static TimeSpan T1 => TimeSpan.MaxValue;
        public static string T2 => "T2";
        public static DateTime T3 => DateTime.MaxValue;
        public static bool T4 => true;
        
        public static decimal TR => decimal.MaxValue;
        public static decimal TR1 => decimal.MinValue;
        public static decimal TR2 => decimal.MinusOne;
        public static decimal TR3 => decimal.One;

        public static string CA1ThrowMessage = "CA1Throw";
        public static string CA2ThrowMessage = "CA2Throw";

        public static Func<int, decimal> F1 => t =>
        {
            t.Should().Be(T);
            return TR;
        };
        
        public static Func<int, decimal> F6 => t =>
        {
            t.Should().Be(T);
            return TR1;
        };

        public static Func<int, decimal> F7 => t =>
        {
            t.Should().Be(T);
            return TR2;
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

        public static Func<Func<int>, decimal> FF1 => source =>
        {
            source().Should().Be(T);
            return TR;
        };

        public static Func<Func<int>, TimeSpan, decimal> FF2 => (source, t1) =>
        {
            source().Should().Be(T);
            t1.Should().Be(T1);
            return TR;
        };

        public static Func<Func<int>, TimeSpan, string, decimal> FF3 => (source, t1, t2) =>
        {
            source().Should().Be(T);
            t1.Should().Be(T1);
            t2.Should().Be(T2);
            return TR;
        };

        public static Func<Func<int>, TimeSpan, string, DateTime, decimal> FF4 => (source, t1, t2, t3) =>
        {
            source().Should().Be(T);
            t1.Should().Be(T1);
            t2.Should().Be(T2);
            t3.Should().Be(T3);
            return TR;
        };

        public static Func<Func<int>, TimeSpan, string, DateTime, bool, decimal> FF5 => (source, t1, t2, t3, t4) =>
        {
            source().Should().Be(T);
            t1.Should().Be(T1);
            t2.Should().Be(T2);
            t3.Should().Be(T3);
            t4.Should().Be(T4);
            return TR;
        };

        public static Action<int> A1 => t =>
        {
            t.Should().Be(T);
        };

        public static Action<int> A1Throw => t =>
        {
            t.Should().Be(T);
            throw new TestException();
        };

        public static Action<int> A1Null => null;

        public static Action<int, TimeSpan> A2 => (t, t1) =>
        {
            t.Should().Be(T);
            t1.Should().Be(T1);
        };

        public static Action<int, TimeSpan> A2Throw => (t, t1) =>
        {
            t.Should().Be(T);
            t1.Should().Be(T1);
            throw new TestException();
        };

        public static Action<int, TimeSpan> A2Null => null;

        public static Action<int, TimeSpan, string> A3 => (t, t1, t2) =>
        {
            t.Should().Be(T);
            t1.Should().Be(T1);
            t2.Should().Be(T2);
        };

        public static Action<int, TimeSpan, string> A3Throw => (t, t1, t2) =>
        {
            t.Should().Be(T);
            t1.Should().Be(T1);
            t2.Should().Be(T2);
            throw new TestException();
        };

        public static Action<int, TimeSpan, string> A3Null => null;

        public static Action<int, TimeSpan, string, DateTime> A4 => (t, t1, t2, t3) =>
        {
            t.Should().Be(T);
            t1.Should().Be(T1);
            t2.Should().Be(T2);
            t3.Should().Be(T3);
        };

        public static Action<int, TimeSpan, string, DateTime> A4Throw => (t, t1, t2, t3) =>
        {
            t.Should().Be(T);
            t1.Should().Be(T1);
            t2.Should().Be(T2);
            t3.Should().Be(T3);
            throw new TestException();
        };

        public static Action<int, TimeSpan, string, DateTime> A4Null => null;

        public static Action<int, TimeSpan, string, DateTime, bool> A5 => (t, t1, t2, t3, t4) =>
        {
            t.Should().Be(T);
            t1.Should().Be(T1);
            t2.Should().Be(T2);
            t3.Should().Be(T3);
            t4.Should().Be(T4);
        };

        public static Action<int, TimeSpan, string, DateTime, bool> A5Throw => (t, t1, t2, t3, t4) =>
        {
            t.Should().Be(T);
            t1.Should().Be(T1);
            t2.Should().Be(T2);
            t3.Should().Be(T3);
            t4.Should().Be(T4);
            throw new TestException();
        };

        public static Action<int, TimeSpan, string, DateTime, bool> A5Null => null;

        public static Func<int, Action<TimeSpan>> FA1 => t => A2.Partial(t);
        public static Func<int, Action<TimeSpan, string>> FA2 => t => A3.Partial(t);
        public static Func<int, Action<TimeSpan, string, DateTime>> FA3 => t => A4.Partial(t);
        public static Func<int, Action<TimeSpan, string, DateTime, bool>> FA4 => t => A5.Partial(t);

        public static Func<decimal> FE0 => () => throw new TestException();

        public static Func<TimeSpan, decimal> FE1 => t1 =>
        {
            t1.Should().Be(T1);
            throw new TestException();
        };

        public static Func<TimeSpan, string, decimal> FE2 => (t1, t2) =>
        {
            t1.Should().Be(T1);
            t2.Should().Be(T2);
            throw new TestException();
        };

        public static Func<TimeSpan, string, DateTime, decimal> FE3 => (t1, t2, t3) =>
        {
            t1.Should().Be(T1);
            t2.Should().Be(T2);
            t3.Should().Be(T3);
            throw new TestException();
        };

        public static Func<TimeSpan, string, DateTime, bool, decimal> FE4 => (t1, t2, t3, t4) =>
        {
            t1.Should().Be(T1);
            t2.Should().Be(T2);
            t3.Should().Be(T3);
            t4.Should().Be(T4);
            throw new TestException();
        };
        
        
        public static Action<int> CA1Throw => t =>
        {
            t.Should().Be(T);
            throw new TestException(CA1ThrowMessage);
        };

        public static Action<int> CA2Throw => t =>
        {
            t.Should().Be(T);
            throw new TestException(CA2ThrowMessage);
        };


        public static Func<int, bool> GT => t =>
        {
            t.Should().Be(T);
            return true;
        };

        public static Func<int, bool> GF => t =>
        {
            t.Should().Be(T);
            return false;
        };

        // AsOptional
        // Cache
        // Curry

        // MapEach
        // Partial
        // Stopwatch

        // ThenDo
        // ThenEach
        // Uncurry
        // When
        // With

        public class Run
        {
            public Run(ITestOutputHelper helper)
            {
                _helper = helper;
            }

            private readonly ITestOutputHelper _helper;

            [Fact]
            public void Specs()
            {
                _helper.Run<describe_Extensions>();
            }
        }
    }
}