using TelemetryPortal_MVC.Data;
using TelemetryPortal_MVC.Models;
using System.Linq;
namespace TelemetryPortal_MVC.Repository
{
    public class ClientRepository: GenericRepository<Client>, IClientRepository 
    {
        protected readonly TechtrendsContext _conn;
        public ClientRepository(TechtrendsContext context): base(context) 
        {
            _conn = context;
        }
        public Client GetMostRecentClient()
        {
            return _context.Clients.OrderByDescending(clients => clients.DateOnboarded).FirstOrDefault();
        }


    }
}
