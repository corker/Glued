using System;

namespace Glued.Sync
{
    public static class FuncThenDoExtensions
    {
        public static Func<T> ThenDo<T>(this Func<T> source, Action<T> action)
        {
            return () => source().Do(action);
        }
    }
}