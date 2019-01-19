using System;
using Glued.Selenium.WebDriver.SpecFlowTests.Services;
using Glued.Sync;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Glued.Selenium.WebDriver.SpecFlowTests
{
    public static class ScenarioContextExtensions
    {
        public static ScenarioContext UseWebDriver(this ScenarioContext context, Action<IWebDriver> action = null)
        {
            var featureContext = context.ScenarioContainer.Resolve<FeatureContext>();
            var scenarioTitle = context.ScenarioInfo.Title;
            var featureTitle = featureContext.FeatureInfo.Title;
            return context.Do(_ =>
                WebDriverFactory
                    .Create(scenarioTitle, featureTitle)
                    .Do(action.AsOptional())
                    .Do(_.Set));
        }

        public static IWebDriver GetWebDriver(this ScenarioContext context)
        {
            return context.Get<IWebDriver>();
        }

        public static T With<T>(this ScenarioContext context, Func<IWebDriver, T> func)
        {
            return context.GetWebDriver().Map(func);
        }

        public static void Do<T>(this ScenarioContext context, Func<IWebDriver, T> func)
        {
            context.GetWebDriver().Map(func);
        }
    }
}