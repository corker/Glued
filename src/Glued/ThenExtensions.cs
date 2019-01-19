using System;
using System.Collections.Generic;
using System.Linq;
using Glued.Sync;

namespace Glued
{
    public static class ThenExtensions
    {
        public static Func<T2> Then<T1, T2>(this Func<T1> funcA, Func<Func<T1>, T2> funcB)
        {
            return () => funcB(funcA);
        }

        public static Func<T> ThenDo<T>(this Func<T> func, Action<T> action)
        {
            return () => func().Do(action);
        }

        public static Func<IEnumerable<T2>> ThenEach<T1, T2>(this Func<IEnumerable<T1>> funcA, Func<Func<T1>, T2> funcB)
        {
            return () => funcA().Select(_ => _.AsFunc()).Select(funcB);
        }
    }
}