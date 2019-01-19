using System.Threading.Tasks;
using FluentAssertions;
using Glued.Async;
using Xunit;

namespace Glued.UnitTests
{
    public class AsyncExtensionsTests
    {
        private const int Target = int.MaxValue;
        private static readonly string Expected = Target.ToString();

        [Fact]
        public async Task Do_Should_Give_Expected_Value()
        {
            await Target
                .AsTask()
                .Do(_ => _.Should().Be(Target));

            await Target
                .AsTask()
                .Do(_ => _.Should().Be(Target).AsTask());
        }

        [Fact]
        public async Task Do_Should_Return_Expected_Value()
        {
            await Target
                .AsTask()
                .Do(_ => { })
                .Do(_ => _.Should().Be(Target));
        }

        [Fact]
        public async Task Take_Should_Give_Expected_Value()
        {
            await Target
                .AsTask()
                .Map(_ => _.Should().Be(Target));

            await Target
                .AsTask()
                .Map(_ => _.Should().Be(Target).AsTask());
        }

        [Fact]
        public async Task Take_Should_Return_Expected_Value()
        {
            await Target
                .AsTask()
                .Map(_ => Expected)
                .Map(_ => _.Should().Be(Expected));

            await Target
                .AsTask()
                .Map(_ => Expected.AsTask())
                .Map(_ => _.Should().Be(Expected));
        }

        [Fact]
        public async Task With_Should_Give_Expected_Value()
        {
            await Target
                .AsTask()
                .With(
                    _ => _.Should().Be(Target).AsTask(),
                    _ => Task.CompletedTask
                );

            await Target
                .AsTask()
                .With(
                    _ => _.Should().Be(Target).AsTask(),
                    _ => { }
                );
        }

        [Fact]
        public async Task With_Should_Pass_Expected_Value()
        {
            await Target
                .AsTask()
                .With(
                    _ => Expected.AsTask(),
                    _ => _.Should().Be(Expected)
                );

            await Target
                .AsTask()
                .With(
                    _ => Expected.AsTask(),
                    _ => _.Should().Be(Expected).AsTask()
                );
        }

        [Fact]
        public async Task With_Should_Return_Expected_Value()
        {
            await Target
                .AsTask()
                .With(
                    _ => _.ToString().AsTask(),
                    _ => Task.CompletedTask
                )
                .Do(_ => _.Should().Be(Target));

            await Target
                .AsTask()
                .With(
                    _ => _.ToString().AsTask(),
                    _ => { }
                )
                .Do(_ => _.Should().Be(Target));
        }
    }
}