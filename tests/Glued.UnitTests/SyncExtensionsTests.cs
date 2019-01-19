using FluentAssertions;
using Glued.Sync;
using Xunit;

namespace Glued.UnitTests
{
    public class SyncExtensionsTests
    {
        private const int Target = int.MaxValue;
        private static readonly string Expected = Target.ToString();

        [Fact]
        public void Do_Should_Give_Expected_Value()
        {
            Target
                .Do(_ => _.Should().Be(Target));
        }

        [Fact]
        public void Do_Should_Return_Expected_Value()
        {
            Target
                .Do(_ => { })
                .Should().Be(Target);
        }

        [Fact]
        public void Take_Should_Give_Expected_Value()
        {
            Target
                .Map(_ => _.Should().Be(Target));
        }

        [Fact]
        public void Take_Should_Return_Expected_Value()
        {
            Target
                .Map(_ => Expected)
                .Should().Be(Expected);
        }

        [Fact]
        public void With_Should_Give_Expected_Value()
        {
            Target.With(
                _ => _.Should().Be(Target),
                _ => { }
            );
        }

        [Fact]
        public void With_Should_Pass_Expected_Value()
        {
            Target.With(
                _ => Expected,
                _ => _.Should().Be(Expected)
            );
        }

        [Fact]
        public void With_Should_Return_Expected_Value()
        {
            Target
                .With(
                    _ => _,
                    _ => { }
                )
                .Should().Be(Target);
        }
    }
}