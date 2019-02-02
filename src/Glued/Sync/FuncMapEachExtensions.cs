using System;
using System.Collections.Generic;
using System.Linq;

namespace Glued.Sync
{
    public static class FuncMapEachExtensions
    {
        public static IEnumerable<T>
            MapEach<T>(this Func<IEnumerable<Func<T>>> source)
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