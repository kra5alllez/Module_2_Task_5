using System.IO;
using Newtonsoft.Json;

namespace Module_2_Task_5_Vasylchenko.Services
{
    public class FileServiceConfig : IFileServiceConfig
    {
        private const string _pathToJsonFile = @"D:\vs project\kra5alllez\Module_2_Task_5\123qwe.json";
        public LoggerConfig Json()
        {
            var fs = File.ReadAllText(_pathToJsonFile);
            var loggerConfig = JsonConvert.DeserializeObject<LoggerConfig>(fs);
            return loggerConfig;
        }
    }
}
