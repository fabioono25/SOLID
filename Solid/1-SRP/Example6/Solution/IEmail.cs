using System;
using System.Collections.Generic;
using System.Text;

namespace Solid._1_SRP.Example6.Solution
{
    interface IEmail
    {
        void setSender(string sender);
        void setReceiver(string receiver);
        void setContent(IContent content);
    }

    //change protocol changes only the Email class
    public interface IContent
    {
        string getAsString(); //use for serialization
    }

    //change content causes changes in Content class
    public class Email : IEmail
    {
        public void setContent(IContent content)
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
