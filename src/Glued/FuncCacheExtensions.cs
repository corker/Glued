using System;

namespace Glued
{
    public static class FuncCacheExtensions
    {
        public static Func<TR> Cache<TR>(this Func<TR> source)
        {
            var lazy = new Lazy<TR>(source);
            return () => lazy.Value;
        }
    }
}