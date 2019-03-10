using SchedulingHub.Data.Configuration;
using SchedulingHub.Model;
using System.Data.Entity;
using System.Linq;

namespace SchedulingHub.Data
{
    public class SchedulingHubEntities : DbContext
    {
        public SchedulingHubEntities() : base("SchedulingHubEntities")
        {

        }

        public DbSet<Facility> Facilities { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Session> Sessions { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

    }
}
