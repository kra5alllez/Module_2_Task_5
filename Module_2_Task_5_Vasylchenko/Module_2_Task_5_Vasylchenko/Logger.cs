using System;
using Module_2_Task_5_Vasylchenko.Models;
using Module_2_Task_5_Vasylchenko.Services;

namespace Module_2_Task_5_Vasylchenko
{
    public class Logger
    {
        private static readonly Logger _instance = new Logger();
        private readonly FileService _fileService = new FileService();

        static Logger()
        {
        }

        private Logger()
        {
        }

        public static Logger Instance() => _instance;

        public void LogInfo(string message)
        {
            LogEvent(TypeLog.Info, message);
        }

        public void LogBsnsExceptions(string message)
        {
            LogEvent(TypeLog.Warning, message);
        }

        public void LogExceptions(string message)
        {
            LogEvent(TypeLog.Error, message);
        }

        public void LogEvent(TypeLog typeLog, string message)
        {
            var logMessage = $"{DateTime.UtcNow}: {typeLog}: {message}";
            Console.WriteLine(logMessage);
            _fileService.FileSeve(logMessage);
        }
    }
}
