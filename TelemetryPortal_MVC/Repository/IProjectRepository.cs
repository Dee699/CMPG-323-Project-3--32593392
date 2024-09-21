
using TelemetryPortal_MVC.Models;


namespace TelemetryPortal_MVC.Repository
{
    public interface IProjectRepository : IGenericRepository<Project>
    {
        // Calling all the methods created on the Project Repository
        Project GetMostRecentProject();

        IEnumerable<Project> GetProjectsByClientId(Guid clientId);

        IEnumerable<Project> GetProjectsByDescription(string description);

        IEnumerable<Project> GetProjectsByStatus(string status);

        Project GetProjectByName(string name);
    }
}
