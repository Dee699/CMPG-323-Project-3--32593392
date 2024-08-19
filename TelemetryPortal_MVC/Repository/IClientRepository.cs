using TelemetryPortal_MVC.Models;

namespace TelemetryPortal_MVC.Repository
{
    public interface IClientRepository : IGenericRepository<Client>
    {
        Client GetMostRecentClient();
    }
}
