using Clients.Services.Model;
using Microsoft.EntityFrameworkCore;

namespace Clients.Services.Data.EFCore
{
    public class ClientDao : IClientDao
    {
        ClientsContext _context;

        public ClientDao(ClientsContext context)
        {
            _context = context;
        }

        public void Delete(Client client)
        {
            _context.Clients.Remove(client);
            _context.SaveChanges();

        }

        public IEnumerable<Client> GetAll()
        {
            return _context.Clients.Include(a => a.Country);
        }

        public Client GetById(int id)
        {
            return _context.Clients.Find(id);
        }

        public void Insert(Client client)
        {
            _context.Clients.Add(client);
            _context.SaveChanges();
        }

        public void Update(Client client)
        {
            _context.Clients.Update(client);
            _context.SaveChanges();
        }
    }
}
