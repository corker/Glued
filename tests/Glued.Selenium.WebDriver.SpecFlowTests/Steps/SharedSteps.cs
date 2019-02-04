using TechTalk.SpecFlow;

namespace Glued.Selenium.WebDriver.SpecFlowTests.Steps
{
    [Binding]
    public class SharedSteps
    {
        private readonly ScenarioContext _context;

        public SharedSteps(ScenarioContext context)
        {
            _context = context;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            _context
                .UseWebDriver(_ => _
                    .Manage()
                    .Do(x => x.Window.Maximize())
                    .Do(x => x.Timeouts().ImplicitWait = Defaults.ImplicitWait));
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _context
                .GetWebDriver()
                .Quit();
        }
    }
}