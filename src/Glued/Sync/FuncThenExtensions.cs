using System;

namespace Glued.Sync
{
    public static class FuncThenExtensions
    {
        public static Func<TR> Then<T, TR>(this Func<T> source, Func<Func<T>, TR> next)
        {
            return () => next(source);
        }
    }
}