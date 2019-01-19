using System;

namespace Glued.Sync
{
    public static class FuncExtensions
    {
        public static Func<T> AsFunc<T>(this T source)
        {
            return () => source;
        }

        public static Func<T> Cache<T>(this Func<T> source)
        {
            var lazy = new Lazy<T>(source);
            return () => lazy.Value;
        }
    }
}