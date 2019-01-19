using System;
using System.Linq;
using Glued.Sync;
using OpenQA.Selenium;

namespace Glued.Selenium.WebDriver.SpecFlowTests.Pages
{
    public class ProjectListControl
    {
        public ProjectListControl(Func<IWebDriver> driver)
        {
            Driver = driver;
        }

        public Func<IWebDriver> Driver { get; }

        public Func<IWebElement> Element => Driver
            .FindElement(By.ClassName("list-packages"))
            .Wait()
            .WithTimeout(5.Seconds())
            .UntilElementFound();

        public bool Contains(string value)
        {
            return Element
                .FindElements(By.TagName("article"))
                .Cache()
                .ThenEach(_ => _
                    .FindElement(By.ClassName("package-title"))
                    .Wait()
                    .WithTimeout(1.Second())
                    .UntilElementFound())
                .Wait()
                .WithTimeout(5.Seconds())
                .IgnoreExceptionTypes(typeof(WebDriverTimeoutException))
                .WithMessage($"Package {value} not found.")
                .Map(_ => _.MapEach().Any(x => x.Text == value));
        }
    }
}