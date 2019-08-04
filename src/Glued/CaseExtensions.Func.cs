using System;

namespace Glued
{
    public static partial class CaseExtensions
    {
        public static Func<Func<T, TR>, TR> Case<T, TR>(this T t, Func<T, bool> guard, Func<T, TR> func)
        {
            return next => guard(t) ? func(t) : next(t);
        }

        public static Func<Func<T, TR>, TR> Case<T, TR>(this Func<Func<T, TR>, TR> source, Func<T, bool> guard, Func<T, TR> func)
        {
            return next => source(t => guard(t) ? func(t) : next(t));
        }

        public static TR Else<T, TR>(this Func<Func<T, TR>, TR> source, Func<T, TR> func)
        {
            return source(func);
        }
    }
}