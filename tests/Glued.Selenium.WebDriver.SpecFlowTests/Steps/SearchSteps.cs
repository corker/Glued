using FluentAssertions;
using Glued.Selenium.WebDriver.SpecFlowTests.Pages;
using Glued.Selenium.WebDriver.SpecFlowTests.Services;
using TechTalk.SpecFlow;
using Xunit.Abstractions;

namespace Glued.Selenium.WebDriver.SpecFlowTests.Steps
{
    [Binding]
    public class SearchSteps
    {
        private readonly ScenarioContext _context;
        private readonly ILogger _logger;

        public SearchSteps(ScenarioContext context, ITestOutputHelper helper)
        {
            _context = context;
            _logger = new Logger(helper);
        }

        [Given(@"I am on the nuget\.org website")]
        public void GivenIAmOnTheNuget_OrgWebsite()
        {
            _context
                .GetWebDriver()
                .Do(_ => _logger.WriteLine("Navigating to nuget.org home page..."))
                .Do(HomePage.Open)(_logger);
        }

        [When(@"I search for (.*) project")]
        public void WhenISearchForProject(string value)
        {
            _context
                .GetWebDriver()
                .Map(HomePage.Ensure)(_logger)
                .Do(_ => _
                    .Do(x => _logger.WriteLine($"Enter: Search({x})"))
                    .Search
                    .Stopwatch((x, s) => _logger.WriteLine($"Search({x}) execution time {s.ElapsedMilliseconds}ms"))
                    .ThenDo(x => _logger.WriteLine($"Exit:  Search({x})"))
                )
                (value);
        }

        [Then(@"the (.*) project is present in the search result")]
        public void ThenTheProjectIsPresentInTheSearchResult(string value)
        {
            _context
                .GetWebDriver()
                .Map(HomePage.Ensure)(_logger)
                .ProjectList
                .Contains.Log(_logger)(value)
                .Should().BeTrue();
        }
    }
}