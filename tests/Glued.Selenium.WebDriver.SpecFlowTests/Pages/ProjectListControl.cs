using System;
using System.Linq;
using Glued.Sync;
using OpenQA.Selenium;
using Xunit.Abstractions;

namespace Glued.Selenium.WebDriver.SpecFlowTests.Pages
{
    public class ProjectListControl
    {
        private readonly Func<IWebDriver> _driver;
        private readonly ITestOutputHelper _helper;

        public ProjectListControl(IWebDriver driver, ITestOutputHelper helper)
        {
            _helper = helper;
            _driver = driver.AsFunc();
        }

        public Func<IWebElement> Element =>
            _driver
                .FindElement(By.ClassName("list-packages"))
                .Wait()
                .WithTimeout(5.Seconds())
                .UntilElementFound();

        public Func<string, bool> Contains => value =>
            Element
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