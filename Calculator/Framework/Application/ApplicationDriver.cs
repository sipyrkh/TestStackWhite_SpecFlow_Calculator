using Calculator.App.Configuration;
using TestStack.White.Factory;
using TestStack.White.UIItems.WindowItems;

namespace Calculator.Framework.Application
{
    public static class ApplicationDriver
    {
        public static TestStack.White.Application GetApplication()
        {
            return AppFactory.GetInstance();
        }

        public static Window GetWindow()
        {
            return GetApplication().GetWindow(Configuration.WindowName, InitializeOption.NoCache);
        }

        public static void KillApplication()
        {
            GetApplication().Kill();
        }

        public static bool IsApplicationStart()
        {
            return GetApplication().GetWindows().Count > 0;
        }
    }
}
