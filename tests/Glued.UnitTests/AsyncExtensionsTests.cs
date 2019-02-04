using System.Threading.Tasks;
using FluentAssertions;
using Glued.Threading.Tasks;
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
                .DoAsync(_ => _.Should().Be(Target));

            await Target
                .AsTask()
                .DoAsync(_ => _.Should().Be(Target).AsTask());
        }

        [Fact]
        public async Task Do_Should_Return_Expected_Value()
        {
            await Target
                .AsTask()
                .DoAsync(_ => { })
                .DoAsync(_ => _.Should().Be(Target));
        }

        [Fact]
        public async Task Take_Should_Give_Expected_Value()
        {
            await Target
                .AsTask()
                .MapAsync(_ => _.Should().Be(Target));

            await Target
                .AsTask()
                .MapAsync(_ => _.Should().Be(Target).AsTask());
        }

        [Fact]
        public async Task Take_Should_Return_Expected_Value()
        {
            await Target
                .AsTask()
                .MapAsync(_ => Expected)
                .MapAsync(_ => _.Should().Be(Expected));

            await Target
                .AsTask()
                .MapAsync(_ => Expected.AsTask())
                .MapAsync(_ => _.Should().Be(Expected));
        }

        [Fact]
        public async Task With_Should_Give_Expected_Value()
        {
            await Target
                .AsTask()
                .WithAsync(
                    _ => _.Should().Be(Target).AsTask(),
                    _ => Task.CompletedTask
                );

            await Target
                .AsTask()
                .WithAsync(
                    _ => _.Should().Be(Target).AsTask(),
                    _ => { }
                );
        }

        [Fact]
        public async Task With_Should_Pass_Expected_Value()
        {
            await Target
                .AsTask()
                .WithAsync(
                    _ => Expected.AsTask(),
                    _ => _.Should().Be(Expected)
                );

            await Target
                .AsTask()
                .WithAsync(
                    _ => Expected.AsTask(),
                    _ => _.Should().Be(Expected).AsTask()
                );
        }

        [Fact]
        public async Task With_Should_Return_Expected_Value()
        {
            await Target
                .AsTask()
                .WithAsync(
                    _ => _.ToString().AsTask(),
                    _ => Task.CompletedTask
                )
                .DoAsync(_ => _.Should().Be(Target));

            await Target
                .AsTask()
                .WithAsync(
                    _ => _.ToString().AsTask(),
                    _ => { }
                )
                .DoAsync(_ => _.Should().Be(Target));
        }
    }
}