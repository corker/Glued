using System;
using System.Collections.Generic;
using System.Linq;

namespace Glued.Sync
{
    public static class ThenExtensions
    {
        public static Func<T2> Then<T1, T2>(this Func<T1> source, Func<Func<T1>, T2> next)
        {
            return () => next(source);
        }

        public static Func<T> ThenDo<T>(this Func<T> source, Action<T> action)
        {
            return () => source().Do(action);
        }

        public static Func<IEnumerable<T2>> ThenEach<T1, T2>(this Func<IEnumerable<T1>> source, Func<Func<T1>, T2> next)
        {
            return () => source().Select(_ => _.AsFunc()).Select(next);
        }
    }
}