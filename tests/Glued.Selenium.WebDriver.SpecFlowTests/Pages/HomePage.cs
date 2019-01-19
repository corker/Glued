using System;
using FluentAssertions;
using Glued.Sync;
using OpenQA.Selenium;

namespace Glued.Selenium.WebDriver.SpecFlowTests.Pages
{
    public class HomePage
    {
        private HomePage(Func<IWebDriver> driver)
        {
            Driver = driver;
        }

        public Func<IWebDriver> Driver { get; }

        public ProjectListControl ProjectList => new ProjectListControl(Driver);


        public static HomePage Open(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("https://www.nuget.org/");
            return new HomePage(driver.AsFunc());
        }

        public static HomePage Ensure(IWebDriver driver)
        {
            driver.Url.Should().StartWith("https://www.nuget.org/");
            return new HomePage(driver.AsFunc());
        }

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