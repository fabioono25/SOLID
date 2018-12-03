using System;
using System.Collections.Generic;
using System.Text;
using Solid.DIP.Example1.Solution.Interfaces;

namespace Solid.DIP.Example1.Solution
{
    //properties defined + method for consistence of the class: Ok for SRP
    public class Client
    {
        private readonly ICPFServices _cpfServices;
        private readonly IEmailServices _emailServices;

        public Client(ICPFServices cpfServices, IEmailServices emailServices)
        {
            _cpfServices = cpfServices;
            _emailServices = emailServices;
        }

        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }

        //depends on implementation: highly coupling
        //fere SRP: um motivo para mudar - se mudo EmailServices, posso quebrar Client
        public bool IsValid() => _emailServices.IsValid(Email) && _cpfServices.IsValid(CPF);
    }
}
