using TelemetryPortal_MVC.Data;
using TelemetryPortal_MVC.Models;
using System.Collections;
using System.Linq;

namespace TelemetryPortal_MVC.Repository
    
{
    public class ProjectRepository : GenericRepository<Project>, IProjectRepository
    {
        public ProjectRepository(TechtrendsContext context) : base(context)
        {
        }
        public Project GetMostRecentProjects()
        {
          return _context.Projects.OrderByDescending(projects => projects.ProjectCreationDate).FirstOrDefault();
        }


    }
}
