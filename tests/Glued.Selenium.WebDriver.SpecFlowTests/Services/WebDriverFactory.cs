using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace Glued.Selenium.WebDriver.SpecFlowTests.Services
{
    public static class WebDriverFactory
    {
        public static RemoteWebDriver Create(string scenarioTitle, string featureTitle)
        {
            var options = new ChromeOptions();
            return new ChromeDriver(options);
        }
    }
}