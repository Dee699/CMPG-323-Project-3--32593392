using TelemetryPortal_MVC.Data;
using TelemetryPortal_MVC.Models;
using System.Collections;
using System.Linq;

namespace TelemetryPortal_MVC.Repository
//This repository class contains  all data access operations relating to Projects
{
    public class ProjectRepository : GenericRepository<Project>, IProjectRepository
    {
        protected readonly TechtrendsContext _conn;
        public ProjectRepository(TechtrendsContext context) : base(context)
        {
            _conn = context;
        }

        // If no project is found, return a new Project object or null depending on your use case.
        public Project GetMostRecentProject()
        {
            return _conn.Projects.OrderByDescending(p => p.ProjectCreationDate).FirstOrDefault() ?? new Project();
        }


        // Implemention of a GetProjectByName method
        public Project GetProjectByName(string name)
        {
            var project = _conn.Projects.FirstOrDefault(p => p.ProjectName == name);
            if (project == null)
            {
                throw new InvalidOperationException("Project not found.");
            }
            return project;
        }

        public IEnumerable<Project> GetProjectsByClientId(Guid clientId)
        {
            return _conn.Projects?.Where(p => p.ClientId == clientId).ToList() ?? new List<Project>();
        }


        // Implemention of a GetProjectsByStatus
        public IEnumerable<Project> GetProjectsByStatus(string status)
        {
            return _conn.Projects
                .Where(p => p.ProjectStatus != null && p.ProjectStatus.Equals(status, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        // Implemention of a GetProjectsByDescription
        public IEnumerable<Project> GetProjectsByDescription(string description)
        {
            return _conn.Projects
                .Where(p => p.ProjectDescription != null && p.ProjectDescription.Contains(description, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
  
          // Implemention of the asynchronous GetAllAsync method
          public async Task<IEnumerable<Project>> GetAllAsync()
          {
           return await _context.Projects.ToListAsync(); 
           }

    }
}
