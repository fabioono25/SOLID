using System;
using System.Collections.Generic;
using System.Text;

namespace Solid._1_SRP.Example1.Solution
{
    //properties defined + method for consistence of the class: Ok for SRP
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }

        public bool IsValid() => EmailServices.IsValid(Email) && CPFServices.IsValid(CPF);
    }
}
