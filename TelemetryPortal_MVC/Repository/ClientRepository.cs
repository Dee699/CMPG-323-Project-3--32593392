using TelemetryPortal_MVC.Data;
using TelemetryPortal_MVC.Models;
using System.Linq;
namespace TelemetryPortal_MVC.Repository
{
    //This repository class contains  all data access operations relating to Clients
    public class ClientRepository: GenericRepository<Client>, IClientRepository 
    {
        protected readonly TechtrendsContext _conn;
        public ClientRepository(TechtrendsContext context): base(context) 
        {
            _conn = context;
        }

        // Method to get clients by ID (case-insensitive search)
        public Client GetClientById(Guid id)
        {
            var client = _conn.Clients.FirstOrDefault(client => client.ClientId == id);
            if (client == null)
            {
                throw new InvalidOperationException($"Client with ID {id} not found.");
            }
            return client;
        }


        // Method to get clients by name (case-insensitive search)
        public IEnumerable<Client> GetClientsByName(string name)
        {
            return _conn.Clients
                .Where(client => client.ClientName != null && client.ClientName.Contains(name, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        // Method to get clients by contact email (case-insensitive search)
        public IEnumerable<Client> GetClientsByContactEmail(string email)
        {
            return _conn.Clients
                .Where(client => client.PrimaryContactEmail != null && client.PrimaryContactEmail.Contains(email, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        // Method to get clients by date on boarded
        public IEnumerable<Client> GetClientsByDateOnboarded(DateTime dateOnboarded)
        {
            return _conn.Clients
                .Where(client => client.DateOnboarded == dateOnboarded.Date)
                .ToList();
        }

         // Implemention of the asynchronous GetAllAsync method
          public async Task<IEnumerable<Client>> GetAllAsync()
            {
             return await _context.Clients.ToListAsync(); 
            }
    }
}
