using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Glued.Selenium.WebDriver
{
    public static class SearchContextExtensions
    {
        public static Func<IWebElement> FindElement(this Func<ISearchContext> context, By by)
        {
            return () => context().FindElement(by);
        }

        public static Func<IEnumerable<IWebElement>> FindElements(this Func<ISearchContext> context, By by)
        {
            return () => context().FindElements(by);
        }

        public static Func<IWebElement> UntilElementFound(this Func<IWait<Func<IWebElement>>> context)
        {
            return context
                .IgnoreExceptionTypes(typeof(NotFoundException), typeof(NoSuchElementException))
                .Until(_ => _());
        }
    }
}