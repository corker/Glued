using System;
using System.Threading.Tasks;

namespace Glued.Threading.Tasks
{
    public static class CaseAsyncExtensions
    {
        public static Func<Func<T, Task<TR>>, Task<TR>> CaseAsync<T, TR>(this Task<T> t, Func<T, bool> guard, Func<T, Task<TR>> func)
        {
            return async next =>
            {
                var result = await t;
                
                return guard(result)
                    ? await func(result)
                    : await next(result);
            };
        }
        
        public static Func<Func<T, Task<TR>>, Task<TR>> CaseAsync<T, TR>(this Func<Func<T, Task<TR>>, Task<TR>> source, Func<T, bool> guard, Func<T, Task<TR>> func)
        {
            return async next => await source(async t => guard(t) ? await func(t) : await next(t));
        }
        
        public static async Task<TR> ElseAsync<T, TR>(this Func<Func<T, Task<TR>>, Task<TR>> source, Func<T, Task<TR>> func)
        {
            return await source(func);
        }
    }
}