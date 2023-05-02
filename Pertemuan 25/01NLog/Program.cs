using System;
using NLog;

namespace NLogExample
{
    class Program
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            var config = new NLog.Config.LoggingConfiguration();

            // Target yang akan menulis log ke file
            var fileTarget = new NLog.Targets.FileTarget("fileTarget")
            {
                FileName = "mylog.txt",
                Layout = "${longdate} ${level} ${message} ${exception:format=ToString}"
            };

            // Target yang akan menulis log ke console
            var consoleTarget = new NLog.Targets.ConsoleTarget("consoleTarget")
            {
                Layout = "${longdate} ${level} ${message} ${exception:format=ToString}"
            };

            // Memilih level untuk masing-masing target
            var fileRule = new NLog.Config.LoggingRule("*", LogLevel.Info, fileTarget);
            var consoleRule = new NLog.Config.LoggingRule("*", LogLevel.Trace, consoleTarget);

            // Menambahkan target dan rule ke config
            config.AddTarget(fileTarget);
            config.AddTarget(consoleTarget);
            config.LoggingRules.Add(fileRule);
            config.LoggingRules.Add(consoleRule);

            // Menerapkan konfigurasi
            LogManager.Configuration = config;

            logger.Info("Program started.");

            int x = 5;
            int y = 10;
            int result = x * y;

            logger.Info($"The result of the calculation is: {result}");

            logger.Info("Program finished.");
        }
    }
}
