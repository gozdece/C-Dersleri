using System;

namespace _18._4.Interface
{
    public class LogManager
    {
        public ILogger _logger;

        public LogManager(ILogger logger)
        {
           _logger = logger;

        }
        public void WriteLog()
        {
            _logger.WriteLog();
        }

    }
}