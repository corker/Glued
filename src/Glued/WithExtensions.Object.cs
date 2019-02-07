using System;

namespace Glued
{
    public static partial class WithExtensions
    {
        public static T With<T, T1>(this T t, Func<T, T1> mapper, Action<T1> action)
        {
            return t.Do(_ => _.Map(mapper).Do(action)); ;
        }
    }
}