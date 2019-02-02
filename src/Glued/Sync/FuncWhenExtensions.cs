using System;

namespace Glued.Sync
{
    public static class FuncWhenExtensions
    {
        public static Func<T> When<T>(this Func<T> source, Func<T, bool> guard, Action<T> action)
        {
            return () => source().Do(_ =>
            {
                if (guard(_)) action(_);
            });
        }
    }
}