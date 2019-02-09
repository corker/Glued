using System;
using FluentAssertions;
using FluentAssertions.Specialized;

namespace Glued.UnitTests.Actions
{
    public static class TestExtensions
    {
        public static Action<T1, T2, T3, T4, T5>
            AsAction<T1, T2, T3, T4, T5, TR>(this Func<T1, T2, T3, T4, T5, TR> source)
        {
            return (t1, t2, t3, t4, t5) => source(t1, t2, t3, t4, t5);
        }

        public static Action<T2, T3, T4, T5>
            Partial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> source, T1 t1)
        {
            return (t2, t3, t4, t5) => source(t1, t2, t3, t4, t5);
        }

        public static ExceptionAssertions<TestException> ShouldThrow(this Action action)
        {
            return action.Should().Throw<TestException>();
        }
    }
}