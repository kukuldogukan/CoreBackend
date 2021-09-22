using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Logging.Log4Net.Loggers
{
    public class FileLogger : LoggerServiceBase
    {
        private const string Name = "JsonFileLogger";
        public FileLogger() : base(Name)
        {
        }
    }
}