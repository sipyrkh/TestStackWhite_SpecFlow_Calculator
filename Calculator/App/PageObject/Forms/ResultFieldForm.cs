using TestStack.White.UIItems.Finders;
using Calculator.Framework.Element;


namespace Calculator.App.PageObject.Forms
{
    public class ResultFieldForm
    {
        private Label resultLbl = new Label(SearchCriteria.ByAutomationId("158"), "Result Label");

        public string GetResult()
        {
            return resultLbl.GetText();
        }
    }
}
