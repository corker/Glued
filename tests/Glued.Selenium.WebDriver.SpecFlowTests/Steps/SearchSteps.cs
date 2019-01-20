using FluentAssertions;
using Glued.Selenium.WebDriver.SpecFlowTests.Pages;
using Glued.Sync;
using TechTalk.SpecFlow;
using Xunit.Abstractions;

namespace Glued.Selenium.WebDriver.SpecFlowTests.Steps
{
    [Binding]
    public class SearchSteps
    {
        private readonly ScenarioContext _context;
        private readonly ITestOutputHelper _helper;

        public SearchSteps(ScenarioContext context, ITestOutputHelper helper)
        {
            _context = context;
            _helper = helper;
        }

        [Given(@"I am on the nuget\.org website")]
        public void GivenIAmOnTheNuget_OrgWebsite()
        {
            _context
                .GetWebDriver()
                .Do(HomePage.Open)(_helper);
        }

        [When(@"I search for (.*) project")]
        public void WhenISearchForProject(string value)
        {
            _context
                .GetWebDriver()
                .Map(HomePage.Ensure)(_helper)
                .Do(_ => _.Search)(value)
                .Do(_ => _helper.WriteLine($"Search for {value} project"));
        }

        [Then(@"the (.*) project is present in the search result")]
        public void ThenTheProjectIsPresentInTheSearchResult(string value)
        {
            _context
                .GetWebDriver()
                .Map(HomePage.Ensure)(_helper)
                .ProjectList
                .Contains(value)
                .Should().BeTrue();
        }
    }
}