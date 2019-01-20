using System;
using System.Collections.Generic;
using System.Linq;

namespace Glued.Sync
{
    public static class ThenExtensions
    {
        public static Func<TR> Then<T, TR>(this Func<T> source, Func<Func<T>, TR> next)
        {
            return () => next(source);
        }

        public static Func<T> ThenDo<T>(this Func<T> source, Action<T> action)
        {
            return () => source().Do(action);
        }

        public static Func<IEnumerable<TR>> ThenEach<T, TR>(this Func<IEnumerable<T>> source, Func<Func<T>, TR> next)
        {
            return () => source().Select(_ => _.AsFunc()).Select(next);
        }
    }
}