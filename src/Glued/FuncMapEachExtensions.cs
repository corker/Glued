using System;
using System.Collections.Generic;
using System.Linq;

namespace Glued
{
    public static class FuncMapEachExtensions
    {
        public static IEnumerable<TR>
            MapEach<TR>(this Func<IEnumerable<Func<TR>>> source)
        {
            return source().Select(_ => _());
        }

        public static IEnumerable<TR>
            MapEach<T, TR>(this Func<IEnumerable<T>> source, Func<T, TR> mapper)
        {
            return source().Select(mapper);
        }
    }
}