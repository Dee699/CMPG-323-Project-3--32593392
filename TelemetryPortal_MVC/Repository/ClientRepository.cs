using TelemetryPortal_MVC.Data;
using TelemetryPortal_MVC.Models;
using System.Linq;
namespace TelemetryPortal_MVC.Repository
{
    public class ClientRepository: GenericRepository<Client>, IClientRepository 
    {
        public ClientRepository(TechtrendsContext context): base(context) 
        { 
        }
        public Client GetMostRecentClient()
        {
            return _context.Clients.OrderByDescending(clients => clients.CreatedDate).FirstOrDefault();
        }


    }
}
