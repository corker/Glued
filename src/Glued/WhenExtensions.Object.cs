using System;

namespace Glued
{
    public static partial class WhenExtensions
    {
        public static T When<T>(this T t, Func<T, bool> positive, Action<T> action)
        {
            return t.Do(_ =>
            {
                if (positive(_)) action(_);
            });
        }
    }
}