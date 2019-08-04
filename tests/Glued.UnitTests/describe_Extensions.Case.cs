using System;
using FluentAssertions;
using NSpec;

namespace Glued.UnitTests
{
    public partial class describe_Extensions : nspec
    {
        public void describe_Case()
        {
            it["Func Case(false).Then"] = () => T.Case(GF, F1).Else(F6).Should().Be(TR1);
            it["Func Case(true).Then"] = () => T.Case(GT, F1).Else(F6).Should().Be(TR);
            it["Func Case(false).Case(false).Then"] = () => T.Case(GF, F1).Case(GF, F7).Else(F6).Should().Be(TR1);
            it["Func Case(false).Case(true).Then"] = () => T.Case(GF, F1).Case(GT, F7).Else(F6).Should().Be(TR2);
            it["Func Case(true).Case(false).Then"] = () => T.Case(GT, F1).Case(GF, F7).Else(F6).Should().Be(TR);
            it["Func Case(true).Case(true).Then"] = () => T.Case(GT, F1).Case(GT, F7).Else(F6).Should().Be(TR);
            it["Action Case(true).Then"] = () => T.Case(GT, A1).Else(A1Throw);
            it["Action Case(false).Then"] = () => ((Action) (() => T.Case(GF, A1).Else(A1Throw))).ShouldThrow();
            it["Action Case(false).Case(false).Then"] = () => ((Action) (() => T.Case(GF, A1).Case(GF, CA1Throw).Else(A1Throw))).ShouldThrow();
            it["Action Case(false).Case(true).Then"] = () => ((Action) (() => T.Case(GF, A1).Case(GT, CA1Throw).Else(A1Throw))).ShouldThrow(CA1ThrowMessage);
            it["Action Case(true).Case(false).Then"] = () => T.Case(GT, A1).Case(GF, CA1Throw).Else(A1Throw);
            it["Action Case(true).Case(true).Then"] = () => T.Case(GT, A1).Case(GT, CA1Throw).Else(A1Throw);
        }
    }
}