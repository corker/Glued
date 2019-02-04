using System;
using System.Collections.Generic;
using System.Linq;

namespace Glued
{
    public static class FuncThenEachExtensions
    {
        public static Func<IEnumerable<TR>> ThenEach<T, TR>(this Func<IEnumerable<T>> source, Func<Func<T>, TR> next)
        {
            return () => source().Select(_ => _.AsFunc()).Select(next);
        }
    }
}