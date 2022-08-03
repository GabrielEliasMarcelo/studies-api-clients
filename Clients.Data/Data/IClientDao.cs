using Clients.Services.Model;
using Clients.Services.Services.Generic;

namespace Clients.Services.Data
{
    public interface IClientDao : ICommand<Client>, IQuery<Client>
    {
    }
}
