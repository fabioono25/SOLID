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

            //acoplamento com Repository
            // var repo = new ClientRepository();
            // repo.AddClient(client);
            _clientRepository.AddClient(client);

            //acoplamento com EmailServices
            //EmailServices.Send("asdas@x.com", client.Email, "Welcome", "Congratulations!!!");
            _emailServices.Send("asdas@x.com", client.Email, "Welcome", "Congratulations!!!");

            return "Client ok";
        }
    }
}
