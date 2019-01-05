using System;

namespace Glued.Sync
{
    public static class SyncExtensions
    {
        public static T Do<T>(this T target, Action<T> action)
        {
            action(target);
            return target;
        }

        public static T1 Take<T, T1>(this T target, Func<T, T1> func)
        {
            return func(target);
        }

        public static T With<T, T1>(this T target, Func<T, T1> func, Action<T1> action)
        {
            target.Take(func).Do(action);
            return target;
        }
    }
}