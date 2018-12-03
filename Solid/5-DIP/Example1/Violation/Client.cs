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
        public string CPF { get; set; }

        //depends on implementation: highly coupling
        //fere SRP: um motivo para mudar - se mudo EmailServices, posso quebrar Client
        public bool IsValid() => EmailServices.IsValid(Email) && CPFServices.IsValid(CPF);
    }
}
