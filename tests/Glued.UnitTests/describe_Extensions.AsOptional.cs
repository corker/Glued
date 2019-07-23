using System;
using FluentAssertions;
using NSpec;

namespace Glued.UnitTests
{
    public partial class describe_Extensions : nspec
    {
        public void describe_AsOptional()
        {
            it["Action<T>"] = () => ((Action) (() => A1Throw.AsOptional()(T))).ShouldThrow();
            it["Action<T>(null)"] = () => ((Action)(() => A1Null.AsOptional()(T))).Should().NotThrow();
            it["Action<T, T1>"] = () => ((Action)(() => A2Throw.AsOptional()(T, T1))).ShouldThrow();
            it["Action<T, T1>(null)"] = () => ((Action) (() => A2Null.AsOptional()(T, T1))).Should().NotThrow();
            it["Action<T, T1, T2>"] = () => ((Action) (() => A3Throw.AsOptional()(T, T1, T2))).ShouldThrow();
            it["Action<T, T1, T2>(null)"] = () => ((Action)(() => A3Null.AsOptional()(T, T1, T2))).Should().NotThrow();
            it["Action<T, T1, T2, T3>"] = () => ((Action) (() => A4Throw.AsOptional()(T, T1, T2, T3))).ShouldThrow();
            it["Action<T, T1, T2, T3>(null)"] = () => ((Action) (() => A4Null.AsOptional()(T, T1, T2, T3))).Should().NotThrow();
        }
    }
}