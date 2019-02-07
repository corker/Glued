using FluentAssertions;
using NSpec;
using Xunit;
using Xunit.Abstractions;

namespace Glued.UnitTests.Actions
{
    public partial class describe_Extensions : nspec
    {
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
        }

        public void describe_Then()
        {
            it["Func<T>"] = () => T.Then(F1)().Should().Be(TR);
            it["Func<T, T1>"] = () => T.Then(F2)(T1)().Should().Be(TR);
            it["Func<T, T1, T2>"] = () => T.Then(F3)(T1, T2)().Should().Be(TR);
            it["Func<T, T1, T2, T3>"] = () => T.Then(F4)(T1, T2, T3)().Should().Be(TR);
            it["Func<T, T1, T2, T3, T4>"] = () => T.Then(F5)(T1, T2, T3, T4)().Should().Be(TR);
        }

        // AsAction
        // AsFunc
        // AsOptional
        // Curry
        // Partial
        // Stopwatch
        // Then
        // ThenDo
        // ThenEach
        // Uncurry
        // Cache
        // Curry
        // MapEach
        // When
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