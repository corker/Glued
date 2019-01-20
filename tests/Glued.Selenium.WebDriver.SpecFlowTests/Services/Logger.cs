using Xunit.Abstractions;

namespace Glued.Selenium.WebDriver.SpecFlowTests.Services
{
    public class Logger : ILogger
    {
        private readonly ITestOutputHelper _helper;

        public Logger(ITestOutputHelper helper)
        {
            _helper = helper;
        }

        public void WriteLine(string message)
        {
            _helper.WriteLine(message);
        }
    }
}