using System;
using FluentAssertions;
using NSpec;

namespace Glued.UnitTests.Actions
{
    public static class NSpecActionExtensions
    {
        public static decimal T1(this nspec nspec)
        {
            return 1;
        }

        public static decimal T2(this nspec nspec)
        {
            return 2;
        }

        public static decimal T3(this nspec nspec)
        {
            return 3;
        }

        public static decimal T4(this nspec nspec)
        {
            return 4;
        }

        public static Action<decimal> Action1(this nspec _)
        {
            return t1 => { t1.Should().Be(_.T1()); };
        }

        public static Action<decimal, decimal> Action2(this nspec _)
        {
            return (t1, t2) =>
            {
                t1.Should().Be(_.T1());
                t2.Should().Be(_.T2());
            };
        }

        public static Action<decimal, decimal, decimal> Action3(this nspec _)
        {
            return (t1, t2, t3) =>
            {
                t1.Should().Be(_.T1());
                t2.Should().Be(_.T2());
                t3.Should().Be(_.T3());
            };
        }

        public static Action<decimal, decimal, decimal, decimal> Action4(this nspec _)
        {
            return (t1, t2, t3, t4) =>
            {
                t1.Should().Be(_.T1());
                t2.Should().Be(_.T2());
                t3.Should().Be(_.T3());
                t4.Should().Be(_.T4());
            };
        }
    }
}