using System;

namespace Glued.Sync
{
    public static class WithExtensions
    {
        public static T With<T, T1>(this T target, Func<T, T1> func, Action<T1> action)
        {
            return target.Do(_ => _.Take(func).Do(action)); ;
        }
    }
}