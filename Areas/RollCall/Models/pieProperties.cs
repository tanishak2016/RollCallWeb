using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RollCall.Areas.RollCall.Models
{
    public class pieProperties
    {
        public int FPReaderIDResult { get; set; }
      //  public int irisTotal { get; set; }
        public int QRCodeValidResult { get; set; }
        public int FaceVerifiedResult { get; set; }
    }
}
