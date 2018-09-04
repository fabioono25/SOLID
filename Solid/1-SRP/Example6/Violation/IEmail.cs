using System;
using System.Collections.Generic;
using System.Text;

namespace Solid._1_SRP.Example6.Violation
{
    interface IEmail
    {
        void setSender(string sender);
        void setReceiver(string receiver);
        void setContent(string content);
    }

    //this class has two reasons to change: one is change of protocol for send and receive
    //another is the change of content type (HTML)
    public class Email : IEmail
    {
        public void setContent(string content)
        {
            Console.WriteLine("set content");
        }

        public void setReceiver(string receiver)
        {
            Console.WriteLine("set receiver");
        }

        public void setSender(string sender)
        {
            Console.WriteLine("set sender");
        }
    }
}
