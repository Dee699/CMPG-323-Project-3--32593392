using TelemetryPortal_MVC.Data;
using TelemetryPortal_MVC.Models;
using System.Collections;
using System.Linq;

namespace TelemetryPortal_MVC.Repository
    
{
    public class ProjectRepository
    {
        protected readonly TechtrendsContext _context = new TechtrendsContext();

        public IEnumerable<Project> GetAll()
        { 
         return _context.Projects.ToList();
        }
    }
}
