using System;
using System.Collections.Generic;
using System.Linq;
using Glued.Sync;

namespace Glued
{
    public static class MapExtensions
    {
        public static IEnumerable<T2> MapEach<T1, T2>(this Func<IEnumerable<T1>> funcA, Func<T1, T2> funcB)
        {
            return funcA().Select(funcB);
        }

        public static IEnumerable<T> MapEach<T>(this Func<IEnumerable<Func<T>>> func)
        {
            return func().Select(_ => _());
        }

        public static T2 Map<T1, T2>(this Func<T1> funcA, Func<T1, T2> funcB)
        {
            return funcA().Take(funcB);
        }

        public static T Map<T>(this Func<T> func)
        {
            return func();
        }
    }
}