using Business.Concrete;
using Core.Concrrete;
using System;
using System.Configuration;

namespace ConsoleAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            //string messageSender = ConfigurationManager.AppSettings["message"].ToString();

            Processor processor = new Processor(Logs.CreateLogger(), Logs.CreateMessageSender());
            processor.Process();

            Console.Read();
        }
    }
}
