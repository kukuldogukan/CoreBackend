using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Logging.Log4Net.Loggers
{
    public class DatabaseLogger : LoggerServiceBase
    {
        private const string Name = "DatabaseLogger";
        public DatabaseLogger() : base(Name)
        {
        }
    }
}
