using System;
using System.Linq;
using Glued.Sync;
using OpenQA.Selenium.Support.UI;

namespace Glued.Selenium.WebDriver
{
    public static class DefaultWaitExtensions
    {
        public static Func<IWait<Func<T>>> Wait<T>(this Func<T> source)
        {
            return () => new DefaultWait<Func<T>>(source);
        }

        public static Func<IWait<Func<T>>> WithInterval<T>(this Func<IWait<Func<T>>> source, TimeSpan @const)
        {
            return () => source().Do(_ => _.PollingInterval = @const);
        }

        public static Func<IWait<Func<T>>> WithMessage<T>(this Func<IWait<Func<T>>> source, string @const)
        {
            return () => source().Do(_ => _.Message = @const);
        }

        public static Func<IWait<Func<T>>> WithTimeout<T>(this Func<IWait<Func<T>>> source, TimeSpan @const)
        {
            return () => source().Do(_ => _.Timeout = @const);
        }

        public static Func<IWait<Func<T>>>
            IgnoreExceptionTypes<T>(this Func<IWait<Func<T>>> source, Type first, params Type[] second)
        {
            return () => source().Do(_ => _.IgnoreExceptionTypes(first.Union(second).ToArray()));
        }

        public static Func<TR>
            Until<T, TR>(this Func<IWait<Func<T>>> source, Func<Func<T>, TR> condition) where T : class
        {
            return () => source().Until(condition);
        }

        public static TR
            Map<T, TR>(this Func<IWait<Func<T>>> source, Func<Func<T>, TR> condition) where T : class
        {
            return source().Until(condition);
        }
    }
}