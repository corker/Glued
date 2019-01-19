using System;
using OpenQA.Selenium;

namespace Glued.Selenium.WebDriver.SpecFlowTests.Services
{
    public interface IPage
    {
        Func<IWebDriver> Driver { get; }
    }
}