using System;

namespace _18._4.Interface
{
    public class FileLogger : ILogger
    {
        public void WriteLog()
        {
            System.Console.WriteLine("dosyaya log yazar");
        }
    }
}