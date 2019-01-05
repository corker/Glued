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
                .AsAsync()
                .Do(_ => _.Should().Be(Target));

            await Target
                .AsAsync()
                .Do(_ => _.Should().Be(Target).AsAsync());
        }

        [Fact]
        public async Task Do_Should_Return_Expected_Value()
        {
            await Target
                .AsAsync()
                .Do(_ => { })
                .Do(_ => _.Should().Be(Target));
        }

        [Fact]
        public async Task Take_Should_Give_Expected_Value()
        {
            await Target
                .AsAsync()
                .Take(_ => _.Should().Be(Target));

            await Target
                .AsAsync()
                .Take(_ => _.Should().Be(Target).AsAsync());
        }

        [Fact]
        public async Task Take_Should_Return_Expected_Value()
        {
            await Target
                .AsAsync()
                .Take(_ => Expected)
                .Take(_ => _.Should().Be(Expected));

            await Target
                .AsAsync()
                .Take(_ => Expected.AsAsync())
                .Take(_ => _.Should().Be(Expected));
        }

        [Fact]
        public async Task With_Should_Give_Expected_Value()
        {
            await Target
                .AsAsync()
                .With(
                    _ => _.Should().Be(Target).AsAsync(),
                    _ => Task.CompletedTask
                );

            await Target
                .AsAsync()
                .With(
                    _ => _.Should().Be(Target).AsAsync(),
                    _ => { }
                );
        }

        [Fact]
        public async Task With_Should_Pass_Expected_Value()
        {
            await Target
                .AsAsync()
                .With(
                    _ => Expected.AsAsync(),
                    _ => _.Should().Be(Expected)
                );

            await Target
                .AsAsync()
                .With(
                    _ => Expected.AsAsync(),
                    _ => _.Should().Be(Expected).AsAsync()
                );
        }

        [Fact]
        public async Task With_Should_Return_Expected_Value()
        {
            await Target
                .AsAsync()
                .With(
                    _ => _.ToString().AsAsync(),
                    _ => Task.CompletedTask
                )
                .Do(_ => _.Should().Be(Target));

            await Target
                .AsAsync()
                .With(
                    _ => _.ToString().AsAsync(),
                    _ => { }
                )
                .Do(_ => _.Should().Be(Target));
        }
    }
}