using System;
using OpenQA.Selenium;

namespace Glued.Selenium.WebDriver.SpecFlowTests.Services
{
    public interface IPageControl
    {
        Func<IWebDriver> Driver { get; }
        Func<IWebElement> Element { get; }
    }
}