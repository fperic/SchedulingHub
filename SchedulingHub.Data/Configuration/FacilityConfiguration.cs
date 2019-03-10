using System.Data.Entity.ModelConfiguration;
using SchedulingHub.Model;

namespace SchedulingHub.Data.Configuration
{
    public class FacilityConfiguration : EntityTypeConfiguration<Facility>
    {
        public FacilityConfiguration()
        {
            ToTable("Facility");
            Property(f => f.FacilityID).IsRequired();
            Property(f => f.OrganizationID).IsRequired();
        }
    }
}
