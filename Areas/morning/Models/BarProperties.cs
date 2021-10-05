using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RollCall.Areas.morning.Models
{
    public class BarProperties
    {
        public string Location { get; set; }

        public double Total { get; set; }

        public double Present { get; set; }

        public double Absent { get; set; }

       
    }
}
