using System;
using FluentAssertions;
using NSpec;
using Xunit;
using Xunit.Abstractions;

namespace Glued.UnitTests.Actions
{
    public partial class describe_Extensions : nspec
    {
        public void describe_AsAction()
        {
            it["Func<TR>"] = () => ((Action) (() => FE0.AsAction()())).ShouldThrow();
            it["Func<T1, TR>"] = () => ((Action) (() => FE1.AsAction()(T1))).ShouldThrow();
            it["Func<T1, T2, TR>"] = () => ((Action) (() => FE2.AsAction()(T1, T2))).ShouldThrow();
            it["Func<T1, T2, T3, TR>"] = () => ((Action) (() => FE3.AsAction()(T1, T2, T3))).ShouldThrow();
            it["Func<T1, T2, T3, T4, TR>"] = () => ((Action) (() => FE4.AsAction()(T1, T2, T3, T4))).ShouldThrow();
        }

        public void describe_AsFunc()
        {
            it["Func<TR>"] = () => TR.AsFunc()().Should().Be(TR);
            it["Func<T1, TR>"] = () => A1.AsFunc(TR)(T).Should().Be(TR);
            it["Func<T1, T2, TR>"] = () => A2.AsFunc(TR)(T, T1).Should().Be(TR);
            it["Func<T1, T2, T3, TR>"] = () => A3.AsFunc(TR)(T, T1, T2).Should().Be(TR);
            it["Func<T1, T2, T3, T4, TR>"] = () => A4.AsFunc(TR)(T, T1, T2, T3).Should().Be(TR);
        }

        // AsOptional
        // Cache
        // Curry
        public void describe_Do()
        {
            it["Action<T>"] = () => T.Do(A1);
            it["Action<T, T1>"] = () => T.Do(A2)(T1);
            it["Action<T, T1, T2>"] = () => T.Do(A3)(T1, T2);
            it["Action<T, T1, T2, T3>"] = () => T.Do(A4)(T1, T2, T3);
            it["Func<T>"] = () => T.Do(F1);
            it["Func<T, T1>"] = () => T.Do(F2)(T1);
            it["Func<T, T1, T2>"] = () => T.Do(F3)(T1, T2);
            it["Func<T, T1, T2, T3>"] = () => T.Do(F4)(T1, T2, T3);
            it["Func<T, Action<T1>>"] = () => T.Do(FA1)(T1);
            it["Func<T, Action<T1, T2>>"] = () => T.Do(FA2)(T1, T2);
            it["Func<T, Action<T1, T2, T3>>"] = () => T.Do(FA3)(T1, T2, T3);
            it["Func<T, Action<T1, T2, T3, T4>>"] = () => T.Do(FA4)(T1, T2, T3, T4);
        }

        public void describe_Map()
        {
            it["Func<T>"] = () => T.Map(F1).Should().Be(TR);
            it["Func<T, T1>"] = () => T.Map(F2)(T1).Should().Be(TR);
            it["Func<T, T1, T2>"] = () => T.Map(F3)(T1, T2).Should().Be(TR);
            it["Func<T, T1, T2, T3>"] = () => T.Map(F4)(T1, T2, T3).Should().Be(TR);
            it["Func<T, T1, T2, T3, T4>"] = () => T.Map(F5)(T1, T2, T3, T4).Should().Be(TR);
            it["T"] = () => T.AsFunc().Map().Should().Be(T);
            it["Func<T>"] = () => T.AsFunc().Map(F1).Should().Be(TR);
            it["Func<T, T1>"] = () => T.AsFunc().Map(F2)(T1).Should().Be(TR);
            it["Func<T, T1, T2>"] = () => T.AsFunc().Map(F3)(T1, T2).Should().Be(TR);
            it["Func<T, T1, T2, T3>"] = () => T.AsFunc().Map(F4)(T1, T2, T3).Should().Be(TR);
            it["Func<T, T1, T2, T3, T4>"] = () => T.AsFunc().Map(F5)(T1, T2, T3, T4).Should().Be(TR);
        }

        // MapEach
        // Partial
        // Stopwatch
        public void describe_Then()
        {
            it["Func<T, TR>"] = () => T.Then(F1)().Should().Be(TR);
            it["Func<T, T1, TR>"] = () => T.Then(F2)(T1)().Should().Be(TR);
            it["Func<T, T1, T2, TR>"] = () => T.Then(F3)(T1, T2)().Should().Be(TR);
            it["Func<T, T1, T2, T3, TR>"] = () => T.Then(F4)(T1, T2, T3)().Should().Be(TR);
            it["Func<T, T1, T2, T3, T4, TR>"] = () => T.Then(F5)(T1, T2, T3, T4)().Should().Be(TR);
            it["Func<Func<T>, TR>"] = () => T.AsFunc().Then(FF1)().Should().Be(TR);
            it["Func<Func<T>, T1, TR>"] = () => T.AsFunc().Then(FF2)(T1)().Should().Be(TR);
            it["Func<Func<T>, T1, T2, TR>"] = () => T.AsFunc().Then(FF3)(T1, T2)().Should().Be(TR);
            it["Func<Func<T>, T1, T2, T3, TR>"] = () => T.AsFunc().Then(FF4)(T1, T2, T3)().Should().Be(TR);
            it["Func<Func<T>, T1, T2, T3, T4, TR>"] = () => T.AsFunc().Then(FF5)(T1, T2, T3, T4)().Should().Be(TR);
        }

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