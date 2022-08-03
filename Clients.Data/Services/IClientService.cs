using Clients.Services.Model;

namespace Clients.Services.Services
{
    public interface IClientService
    {
        IEnumerable<Client> GetAllClients();

        void InsertClient(Client client);
    }
}
