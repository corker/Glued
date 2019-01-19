using System;

namespace Glued.Sync
{
    public static class TakeExtensions
    {
        public static T1 Take<T, T1>(this T target, Func<T, T1> func)
        {
            return func(target);
        }
    }
}