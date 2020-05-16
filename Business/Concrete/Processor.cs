using Business.Abstract;

namespace Business.Concrete
{
    public class Processor
    {
        ILogger logger = null;
        IMessageSender messageSender;
        public Processor(ILogger _logger, IMessageSender _messageSender)
        {
            logger = _logger;
            messageSender = _messageSender;
        }

        public void Process()
        {
            logger.WriteLog("Log Text");

            messageSender.SendMessage("Message Text");
        }
    }
}
