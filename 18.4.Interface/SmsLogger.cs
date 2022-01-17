using System;

namespace _18._4.Interface
{
    public class SmsLogger : ILogger
    {
        public void WriteLog()
        {
            System.Console.WriteLine("Sms olarak log yazar");
        }
    }
}