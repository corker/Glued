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

        public static Func<T, TR>
            With<T, TR>(this ScenarioContext context, Func<IWebDriver, T, TR> mapper)
        {
            return context.GetWebDriver().Map(mapper.Curry());
        }

        public static Func<T1, Func<T2, TR>>
            With<T1, T2, TR>(this ScenarioContext context, Func<IWebDriver, T1, T2, TR> mapper)
        {
            return context.GetWebDriver().Map(mapper.Curry());
        }

        public static void Do<T>(this ScenarioContext context, Func<IWebDriver, T> func)
        {
            context.With(func);
        }

        public static Action<T>
            Do<T, TR>(this ScenarioContext context, Func<IWebDriver, T, TR> mapper)
        {
            Action<IWebDriver, T> action = (x, y) => { mapper(x, y); };
            return context.GetWebDriver().Map(action.Curry());
        }

        public static Func<T1, Action<T2>>
            Do<T1, T2, TR>(this ScenarioContext context, Func<IWebDriver, T1, T2, TR> mapper)
        {
            Action<IWebDriver, T1, T2> action = (x, y, z) => { mapper(x, y, z); };
            return context.GetWebDriver().Map(action.Curry());
        }
    }
}