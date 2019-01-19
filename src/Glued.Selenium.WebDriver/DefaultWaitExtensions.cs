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

        public static Func<IWait<Func<T>>> WithInterval<T>(this Func<IWait<Func<T>>> source, TimeSpan value)
        {
            return () => source().Do(_ => _.PollingInterval = value);
        }

        public static Func<IWait<Func<T>>> WithMessage<T>(this Func<IWait<Func<T>>> source, string value)
        {
            return () => source().Do(_ => _.Message = value);
        }

        public static Func<IWait<Func<T>>> WithTimeout<T>(this Func<IWait<Func<T>>> source, TimeSpan value)
        {
            return () => source().Do(_ => _.Timeout = value);
        }

        public static Func<IWait<Func<T>>>
            IgnoreExceptionTypes<T>(this Func<IWait<Func<T>>> source, Type type, params Type[] types)
        {
            return () => source().Do(_ => _.IgnoreExceptionTypes(type.Union(types).ToArray()));
        }

        public static Func<T1>
            Until<T, T1>(this Func<IWait<Func<T>>> source, Func<Func<T>, T1> condition) where T : class
        {
            return () => source().Until(condition);
        }

        public static T1
            Map<T, T1>(this Func<IWait<Func<T>>> source, Func<Func<T>, T1> condition) where T : class
        {
            return source().Until(condition);
        }
    }
}