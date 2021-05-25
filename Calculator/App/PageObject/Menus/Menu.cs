using TestStack.White.UIItems.Finders;
using Calculator.Framework.Element;
using Calculator.Framework.Elements;

namespace Calculator.App.PageObject.Menu
{
    class Menu
    {
        private MenuBar menuBar => new MenuBar(SearchCriteria.ByAutomationId("MenuBar"), "menuBar MainMenu");
        public void SelectMenuCategory(string menuCategory, string menuSubCategory)
        {
            menuBar.SelectItem(menuCategory, menuSubCategory);
        }
    }
}
