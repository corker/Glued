using System;
using FluentAssertions;

namespace Glued.UnitTests
{
    public partial class describe_Extensions
    {
        public void describe_AsFunc()
        {
            it["Func<TR>"] = () => TR.AsFunc()().Should().Be(TR);
            it["Func<T1, TR>"] = () => A1.AsFunc(TR)(T).Should().Be(TR);
            it["Func<T1, TR>"] = () => ((Action)(() => A1Throw.AsFunc(TR)(T))).ShouldThrow();
            it["Func<T1, T2, TR>"] = () => A2.AsFunc(TR)(T, T1).Should().Be(TR);
            it["Func<T1, T2, TR>"] = () => ((Action)(() => A2Throw.AsFunc(TR)(T, T1))).ShouldThrow();
            it["Func<T1, T2, T3, TR>"] = () => A3.AsFunc(TR)(T, T1, T2).Should().Be(TR);
            it["Func<T1, T2, T3, TR>"] = () => ((Action)(() => A3Throw.AsFunc(TR)(T, T1, T2))).ShouldThrow();
            it["Func<T1, T2, T3, T4, TR>"] = () => A4.AsFunc(TR)(T, T1, T2, T3).Should().Be(TR);
            it["Func<T1, T2, T3, T4, TR>"] = () => ((Action)(() => A4Throw.AsFunc(TR)(T, T1, T2, T3))).ShouldThrow();
        }
    }
}