using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Glued.Selenium.WebDriver
{
    public static class SearchContextExtensions
    {
        public static Func<IWebElement> FindElement(this Func<ISearchContext> source, By by)
        {
            return () => source().FindElement(by);
        }

        public static Func<IEnumerable<Func<IWebElement>>> FindElements(this Func<ISearchContext> source, By by)
        {
            return () => source().FindElements(by).MapEach(_ => _.AsFunc());
        }

        public static Func<IWebElement> UntilElementFound(this Func<IWait<Func<IWebElement>>> source)
        {
            return source
                .IgnoreExceptionTypes(typeof(NotFoundException), typeof(NoSuchElementException))
                .Until(_ => _());
        }
    }
}