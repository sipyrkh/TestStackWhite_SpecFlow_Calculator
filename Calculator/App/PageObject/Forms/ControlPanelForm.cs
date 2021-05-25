using TestStack.White.UIItems.Finders;
using Calculator.Framework.Element;

namespace Calculator.App.PageObject.Forms
{
    public class ControlPanelForm
    {
        private Button numberBtn(string number) => new Button(SearchCriteria.ByAutomationId($"13{number}"), $"Number {number}");
        private Button plusBtn = new Button(SearchCriteria.ByAutomationId("93"), "Plus");
        private Button resultBtn = new Button(SearchCriteria.ByAutomationId("121"), "Result");
        private Button memoryPlusBtn = new Button(SearchCriteria.ByAutomationId("125"), "MemoryPlus");
        private Button memoryRecallBtn = new Button(SearchCriteria.ByAutomationId("123"), "MemoryRecall");

        public void ClickOnNumber(string number)
        {
            numberBtn(number).Click();
        }

        public void ClickPlusButton()
        {
            plusBtn.Click();
        }

        public void ClickResultButton()
        {
            resultBtn.Click();
        }

        public void ClickMemoryPlusButton()
        {
            memoryPlusBtn.Click();
        }

        public void ClickMemoryRecallButton()
        {
            memoryRecallBtn.Click();
        }
    }
}