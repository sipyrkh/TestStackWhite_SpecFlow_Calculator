using Calculator.Framework.Application;
using Calculator.Framework.Logger;
using Calculator.Framework.Utils;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;

namespace Calculator.Framework.Element.Base
{
    public abstract class BaseElement
    {
        protected SearchCriteria elementLocator;
        protected string elementName;

        protected BaseElement(SearchCriteria elementLocator, string elementName)
        {
            this.elementLocator = elementLocator;
            this.elementName = elementName;
        }

        protected IUIItem GetElement()
        {
            LoggerUtil.LogInfo($"GetElement: {elementName} - {elementLocator}");
            ApplicationDriver.GetWindow().WaitWhileBusy();
            return ApplicationDriver.GetWindow().Get(elementLocator);
        }
    }
}
