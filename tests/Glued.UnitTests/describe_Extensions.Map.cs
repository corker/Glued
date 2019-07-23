using FluentAssertions;

namespace Glued.UnitTests
{
    public partial class describe_Extensions
    {
        public void describe_Map()
        {
            it["Func<T>"] = () => T.Map(F1).Should().Be(TR);
            it["Func<T, T1>"] = () => T.Map(F2)(T1).Should().Be(TR);
            it["Func<T, T1, T2>"] = () => T.Map(F3)(T1, T2).Should().Be(TR);
            it["Func<T, T1, T2, T3>"] = () => T.Map(F4)(T1, T2, T3).Should().Be(TR);
            it["Func<T, T1, T2, T3, T4>"] = () => T.Map(F5)(T1, T2, T3, T4).Should().Be(TR);
        }
    }
}