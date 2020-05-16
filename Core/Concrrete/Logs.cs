using Business.Abstract;
using Business.Concrete;
using System.Configuration;

namespace Core.Concrrete
{
    public static class Logs
    {
        public static IMessageSender CreateMessageSender()
        {
            IMessageSender retVal;
            string messageSender = "SMS"; //ConfigurationManager.AppSettings["message"].ToString();
            if (messageSender == "SMS")
            {
                retVal = new SMSSender();
            }
            else
            {
                retVal = new MailSender();
            }
            return retVal;
        }

        public static ILogger CreateLogger()
        {
            ILogger retVal;
            string logger = "DB";//ConfigurationManager.AppSettings["logger"].ToString();
            if (logger == "DB")
            {
                retVal = new DBLogger();
            }
            else
            {
                retVal = new FileLogger();
            }
            return retVal;
        }
    }
}
