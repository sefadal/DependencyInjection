using Business.Abstract;
using System;

namespace Business.Concrete
{
    public class MailSender : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine(String.Format("MailSender : {0}", message));
        }
    }

    public class SMSSender : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine(String.Format("SMSSender : {0}", message));
        }
    }
}
