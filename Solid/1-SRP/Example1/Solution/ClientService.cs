using System;
using System.Collections.Generic;
using System.Text;

namespace Solid._1_SRP.Example1.Solution
{
    public class ClientService
    {
        public string AddClient(Client client)
        {
            if (!client.IsValid())
                return "Invalid data";

            var repo = new ClientRepository();
            repo.AddClient(client);

            EmailServices.Send("asdas@x.com", client.Email, "Welcome", "Congratulations!!!");

            return "Client ok";
        }
    }
}
