using Business.Abstract;
using System;

namespace Business.Concrete
{
    public class DBLogger : ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine(String.Format("DBLogger : {0}", message));
        }
    }

    public class FileLogger : ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine(String.Format("FileLogger : {0}", message));
        }
    }
}
