using System;

namespace Glued.Sync
{
    public static class DoExtensions
    {
        public static T Do<T>(this T target, Action<T> action)
        {
            action(target);
            return target;
        }
    }
}