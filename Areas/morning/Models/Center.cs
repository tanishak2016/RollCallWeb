using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RollCall.Areas.morning.Models
{
    public class Center
    {
        public string centerID { get; set; }

        public string centerBAID { get; set; }

        public string centerName { get; set; }
        public string location { get; set; }
        public string examDate { get; set; }
        public string timeSlot { get; set; }
        public double minRollNumber { get; set; }
        public double maxRollNumber { get; set; }

        public double capacity { get; set; }
    }
}
