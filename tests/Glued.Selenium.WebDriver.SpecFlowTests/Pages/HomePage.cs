using System;
using FluentAssertions;
using Glued.Selenium.WebDriver.SpecFlowTests.Services;
using Glued.Sync;
using OpenQA.Selenium;

namespace Glued.Selenium.WebDriver.SpecFlowTests.Pages
{
    public class HomePage
    {
        private readonly IWebDriver _driver;
        private readonly ILogger _logger;

        private HomePage(IWebDriver driver, ILogger logger)
        {
            _logger = logger;
            _driver = driver;
        }

        public static Func<IWebDriver, ILogger, HomePage> Ensure => (driver, logger) =>
        {
            driver.Url.Should().StartWith("https://www.nuget.org/");
            return new HomePage(driver, logger);
        };

        public static Func<IWebDriver, ILogger, HomePage> Open => (driver, logger) =>
        {
            driver.Navigate().GoToUrl("https://www.nuget.org/");
            return new HomePage(driver, logger);
        };

        public Action<string> Search => value =>
        {
            _driver
                .FindElement(By.Id("search"))
                .Do(_ => _.Click())
                .Do(_ => _.SendKeys(value))
                .Do(_ => _.SendKeys(Keys.Enter));
        };

        public ProjectListControl ProjectList => new ProjectListControl(_driver, _logger);
    }
}