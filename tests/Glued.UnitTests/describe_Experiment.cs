using System;
using FakeItEasy;
using NSpec;
using Xunit;
using Xunit.Abstractions;

// ReSharper disable InconsistentNaming

namespace Glued.UnitTests
{
    public class describe_Experiment : nspec
    {
        private const int TR = 1;

        private static readonly Func<int> F0 = () => TR;

        public void it_()
        {
            var thenDo = A.Fake<Action<int>>();
            var thenWhenTrue = A.Fake<Action<int>>();
            var thenWhenFalse = A.Fake<Action<int>>();
            var thenWith = A.Fake<Action<string>>();
            var thenMap = A.Fake<Func<int, string>>();

            A.CallTo(() => thenMap(TR)).Returns(TR.ToString());

            F0
                .ThenDo(thenDo)
                .ThenWhen(true, thenWhenTrue)
                .ThenWhen(false, thenWhenFalse)
                .ThenWith(_ => _.ToString(), thenWith)
                .ThenMap(thenMap)
                ();

            A.CallTo(() => thenDo(TR)).MustHaveHappened(1, Times.Exactly);
            A.CallTo(() => thenWhenTrue(TR)).MustHaveHappened(1, Times.Exactly);
            A.CallTo(() => thenWhenFalse(TR)).MustNotHaveHappened();
            A.CallTo(() => thenWith(TR.ToString())).MustHaveHappened(1, Times.Exactly);
            A.CallTo(() => thenMap(TR)).MustHaveHappened(1, Times.Exactly);
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
                _helper.Run<describe_Experiment>();
            }
        }
    }
}