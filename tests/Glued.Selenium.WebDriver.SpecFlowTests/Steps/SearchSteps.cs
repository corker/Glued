using FluentAssertions;
using Glued.Selenium.WebDriver.SpecFlowTests.Pages;
using TechTalk.SpecFlow;

namespace Glued.Selenium.WebDriver.SpecFlowTests.Steps
{
    [Binding]
    public class SearchSteps
    {
        private readonly ScenarioContext _context;

        public SearchSteps(ScenarioContext context)
        {
            _context = context;
        }

        [Given(@"I am on the nuget\.org website")]
        public void GivenIAmOnTheNuget_OrgWebsite()
        {
            _context.Do(HomePage.Open);
        }

        [When(@"I search for NOpenPage project")]
        public void WhenISearchForNOpenPageProject()
        {
            _context
                .With(HomePage.Ensure)
                .Search("NOpenPage");
        }

        [Then(@"the NOpenPage project is present in the search result")]
        public void ThenTheNOpenPageProjectIsPresentInTheSearchResult()
        {
            _context
                .With(HomePage.Ensure)
                .ProjectList
                .Contains("NOpenPage")
                .Should().BeTrue();
        }
    }
}