using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchedulingHub.Model;
using System.Data.Entity.ModelConfiguration;

namespace SchedulingHub.Data.Configuration
{
    public class OrganizationConfiguration : EntityTypeConfiguration<Organization>
    {
        public OrganizationConfiguration()
        {
            ToTable("Organization");
            Property(o => o.OrganizationID).IsRequired();
            Property(o => o.Name).HasMaxLength(255);
            Property(o => o.CreatedUserID).IsRequired();
            Property(o => o.CreatedDateTime).IsRequired(); //.HasDatabaseGeneratedOption() TODO: Add default value (SQL getdate())
        }
    }
}
