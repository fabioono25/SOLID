using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.DIP.Example1.Violation
{
    public class ClientService
    {
        public string AddClient(Client client)
        {
            if (!client.IsValid())
                return "Invalid data";

            //acoplamento com Repository
            var repo = new ClientRepository();
            repo.AddClient(client);

            //acoplamento com EmailServices
            EmailServices.Send("asdas@x.com", client.Email, "Welcome", "Congratulations!!!");

            return "Client ok";
        }
    }
}
