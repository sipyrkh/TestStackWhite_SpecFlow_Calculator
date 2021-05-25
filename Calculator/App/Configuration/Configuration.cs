using System.Configuration;
using System.IO;
using System.Text;
using Calculator.Framework.Utils;
using Newtonsoft.Json.Linq;

namespace Calculator.App.Configuration
{
    public static class Configuration
    {
        private static readonly string TestDataPath = ConfigurationManager.AppSettings["PathToTestData"];
        private static readonly JObject JsonValues = JObject.Parse(File.ReadAllText(PathFunctions.GetCombinedPath(TestDataPath), Encoding.Default));
        public static readonly string ExeFile = ConfigurationManager.AppSettings["ExeFile"];
        public static readonly string WindowName = (string) JsonValues["WindowName"];
        public static readonly string ViewOption = (string) JsonValues["View"];
        public static readonly string StandardMode = (string) JsonValues["Standard"];
        public static readonly string ScientificMode = (string) JsonValues["Scientific"];
    }
}
