using Glued.UnitTests.Actions;
using NSpec;
using Xunit;
using Xunit.Abstractions;

namespace Glued.UnitTests
{
    public class describe_DoExtensions : nspec
    {
        public void call_with()
        {
            it["Action<T1>"] = () => this.T1().Do(this.Action1());
            it["Action<T1, T2>"] = () => this.T1().Do(this.Action2())(this.T2());
            it["Action<T1, T2, T3>"] = () => this.T1().Do(this.Action3())(this.T2(), this.T3());
            it["Action<T1, T2, T3, T4>"] = () => this.T1().Do(this.Action4())(this.T2(), this.T3(), this.T4());
        }

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
                _helper.Run<describe_DoExtensions>();
            }
        }
    }
}