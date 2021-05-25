using Calculator.Framework.Element.Base;
using Calculator.Framework.Logger;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.MenuItems;

namespace Calculator.Framework.Elements
{
    class MenuBar : BaseElement
    {
        public MenuBar(SearchCriteria elementLocator, string elementName) : base(elementLocator, elementName) {}

        public void SelectItem(string category, string elementName)
        {
            LoggerUtil.LogInfo($"SelectMenuElement: {base.elementName} - {elementLocator}");
            var menuBar = (TestStack.White.UIItems.WindowStripControls.MenuBar) GetElement();
            Menu menuItem = menuBar.MenuItem(category, elementName);
            menuItem.Click();
        }
    }
}
