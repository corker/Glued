using System;
using FluentAssertions;
using Glued.Sync;
using OpenQA.Selenium;
using Xunit.Abstractions;

namespace Glued.Selenium.WebDriver.SpecFlowTests.Pages
{
    public class HomePage
    {
        public static readonly Func<IWebDriver, ITestOutputHelper, HomePage> Ensure = (driver, helper) =>
        {
            driver.Url.Should().StartWith("https://www.nuget.org/");
            return new HomePage(driver.AsFunc());
        };


        public static readonly Func<IWebDriver, ITestOutputHelper, HomePage> Open = (driver, helper) =>
        {
            driver.Navigate().GoToUrl("https://www.nuget.org/");
            return new HomePage(driver.AsFunc());
        };

        private HomePage(Func<IWebDriver> driver)
        {
            Driver = driver;
        }

        public Func<IWebDriver> Driver { get; }

        public ProjectListControl ProjectList => new ProjectListControl(Driver);

        public void Search(string value)
        {
            Driver()
                .FindElement(By.Id("search"))
                .Do(_ => _.Click())
                .Do(_ => _.SendKeys(value))
                .Do(_ => _.SendKeys(Keys.Enter));
        }
    }
}