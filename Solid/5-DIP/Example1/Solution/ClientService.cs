using System;
using System.Collections.Generic;
using System.Text;
using Solid.DIP.Example1.Solution.Interfaces;

namespace Solid.DIP.Example1.Solution
{
    public class ClientService : IClientServices
    {
        private readonly IClientRepository _clientRepository;
        private readonly IEmailServices _emailServices;

        public ClientService(IClientRepository clientRepository, IEmailServices emailServices)
        {
            _clientRepository = clientRepository;
            _emailServices = emailServices;
        }

        public string AddClient(Client client)
        {
            if (!client.IsValid())
                return "Invalid data";

            //Repository coupling
            // var repo = new ClientRepository();
            // repo.AddClient(client);
            _clientRepository.AddClient(client);

            //EmailServices coupling
            //EmailServices.Send("asdas@x.com", client.Email, "Welcome", "Congratulations!!!");
            _emailServices.Send("asdas@x.com", client.Email, "Welcome", "Congratulations!!!");

            return "Client ok";
        }
    }
}
