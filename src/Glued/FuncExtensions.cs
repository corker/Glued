using System;

namespace Glued
{
    public static class FuncExtensions
    {
        public static Func<T> AsFunc<T>(this T value)
        {
            return () => value;
        }

        public static Func<T> Cache<T>(this Func<T> context)
        {
            var lazy = new Lazy<T>(context);
            return () => lazy.Value;
        }
    }
}