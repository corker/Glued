﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Glued
{
    public static class ThenMapEachExtensions
    {
        public static IEnumerable<T>
            ThenMapEach<T>(this Func<IEnumerable<Func<T>>> source)
        {
            return source().Select(_ => _());
        }

        public static IEnumerable<TR>
            ThenMapEach<T, TR>(this Func<IEnumerable<T>> source, Func<T, TR> mapper)
        {
            return source().Select(mapper);
        }

        public static Func<T1, IEnumerable<TR>>
            ThenMapEach<T, T1, TR>(this Func<IEnumerable<T>> source, Func<T, T1, TR> mapper)
        {
            return t1 => source().Select(t => mapper(t, t1));
        }

        public static Func<T1, T2, IEnumerable<TR>>
            ThenMapEach<T, T1, T2, TR>(this Func<IEnumerable<T>> source, Func<T, T1, T2, TR> mapper)
        {
            return (t1, t2) => source().Select(t => mapper(t, t1, t2));
        }

        public static Func<T1, T2, T3, IEnumerable<TR>>
            ThenMapEach<T, T1, T2, T3, TR>(this Func<IEnumerable<T>> source, Func<T, T1, T2, T3, TR> mapper)
        {
            return (t1, t2, t3) => source().Select(t => mapper(t, t1, t2, t3));
        }

        public static Func<T1, T2, T3, T4, IEnumerable<TR>>
            ThenMapEach<T, T1, T2, T3, T4, TR>(this Func<IEnumerable<T>> source, Func<T, T1, T2, T3, T4, TR> mapper)
        {
            return (t1, t2, t3, t4) => source().Select(t => mapper(t, t1, t2, t3, t4));
        }
    }
}