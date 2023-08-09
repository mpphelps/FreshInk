using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshInkUtilities
{
    public static class FileLogger
    {
        private static readonly string _logFilePath;

        static FileLogger()
        {
            _logFilePath = Path.Combine(RegistryManager.GetConfigPath(), "FreshInkLog.txt");
        }

        public static void LogInformation(string message)
        {
            LogMessage($"[INFO] {message}");
        }

        public static void LogError(string message)
        {
            LogMessage($"[ERROR] {message}");
        }

        public static void LogError(string message, Exception ex)
        {
            LogMessage($"[ERROR] {message}\nException: {ex}");
        }

        private static void LogMessage(string message)
        {
            string logEntry = $"{DateTime.Now} - {message}{Environment.NewLine}";
            File.AppendAllText(_logFilePath, logEntry);
        }
    }
}
