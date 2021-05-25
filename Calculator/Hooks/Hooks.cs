using System.Linq;
using Calculator.App.Configuration;
using Calculator.Framework.Application;
using TechTalk.SpecFlow;
using TestStack.White;
using Calculator.Framework.Logger;


namespace Calculator.Hooks
{
    [Binding]
    public class Hooks
    {
        [BeforeScenario(Order = 0)]
        public static void StartApplication(ScenarioContext scenarioContext)
        {
            foreach (var window in Desktop.Instance.Windows().Where(window => window.Title.Equals(Configuration.WindowName)))
            {
                window.Close();
            }
            LoggerUtil.LogInfo("Application started");
            ApplicationDriver.GetApplication();
        }

        [AfterScenario]
        public static void TearDown()
        {
            LoggerUtil.LogInfo("Application killed");
            ApplicationDriver.KillApplication();
        }
    }
}
