using Calculator.Framework.Element.Base;
using Calculator.Framework.Logger;
using TestStack.White.UIItems.Finders;
using Calculator.Framework.Utils;


namespace Calculator.Framework.Element
{
    public class Button : BaseElement
    {
        public Button(SearchCriteria elementLocator, string elementName) : base(elementLocator, elementName) {}

        public void Click()
        {
            LoggerUtil.LogInfo($"Click: {elementName} button - {elementLocator}");
            var button = (TestStack.White.UIItems.Button) GetElement();
            button.Click();
        }

        public string GetName()
        {
            return elementName + " button";
        }
    }
}
