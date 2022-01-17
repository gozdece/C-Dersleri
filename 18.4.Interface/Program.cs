using System;

namespace _18._4.Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            FileLogger file = new FileLogger();
            DatabaseLogger databaseLogger = new DatabaseLogger();
            SmsLogger smsLogger = new SmsLogger();

            file.WriteLog();
            databaseLogger.WriteLog();
            smsLogger.WriteLog();

            LogManager logManager = new LogManager(new FileLogger());
            logManager.WriteLog();
        }
    }
}
