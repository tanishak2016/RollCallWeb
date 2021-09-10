using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RollCall.Models
{
    public class DataTableViewModel
    {
        public Int32 RollNumber { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Gender { get; set; }
        public string FaceImage { get; set; }   //VARBINARY
        public string FPTemplate { get; set; } //VARBINARY
        public string FPImage { get; set; } //VARBINARY
        public string FingerID { get; set; }
        public Int32 FPReaderID { get; set; }
        public string IrisTemplate { get; set; } //VARBINARY
        public string IrisImage { get; set; } //VARBINARY
        public string IrisLR { get; set; }
        public Int32 IrisReaderID { get; set; }        
        public Int32 QRCodeValid { get; set; }
        public string QRText { get; set; }
        public Int32 FaceVerified { get; set; }
        public string ExamID { get; set; }
        public string CenterID { get; set; }
        public string Remarks { get; set; }
        public string LastUpdated { get; set; }
        public string ApplicationInfoAppID { get; set; }
        public int Total { get; set; }

        public List<DataTableViewModel> DataTableList { get; set; }
        public DataTableViewModel()
        {
            DataTableList = new List<DataTableViewModel>();
        }
    }
}

