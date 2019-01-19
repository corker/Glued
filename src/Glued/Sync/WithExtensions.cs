using System;

namespace Glued.Sync
{
    public static class WithExtensions
    {
        public static T With<T, T1>(this T source, Func<T, T1> mapper, Action<T1> action)
        {
            return source.Do(_ => _.Map(mapper).Do(action)); ;
        }
    }
}