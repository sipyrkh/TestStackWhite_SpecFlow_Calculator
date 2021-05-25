using System.Linq;
using Calculator.App.Configuration;
using TechTalk.SpecFlow;
using NUnit.Framework;
using Calculator.App.PageObject.Forms;
using Calculator.App.PageObject.Menu;
using Calculator.Framework.Application;

namespace Calculator.Steps
{
    [Binding]
    public class CalculatorSteps
    {
        private readonly Menu menu = new Menu();
        private readonly ControlPanelForm insertForm = new ControlPanelForm();
        private readonly ResultFieldForm resultForm = new ResultFieldForm();
        
        [Given(@"Calculator is started")]
        public void StartCalculator()
        {
            Assert.IsTrue(ApplicationDriver.IsApplicationStart(), "Application is not started");
        }

        [When(@"I select calculator mode '(Standard|Scientific)'")]
        public void SelectMode(string mode)
        {
            switch (mode)
            {
                case "Standard":
                    menu.SelectMenuCategory(Configuration.ViewOption, Configuration.StandardMode);
                    break;
                case "Scientific":
                    menu.SelectMenuCategory(Configuration.ViewOption, Configuration.ScientificMode);
                    break;
            }
        }

        [When(@"I input '(.*)'")]
        public void InputNumber12(string number)
        {
            var arrayNumbers = number.Select(x => new string(x, 1)).ToArray();
            foreach (var partNumber in arrayNumbers)
            {
                insertForm.ClickOnNumber(partNumber);
            }
        }

        [When(@"I click plus button")]
        public void PressPlusButton()
        {
            insertForm.ClickPlusButton();
        }

        [When(@"I click result button and click 'Add To Memory' button")]
        public void PressResultButtonAndMPlus()
        {
            insertForm.ClickResultButton();
            insertForm.ClickMemoryPlusButton();
        }

        [When(@"I add the entered number with the number from memory")]
        public void AddEnteredNumberToNumberFromMemory()
        {
            insertForm.ClickPlusButton();
            insertForm.ClickMemoryRecallButton();
            insertForm.ClickResultButton();
        }

        [Then(@"The result should be '(.*)'")]
        public void CheckIsResultCorrect(string expected)
        {
            var actualResult = resultForm.GetResult();
            Assert.AreEqual(expected, actualResult, $"Should be {expected}, but was {actualResult}");
        }
    }
}
