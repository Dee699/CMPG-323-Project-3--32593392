using TelemetryPortal_MVC.Data;
using TelemetryPortal_MVC.Models;
using System.Collections;
using System.Linq;

namespace TelemetryPortal_MVC.Repository
    
{
    public class ProjectRepository : GenericRepository<Project>, IProjectRepository
    {
        protected readonly TechtrendsContext _conn;
        public ProjectRepository(TechtrendsContext context) : base(context)
        {
            _conn = context;
        }
        public Project GetMostRecentProject()
        {
          return _context.Projects.OrderByDescending(projects => projects.ProjectCreationDate).FirstOrDefault();
        }


    }
}
