using TelemetryPortal_MVC.Models;

namespace TelemetryPortal_MVC.Repository
{
    public interface IClientRepository : IGenericRepository<Client>
    {
        // Calling methods created in the Client Repository
        Client GetClientById(Guid id);
        
        IEnumerable<Client> GetClientsByName(string name);
        
        IEnumerable<Client> GetClientsByContactEmail(string email);
        
        IEnumerable<Client> GetClientsByDateOnboarded(DateTime dateOnboarded);
    
        Task<IEnumerable<Client>> GetAllAsync();
    }
}
