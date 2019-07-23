using FluentAssertions;

namespace Glued.UnitTests
{
    public partial class describe_Extensions
    {
        public void describe_Then()
        {
            it["Func<T, TR>"] = () => T.Then(F1)().Should().Be(TR);
            it["Func<T, T1, TR>"] = () => T.Then(F2)(T1)().Should().Be(TR);
            it["Func<T, T1, T2, TR>"] = () => T.Then(F3)(T1, T2)().Should().Be(TR);
            it["Func<T, T1, T2, T3, TR>"] = () => T.Then(F4)(T1, T2, T3)().Should().Be(TR);
            it["Func<T, T1, T2, T3, T4, TR>"] = () => T.Then(F5)(T1, T2, T3, T4)().Should().Be(TR);
        }
    }
}