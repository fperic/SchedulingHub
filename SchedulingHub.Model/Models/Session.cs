using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingHub.Model
{
    public class Session
    {
        public int SessionID { get; set; }
        public int FacilityID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public DateTime StartDT { get; set; }
        public DateTime EndDT { get; set; }
        public TimeSpan Duration { get; set; }
        public int Capacity { get; set; }

    }
}
