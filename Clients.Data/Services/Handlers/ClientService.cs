using Clients.Services.Data;
using Clients.Services.Model;

namespace Clients.Services.Services.Handlers
{
    public class ClientService : IClientService
    {
        IClientDao _clientDao;

        public ClientService(IClientDao clientDao)
        {
            _clientDao = clientDao;
        }

        public IEnumerable<Client> GetAllClients()
        {
            return _clientDao.GetAll();
        }

        public void InsertClient(Client client)
        {
            _clientDao.Insert(client);
        }
    }
}
