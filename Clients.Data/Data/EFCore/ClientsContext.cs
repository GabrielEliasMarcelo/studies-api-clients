using Clients.Services.Model;
using Microsoft.EntityFrameworkCore;

namespace Clients.Services.Data.EFCore
{
    public class ClientsContext : DbContext
    {
        public ClientsContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Country> Countries { get; set; }
    }
}
