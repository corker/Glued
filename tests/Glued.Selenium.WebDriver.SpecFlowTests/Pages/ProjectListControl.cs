using System;
using System.Linq;
using Glued.Selenium.WebDriver.SpecFlowTests.Services;
using OpenQA.Selenium;

namespace Glued.Selenium.WebDriver.SpecFlowTests.Pages
{
    public class ProjectListControl
    {
        private readonly Func<IWebDriver> _driver;
        private readonly ILogger _logger;

        public ProjectListControl(IWebDriver driver, ILogger logger)
        {
            _logger = logger;
            _driver = driver.AsFunc();
        }

        public Func<IWebElement> Element =>
            _driver
                .FindElement(By.ClassName("list-packages"))
                .Wait()
                .WithTimeout(5.Seconds())
                .UntilElementFound()
                .Cache();

        public Func<string, bool> Contains => value =>
            Element
                .FindElements(By.TagName("article"))
                .ThenDo(_ => _logger.WriteLine("Packages:"))
                .ThenEach(_ => _
                    .FindElement(By.ClassName("package-title"))
                    .Wait()
                    .WithTimeout(1.Second())
                    .UntilElementFound()
                    .ThenDo(x => _logger.WriteLine($"-> {x.Text}")))
                .Wait()
                .WithTimeout(5.Seconds())
                .IgnoreExceptionTypes(typeof(WebDriverTimeoutException))
                .WithMessage($"Package {value} not found.")
                .Map(_ => _.MapEach().Any(x => x.Text == value));
    }
}