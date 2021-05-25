using Calculator.Framework.Element.Base;
using Calculator.Framework.Logger;
using TestStack.White.UIItems.Finders;
using Calculator.Framework.Utils;


namespace Calculator.Framework.Element
{
    public class Label : BaseElement
    {
        public Label(SearchCriteria elementLocator, string elementName) : base(elementLocator, elementName) {}

        public string GetText()
        {
            LoggerUtil.LogInfo($"GetText: {elementName} - {elementLocator}");
            var label = (TestStack.White.UIItems.Label) GetElement();
            return label.Text;
        }
    }
}
