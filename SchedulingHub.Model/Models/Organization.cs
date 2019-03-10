using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingHub.Model
{
    public class Organization
    {
        public int OrganizationID { get; set; }
        public string Name { get; set; }
        public int CreatedUserID { get; set; }
        public DateTime CreatedDateTime { get; set; }

        public virtual List<Facility> Facilities { get; set; }
    }
}
