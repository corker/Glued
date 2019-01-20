using System;
using FluentAssertions;
using Glued.Sync;
using OpenQA.Selenium;
using Xunit.Abstractions;

namespace Glued.Selenium.WebDriver.SpecFlowTests.Pages
{
    public class HomePage
    {
        private readonly IWebDriver _driver;
        private readonly ITestOutputHelper _helper;

        private HomePage(IWebDriver driver, ITestOutputHelper helper)
        {
            _helper = helper;
            _driver = driver;
        }

        public static Func<IWebDriver, ITestOutputHelper, HomePage> Ensure => (driver, helper) =>
        {
            driver.Url.Should().StartWith("https://www.nuget.org/");
            return new HomePage(driver, helper);
        };

        public static Func<IWebDriver, ITestOutputHelper, HomePage> Open => (driver, helper) =>
        {
            driver.Navigate().GoToUrl("https://www.nuget.org/");
            return new HomePage(driver, helper);
        };

        public Action<string> Search => value =>
        {
            _driver
                .FindElement(By.Id("search"))
                .Do(_ => _.Click())
                .Do(_ => _.SendKeys(value))
                .Do(_ => _.SendKeys(Keys.Enter));
        };

        public ProjectListControl ProjectList => new ProjectListControl(_driver, _helper);
    }
}