using System;
using NSpec;

namespace Glued.UnitTests
{
    public partial class describe_Extensions : nspec
    {
        public void describe_AsAction()
        {
            it["Func<TR>"] = () => ((Action) (() => FE0.AsAction()())).ShouldThrow();
            it["Func<T1, TR>"] = () => ((Action) (() => FE1.AsAction()(T1))).ShouldThrow();
            it["Func<T1, T2, TR>"] = () => ((Action) (() => FE2.AsAction()(T1, T2))).ShouldThrow();
            it["Func<T1, T2, T3, TR>"] = () => ((Action) (() => FE3.AsAction()(T1, T2, T3))).ShouldThrow();
            it["Func<T1, T2, T3, T4, TR>"] = () => ((Action) (() => FE4.AsAction()(T1, T2, T3, T4))).ShouldThrow();
        }
    }
}