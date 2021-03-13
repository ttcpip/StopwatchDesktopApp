using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace StopwatchDesktopApp.src
{
    public class StringsManager
    {
        private Language Lang { get; set; }
        private string LangStr { get { return LangToString(); } }
        private ResourceManager ResourceManager { get; set; }

        public StringsManager(Language lang = Language.English)
        {
            Lang = lang;
            if (LangStr == string.Empty)
                throw new ArgumentException("Unsupported language");

            ResourceManager = new ResourceManager($"{Constants.APP_NAME}.languages.LanguageStrings", Assembly.GetExecutingAssembly());
        }

        public static string LangToString(Language lang)
        {
            var result = string.Empty;

            switch (lang)
            {
                case Language.English:
                    result = "en-US";
                    break;
                case Language.Russian:
                    result = "ru-RU";
                    break;
                default:
                    break;
            }

            return result;
        }
        private string LangToString()
        {
            return LangToString(Lang);
        }
        public static Language StringToLang(string str)
        {
            var result = Language.Undefined;

            switch (str)
            {
                case "en-US":
                    result = Language.English;
                    break;
                case "ru-RU":
                    result = Language.Russian;
                    break;
                default:
                    break;
            }

            return result;
        }

        public string GetString(string stringIdentifier)
        {
            var str = "{{ string not found }}";
            var gotStr = ResourceManager.GetString(stringIdentifier, new CultureInfo(LangStr));
            if (!string.IsNullOrEmpty(gotStr))
                str = gotStr;
            return str;
        }

        public void SetLang(Language newLang)
        {
            Lang = newLang;
        }
    }
}
