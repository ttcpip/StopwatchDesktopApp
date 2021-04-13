using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace StopwatchDesktopApp.src
{
    [Serializable]
    public class Config
    {
        public Int64 WorkerWaitInterval = 1000;
        public string AppName = "StopwatchDesktopApp";
        public decimal HourPrice = 1;

        [NonSerialized]
        private string FilePath;
        public void SetFilePath(string newVal)
        {
            FilePath = newVal;
        }

        public void SaveToFile()
        {
            var formatter = new BinaryFormatter();
            using (var fs = new FileStream(FilePath, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, this);
            }
        }
        public static Config LoadFromFile(string path)
        {
            var formatter = new BinaryFormatter();
            Config config = null;

            if (File.Exists(path))
            {
                using (var fs = new FileStream(path, FileMode.OpenOrCreate))
                {
                    config = (Config)formatter.Deserialize(fs);
                    config.SetFilePath(path);
                }
            }
            else
            {
                config = new Config();
                config.SetFilePath(path);
                config.SaveToFile();
            }


            return config;
        }
    }
}
