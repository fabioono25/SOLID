using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.DIP.Example1.Violation
{
    //properties defined + method for consistence of the class: Ok for SRP
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        //depends on implementation: highly coupling
        //fere SRP: one motive to change - if I change EmailServices, I can break Client
        public bool IsValid() => EmailServices.IsValid(Email);
    }
}
