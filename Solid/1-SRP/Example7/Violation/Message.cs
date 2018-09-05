using System;
using System.Collections.Generic;
using System.Text;

namespace Solid._1_SRP.Example7.Violation
{
    public interface IMessage
    {
        IList<string> ToAddresses { get; set; }
        string MessageBody { get; set; }
        bool Send();
    }

    public interface IMailMessage: IMessage
    {
        string Subject { get; set; }
        IList<string> BccAddresses { get; set; }
    }

    public class SmtpMessage : IMailMessage
    {
        public IList<string> ToAddresses { get; set; }
        public IList<string> BccAddresses { get; set; }
        public string Subject { get; set; }
        public string MessageBody { get; set; }

        public bool Send()
        {
            //do real work here
            throw new NotImplementedException();
        }
    }

    public class SmsMessage : IMessage
    {
        public IList<string> ToAddresses { get; set; }
        public string MessageBody { get; set; }

        public bool Send()
        {
            throw new NotImplementedException();
        }
    }
}
