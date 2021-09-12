using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using RollCall.Areas.RollCall.Data;
using RollCall.Areas.RollCall.Models;
using static RollCall.Areas.RollCall.Models.DataTableHelper;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace RollCall.Areas.RollCall.Controllers
{
    [Area("RollCall")]
    public class CandidateController : Controller
    {
        DAL dal = new DAL();

        SqlConnection con = new SqlConnection();

        public CandidateController()
        {
            var configuration = GetConfiguration();
            con = new SqlConnection(configuration.GetSection("Data").GetSection("ConnectionString").Value);
        }

        public IConfigurationRoot GetConfiguration()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            return builder.Build();
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
       public IActionResult cylender()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult cylender(DtParameters param)
        {


            List<pieProperties> pieData = new List<pieProperties>();
            SqlCommand cmd = new SqlCommand("sp_PieDataGet", con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(ds);
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                pieProperties model = new pieProperties();
                model.Name = Convert.ToString(item["Name"]);
                model.Y = Convert.ToInt32(item["Y"]);
                pieData.Add(model);
            }
            return Json(pieData);
        }


        [HttpGet]
        public IActionResult pie()
        {
            return View();
        }
        [HttpPost]
        public ActionResult pie(DtParameters param)
        {
            List<pieProperties> pieData = new List<pieProperties>();
            SqlCommand cmd = new SqlCommand("sp_PieDataGet", con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(ds);
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                pieProperties model = new pieProperties();
                model.Name = Convert.ToString(item["Name"]);
                model.Y = Convert.ToInt32(item["Y"]);
                pieData.Add(model);
            }
            return Json(pieData);

        }
        [HttpGet]
        public IActionResult CandidateDisplay()
        {
            return View();
        }

        [HttpPost]
        public JsonResult CandidateDisplay([FromBody] DtParameters param)
        {
            
            var data = new DataTableViewModel();
            SqlCommand cmd = new SqlCommand("sp_CandidateDisplay", con);
            //SqlCommand cmd = new SqlCommand("spGetEmployees", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SearchVal", param.Search.Value);
            cmd.Parameters.AddWithValue("@Page", param.Start);
            cmd.Parameters.AddWithValue("@OrderBy", param.SortOrder);
            cmd.Parameters.AddWithValue("@PageSize", param.Length);



            //DataTableViewModel model1 = new DataTableViewModel();
            //cmd.Parameters.AddWithValue("@DisplayLength", model1.displaylength);
            //cmd.Parameters.AddWithValue("@DisplayStart", model1.displaystart);
            //cmd.Parameters.AddWithValue("@SortCol", model1.sortcol);
            //cmd.Parameters.AddWithValue("@SortDir", model1.sortdir);
            //cmd.Parameters.AddWithValue("@Search", model1.search);


            cmd.CommandTimeout = 120;
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(ds);
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                DataTableViewModel model = new DataTableViewModel();
                model.rollnumber = Convert.ToDecimal(item["rollnumber"]);
                model.name = item["name"].ToString();
                model.fathername = item["fathername"].ToString();
                model.gender = item["gender"].ToString();




                //model.faceimage = item["faceimage"].ToString();
                String faceimage = item["faceimage"].ToString();
                if (faceimage == null || faceimage == "")
                {
                    model.faceimage = "NA";
                }




                //  model.fptemplate = item["fptemplate"].ToString();
                String fptemplate = item["fptemplate"].ToString();
                if (fptemplate == null || fptemplate == "")
                {
                    model.fptemplate = "NA";
                }



                // model.fpimage = item["fpimage"].ToString();
                string fpimage = item["fpimage"].ToString();
                if (fpimage == null || fpimage=="")
                {
                    model.fpimage = "NA";
                }




                model.fingerid = item["fingerid"].ToString();
                model.fpreaderid = Convert.ToInt32(item["fpreaderid"]);



               // model.iristemplate = item["iristemplate"].ToString();
                String iristemplate= item["iristemplate"].ToString();
                if(iristemplate==null || iristemplate=="")
                {
                    model.iristemplate = "NA";
                }


                //model.irisimage = item["irisimage"].ToString();
                String irisimage= item["irisimage"].ToString();
                if(irisimage==null || irisimage=="")
                {
                    model.irisimage = "NA";
                }



                model.irislr = item["irislr"].ToString();
                model.irisreaderid = Convert.ToInt32(item["irisreaderid"]);
                model.qrcodevalid = Convert.ToInt32(item["qrcodevalid"]);
                model.qrtext = item["qrtext"].ToString();
                model.faceverified = Convert.ToInt32(item["faceverified"]);
                model.examid = item["examid"].ToString();
                model.centerid = item["centerid"].ToString();
                model.remarks = item["remarks"].ToString();
                model.lastupdated = item["lastupdated"].ToString();
                model.applicationinfoappid = item["applicationinfoappid"].ToString();               
                data.DataTableList.Add(model);
            }
            data.Total = Convert.ToInt32(ds.Tables[1].Rows[0].ItemArray[0]);
            var helper = new DtResult<DataTableViewModel>()
            {
                Draw = param.Draw,
                Data = data.DataTableList.ToList(),
                RecordsFiltered = data.Total,
                RecordsTotal = data.Total
            };

            return Json(helper);

        }


    }
}
