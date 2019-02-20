using System;
using System.Threading.Tasks;

namespace Glued.Threading.Tasks
{
    public static class WithAsyncExtensions
    {
        public static Task<T>
            WithAsync<T, TR>(this Task<T> source, Func<T, TR> mapper, Func<TR, Task> action)
        {
            return source.DoAsync(_ => _.Map(mapper).Map(action));
        }

        public static Func<T1, Task<T>>
            WithAsync<T, T1, TR>(this Task<T> source, Func<T, TR> mapper, Func<TR, T1, Task> action)
        {
            return t1 => source.DoAsync(_ => _.Map(mapper).Map(action)(t1));
        }

        public static Func<T1, T2, Task<T>>
            WithAsync<T, T1, T2, TR>(this Task<T> source, Func<T, TR> mapper, Func<TR, T1, T2, Task> action)
        {
            return (t1, t2) => source.DoAsync(_ => _.Map(mapper).Map(action)(t1, t2));
        }

        public static Func<T1, T2, T3, Task<T>>
            WithAsync<T, T1, T2, T3, TR>(this Task<T> source, Func<T, TR> mapper, Func<TR, T1, T2, T3, Task> action)
        {
            return (t1, t2, t3) => source.DoAsync(_ => _.Map(mapper).Map(action)(t1, t2, t3));
        }

        public static Task<T>
            WithAsync<T, TR>(this Task<T> source, Func<T, TR> mapper, Action<TR> action)
        {
            return source.DoAsync(_ => _.Map(mapper).Do(action));
        }

        public static Func<T1, Task<T>>
            WithAsync<T, T1, TR>(this Task<T> source, Func<T, TR> mapper, Action<TR, T1> action)
        {
            return t1 => source.DoAsync(_ => _.Map(mapper).Do(action)(t1));
        }

        public static Func<T1, T2, Task<T>>
            WithAsync<T, T1, T2, TR>(this Task<T> source, Func<T, TR> mapper, Action<TR, T1, T2> action)
        {
            return (t1, t2) => source.DoAsync(_ => _.Map(mapper).Do(action)(t1, t2));
        }

        public static Func<T1, T2, T3, Task<T>>
            WithAsync<T, T1, T2, T3, TR>(this Task<T> source, Func<T, TR> mapper, Action<TR, T1, T2, T3> action)
        {
            return (t1, t2, t3) => source.DoAsync(_ => _.Map(mapper).Do(action)(t1, t2, t3));
        }
    }
}