using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RollCall.Areas.morning.Models
{
    public class GetCenterDetailPorperties
    {
        public string centerID { get; set; }
        public string centerBAID { get; set; }
        public string centerName { get; set; }
        public string location { get; set; }
        public string examDate { get; set; }
        public string timeSlot { get; set; }
        public Int64 minRollNumber { get; set; }
        public Int64 maxRollNumber { get; set; }
        public int capacity { get; set; }
        public string examid { get; set; }
    }
}
