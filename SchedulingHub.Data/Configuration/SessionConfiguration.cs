using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using SchedulingHub.Model;

namespace SchedulingHub.Data.Configuration
{
    public class SessionConfiguration : EntityTypeConfiguration<Session>
    {
        public SessionConfiguration()
        {
            ToTable("Session");
            Property(s => s.SessionID).IsRequired();
            Property(s => s.FacilityID).IsRequired();
            Property(s => s.Name).HasMaxLength(255);
            Property(s => s.Description).IsMaxLength();
            Property(s => s.Location).HasMaxLength(255);
            Property(s => s.StartDT).IsRequired();
            Property(s => s.EndDT).IsRequired();
            Property(s => s.Duration).IsRequired();
            Property(s => s.Capacity);
        }
    }
}
