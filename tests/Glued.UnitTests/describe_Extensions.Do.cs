using System;

namespace Glued.UnitTests
{
    public partial class describe_Extensions
    {
        public void describe_Do()
        {
            it["Action<T>"] = () => ((Action) (() => T.Do(A1Throw))).ShouldThrow();
            it["Action<T, T1>"] = () => ((Action) (() => T.Do(A2Throw)(T1))).ShouldThrow();
            it["Action<T, T1, T2>"] = () => ((Action) (() => T.Do(A3Throw)(T1, T2))).ShouldThrow();
            it["Action<T, T1, T2, T3>"] = () => ((Action) (() => T.Do(A4Throw)(T1, T2, T3))).ShouldThrow();
            it["Func<T>"] = () => T.Do(F1);
            it["Func<T, T1>"] = () => T.Do(F2)(T1);
            it["Func<T, T1, T2>"] = () => T.Do(F3)(T1, T2);
            it["Func<T, T1, T2, T3>"] = () => T.Do(F4)(T1, T2, T3);
            it["Func<T, Action<T1>>"] = () => T.Do(FA1)(T1);
            it["Func<T, Action<T1, T2>>"] = () => T.Do(FA2)(T1, T2);
            it["Func<T, Action<T1, T2, T3>>"] = () => T.Do(FA3)(T1, T2, T3);
            it["Func<T, Action<T1, T2, T3, T4>>"] = () => T.Do(FA4)(T1, T2, T3, T4);
        }
    }
}