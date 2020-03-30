using System;
using System.Collections.Generic;
using System.Text;
using Solid.DIP.Example1.Solution.Interfaces;

namespace Solid.DIP.Example1.Solution
{
    //properties defined + method for consistence of the class: Ok for SRP
    public class Client
    {
        private readonly IEmailServices _emailServices;

        public Client(IEmailServices emailServices)
        {
            _emailServices = emailServices;
        }

        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }

        //depends on implementation: low coupling
        //no problem with fere SRP: if I change EmailServices, it's transparent for me
        public bool IsValid() => _emailServices.IsValid(Email);
    }
}
