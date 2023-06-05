using System;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace StopwatchDesktopApp.src
{
    public class StringsManager
    {
        private Language Lang { get; set; }
        private string LangStr { get { return LangToString(); } }
        private ResourceManager ResourceManager { get; set; }
        private Config Config { get; set; }

        public StringsManager(Config config, Language lang = Language.English)
        {
            Config = config;
            Lang = lang;
            if (LangStr == string.Empty)
                throw new ArgumentException("Unsupported language");

            ResourceManager = new ResourceManager($"{Config.AppName}.languages.LanguageStrings", Assembly.GetExecutingAssembly());
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

        public string GetString(string stringIdentifier)
        {
            var str = "{{ string not found }}";
            var gotStr = ResourceManager.GetString(stringIdentifier, new CultureInfo(LangStr));
            if (!string.IsNullOrEmpty(gotStr))
                str = gotStr;
            return str;
        }
    }
}
