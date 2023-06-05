using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace StopwatchDesktopApp.src
{
    [Serializable]
    public class Config
    {
        [NonSerialized]
        public const string AppName = "StopwatchDesktopApp";
        [NonSerialized]
        private string FilePath = null;

        public void SaveToFile()
        {
            var formatter = new BinaryFormatter();
            using (var fs = new FileStream(FilePath, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, this);
            }
        }
        public static Config LoadOrCreateFile(string filePath)
        {
            var formatter = new BinaryFormatter();

            if (File.Exists(filePath))
            {
                using (var fs = new FileStream(filePath, FileMode.OpenOrCreate))
                {
                    Config config = (Config)formatter.Deserialize(fs);
                    config.FilePath = filePath;
                    return config;
                }
            }
            var newConfig = new Config() { FilePath = filePath };
            newConfig.SaveToFile();

            return newConfig;
        }
    }
}
