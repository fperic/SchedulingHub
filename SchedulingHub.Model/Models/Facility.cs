using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingHub.Model
{
    public class Facility
    {
        public int FacilityID { get; set; }
        public string Name { get; set; }

        public int OrganizationID { get; set; }
        public virtual Organization Organization { get; set; }

    }
}
