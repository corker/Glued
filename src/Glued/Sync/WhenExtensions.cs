using System;

namespace Glued.Sync
{
    public static class WhenExtensions
    {
        public static T When<T>(this T source, Func<T, bool> positive, Action<T> action)
        {
            return source.Do(_ =>
            {
                if (positive(_)) action(_);
            });
        }
    }
}