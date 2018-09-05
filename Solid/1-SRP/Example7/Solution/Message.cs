using System;
using System.Collections.Generic;
using System.Text;

namespace Solid._1_SRP.Example7.Solution
{
    public interface IMessageServer
    {
        bool Send(IMessage message);
    }

    public interface IMessage
    {
        IList<string> ToAddresses { get; set; }
        string MessageBody { get; set; }
    }

    public class SmtpMessage : IMessage
    {
        public IList<string> ToAddresses { get; set; }
        public string MessageBody { get; set; }

        public bool Send()
        {
            throw new NotImplementedException();
        }
    }

    public class SmsMessage : IMessage
    {
        public IList<String> ToAddresses { get; set; }
        public string MessageBody { get; set; }
    }
    public class SmsMessageServer : IMessageServer
    {
        public bool Send(IMessage message)
        {
            //Do the real work here
            return true;
        }
    }

    public class SmtpMessageServer : IMessageServer
    {
        public bool Send(IMessage message)
        {
            //Do the real work here
            return true;
        }
    }
}
