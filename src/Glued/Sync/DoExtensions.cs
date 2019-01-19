using System;

namespace Glued.Sync
{
    public static class DoExtensions
    {
        public static T Do<T>(this T source, Action<T> action)
        {
            action(source);
            return source;
        }
    }
}