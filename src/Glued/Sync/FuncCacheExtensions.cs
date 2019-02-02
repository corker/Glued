using System;

namespace Glued.Sync
{
    public static class FuncCacheExtensions
    {
        public static Func<T> Cache<T>(this Func<T> source)
        {
            var lazy = new Lazy<T>(source);
            return () => lazy.Value;
        }
    }
}