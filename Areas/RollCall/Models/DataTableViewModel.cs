
using System;
using System.Collections.Generic;
namespace RollCall.Areas.RollCall.Models
{
    public class DataTableViewModel
    {


        public Decimal rollnumber { get; set; }
        public string name { get; set; }
        public string fathername { get; set; }
        public string gender { get; set; }
        public string faceimage { get; set; }   //VARBINARY
        public string fptemplate { get; set; } //VARBINARY
        public string fpimage { get; set; } //VARBINARY
        public string fingerid { get; set; }
        public Int32 fpreaderid { get; set; }
        public string iristemplate { get; set; } //VARBINARY
        public string irisimage { get; set; } //VARBINARY
        public string irislr { get; set; }
        public Int32 irisreaderid { get; set; }
        public Int32 qrcodevalid { get; set; }
        public string qrtext { get; set; }
        public Int32 faceverified { get; set; }
        public string examid { get; set; }
        public string centerid { get; set; }
        public string remarks { get; set; }
        public string lastupdated { get; set; }
        public string applicationinfoappid { get; set; }

        public int Total { get; set; }
      
        public List<DataTableViewModel> DataTableList { get; set;}
        public DataTableViewModel()
        {
            DataTableList = new List<DataTableViewModel>();
        }
    }

}
