using System;

namespace _18._4.Interface
{
    public class DatabaseLogger : ILogger
    {
        public void WriteLog()
        {
            System.Console.WriteLine("Database e log yazar");
        }
    }
}