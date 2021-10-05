using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using RollCall.Areas.evening.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using static RollCall.Areas.RollCall.Models.DataTableHelper;
using RollCall.Areas.RollCall.Data;

namespace RollCall.Areas.evening.Controllers
{
    [Area("evening")]
    public class CandidateController : Controller
    {


      //  DAL dal = new DAL();

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
        public IActionResult Dashboard()
        {
            return View();
        }

        [HttpGet]
        public IActionResult DashboardBarChart()
        {
            List<Center> centerData;
            Dictionary<string, double> locationData = new Dictionary<string, double>();
            List<BarProperties> barchartData = new List<BarProperties>();
            using (var httpClient = new HttpClient())
            {
                using (var response = httpClient.GetAsync("http://13.71.52.38/api/CenterDetail"))
                {
                    string apiResponse = response.Result.Content.ReadAsStringAsync().Result;
                    var settings = new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore,
                        MissingMemberHandling = MissingMemberHandling.Ignore
                    };
                    centerData = JsonConvert.DeserializeObject<List<Center>>(apiResponse, settings);
                }
                using (var response = httpClient.GetAsync("http://13.71.52.38/api/CenterDetail/LocationCount"))
                {
                    string apiResponse = response.Result.Content.ReadAsStringAsync().Result;
                    var settings = new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore,
                        MissingMemberHandling = MissingMemberHandling.Ignore
                    };
                    locationData = JsonConvert.DeserializeObject<Dictionary<string, double>>(apiResponse, settings);
                }
            }
            foreach (var location in locationData.Keys)
            {
                BarProperties barProperty = new BarProperties();
                //barProperty.Total = centerData.Where(c => c.location == location).Sum(c => c.capacity);
                //barProperty.Location = location;
                //barProperty.Present = locationData[location];
                //barProperty.Absent = barProperty.Total - barProperty.Present;
                //barchartData.Add(barProperty);
                if (location == "Ambala")
                {
                    //  barProperty.Total = centerData.Where(c => c.location == location).Sum(c => c.capacity);
                    barProperty.Total = 12200;
                    barProperty.Location = location;
                    barProperty.Present = locationData[location];
                    barProperty.Absent = barProperty.Total - barProperty.Present;
                    barchartData.Add(barProperty);
                }
                //else if (location == "FARIDABAD")
                //{
                //    //  barProperty.Total = centerData.Where(c => c.location == location).Sum(c => c.capacity);
                //    barProperty.Total = 0;
                //    barProperty.Location = location;
                //    barProperty.Present = locationData[location];
                //    barProperty.Absent = barProperty.Total - barProperty.Present;
                //    barchartData.Add(barProperty);

                //}
                else if (location == "YAMUNANAGAR")
                {
                    barProperty.Total = 8238;
                    barProperty.Location = location;
                    barProperty.Present = locationData[location];
                    barProperty.Absent = barProperty.Total - barProperty.Present;
                    barchartData.Add(barProperty);

                }
                else if (location == "KARNAL")
                {
                    barProperty.Total = 13150;
                    barProperty.Location = location;
                    barProperty.Present = locationData[location];
                    barProperty.Absent = barProperty.Total - barProperty.Present;
                    barchartData.Add(barProperty);
                }
                else if (location == "Kurukshetra")
                {
                    barProperty.Total = 14000;
                    barProperty.Location = location;
                    barProperty.Present = locationData[location];
                    barProperty.Absent = barProperty.Total - barProperty.Present;
                    barchartData.Add(barProperty);
                }
                else if (location == "PANIPAT")
                {
                    barProperty.Total = 8325;
                    barProperty.Location = location;
                    barProperty.Present = locationData[location];
                    barProperty.Absent = barProperty.Total - barProperty.Present;
                    barchartData.Add(barProperty);
                }
                //else if (location == "PANCHKULA")
                //{
                //    barProperty.Total = 0;
                //    barProperty.Location = location;
                //    barProperty.Present = locationData[location];
                //    barProperty.Absent = barProperty.Total - barProperty.Present;
                //    barchartData.Add(barProperty);
                //}
                //else if (location == "REWARI")
                //{
                //    barProperty.Total = 0;
                //    barProperty.Location = location;
                //    barProperty.Present = locationData[location];
                //    barProperty.Absent = barProperty.Total - barProperty.Present;
                //    barchartData.Add(barProperty);
                //}
                //else if (location == "MAHENDRAGARH")
                //{
                //    barProperty.Total = 0;
                //    barProperty.Location = location;
                //    barProperty.Present = locationData[location];
                //    barProperty.Absent = barProperty.Total - barProperty.Present;
                //    barchartData.Add(barProperty);
                //}
                else
                {

                }
            }
            return Json(barchartData);
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
            SqlCommand cmd = new SqlCommand("sp_BarDataGet", con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(ds);
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                pieProperties model = new pieProperties();
                model.Name = Convert.ToString(item["Name"]);
                model.Y = Convert.ToInt32(item["Y"]);
                model.Total = Convert.ToInt32(item["Total"]);
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
        public ActionResult pie(BarProperties  param,int Present)
        {
            List<pieProperties> pieData = new List<pieProperties>();
            //SqlCommand cmd = new SqlCommand("sp_PieDataGet", con);
            //cmd.CommandType = CommandType.StoredProcedure;
            //DataSet ds = new DataSet();
            //SqlDataAdapter adp = new SqlDataAdapter(cmd);
            //adp.Fill(ds);
            //foreach (DataRow item in ds.Tables[0].Rows)
            //{
            //    pieProperties model = new pieProperties();
            //    model.Name = Convert.ToString(item["Name"]);
            //    model.Y = Convert.ToInt32(item["Y"]);
            //    //  model.Total = Convert.ToInt32(item["Total"]);
            //    pieData.Add(model);
            //}


            int total = 12200;
            int present = Present;
            int absent = total - present;
            pieProperties totalModel = new pieProperties();
            totalModel.Name = "Total";
            totalModel.Y = total;
            pieData.Add(totalModel);
            pieProperties presentModel = new pieProperties();
            presentModel.Name = "Present";
            presentModel.Y = present;
            pieData.Add(presentModel);
            pieProperties absentModel = new pieProperties();
            absentModel.Name = "Absent";
            absentModel.Y = absent;
            pieData.Add(absentModel);


            return Json(pieData);



            //List<Center> centerData;
            //Dictionary<string, double> locationData = new Dictionary<string, double>();
            //List<BarProperties> barchartData = new List<BarProperties>();
            //using (var httpClient = new HttpClient())
            //{
            //    using (var response = httpClient.GetAsync("http://13.71.52.38/api/CenterDetail"))
            //    {
            //        string apiResponse = response.Result.Content.ReadAsStringAsync().Result;
            //        var settings = new JsonSerializerSettings
            //        {
            //            NullValueHandling = NullValueHandling.Ignore,
            //            MissingMemberHandling = MissingMemberHandling.Ignore
            //        };
            //        centerData = JsonConvert.DeserializeObject<List<Center>>(apiResponse, settings);
            //    }
            //    using (var response = httpClient.GetAsync("http://13.71.52.38/api/CenterDetail/LocationCount"))
            //    {
            //        string apiResponse = response.Result.Content.ReadAsStringAsync().Result;
            //        var settings = new JsonSerializerSettings
            //        {
            //            NullValueHandling = NullValueHandling.Ignore,
            //            MissingMemberHandling = MissingMemberHandling.Ignore
            //        };
            //        locationData = JsonConvert.DeserializeObject<Dictionary<string, double>>(apiResponse, settings);
            //    }
            //}

            //foreach (var location in locationData.Keys)
            //{

            //    BarProperties barProperty = new BarProperties();
            //    barProperty.Total = centerData.Where(c => c.location == location).Sum(c => c.capacity);
            //    barProperty.Location = location;
            //   // barProperty.Present = locationData[location];
            //    if (location == "Ambala")
            //    {
            //        barProperty.Present = Present;
            //    }
            //    barProperty.Absent = barProperty.Total - barProperty.Present;
            //    barchartData.Add(barProperty);
            //}
            //return Json(barchartData);

        }


        [HttpGet]
        public IActionResult KARNAL()
        {
            return View();
        }


        [HttpPost]
        public ActionResult KARNAL(BarProperties param, int Present)
        {
            List<pieProperties> pieData = new List<pieProperties>();
            //SqlCommand cmd = new SqlCommand("sp_PieDataGet", con);
            //cmd.CommandType = CommandType.StoredProcedure;
            //DataSet ds = new DataSet();
            //SqlDataAdapter adp = new SqlDataAdapter(cmd);
            //adp.Fill(ds);
            //foreach (DataRow item in ds.Tables[0].Rows)
            //{
            //    pieProperties model = new pieProperties();
            //    model.Name = Convert.ToString(item["Name"]);
            //    model.Y = Convert.ToInt32(item["Y"]);
            //    //  model.Total = Convert.ToInt32(item["Total"]);
            //    pieData.Add(model);
            //}


            int total = 13150;

            int present = Present;
            int absent = total - present;
            pieProperties totalModel = new pieProperties();
            totalModel.Name = "Total";
            totalModel.Y = total;
            pieData.Add(totalModel);
            pieProperties presentModel = new pieProperties();
            presentModel.Name = "Present";
            presentModel.Y = present;
            pieData.Add(presentModel);
            pieProperties absentModel = new pieProperties();
            absentModel.Name = "Absent";
            absentModel.Y = absent;
            pieData.Add(absentModel);


            return Json(pieData);



            //List<Center> centerData;
            //Dictionary<string, double> locationData = new Dictionary<string, double>();
            //List<BarProperties> barchartData = new List<BarProperties>();
            //using (var httpClient = new HttpClient())
            //{
            //    using (var response = httpClient.GetAsync("http://13.71.52.38/api/CenterDetail"))
            //    {
            //        string apiResponse = response.Result.Content.ReadAsStringAsync().Result;
            //        var settings = new JsonSerializerSettings
            //        {
            //            NullValueHandling = NullValueHandling.Ignore,
            //            MissingMemberHandling = MissingMemberHandling.Ignore
            //        };
            //        centerData = JsonConvert.DeserializeObject<List<Center>>(apiResponse, settings);
            //    }
            //    using (var response = httpClient.GetAsync("http://13.71.52.38/api/CenterDetail/LocationCount"))
            //    {
            //        string apiResponse = response.Result.Content.ReadAsStringAsync().Result;
            //        var settings = new JsonSerializerSettings
            //        {
            //            NullValueHandling = NullValueHandling.Ignore,
            //            MissingMemberHandling = MissingMemberHandling.Ignore
            //        };
            //        locationData = JsonConvert.DeserializeObject<Dictionary<string, double>>(apiResponse, settings);
            //    }
            //}

            //foreach (var location in locationData.Keys)
            //{

            //    BarProperties barProperty = new BarProperties();
            //    barProperty.Total = centerData.Where(c => c.location == location).Sum(c => c.capacity);
            //    barProperty.Location = location;
            //   // barProperty.Present = locationData[location];
            //    if (location == "Ambala")
            //    {
            //        barProperty.Present = Present;
            //    }
            //    barProperty.Absent = barProperty.Total - barProperty.Present;
            //    barchartData.Add(barProperty);
            //}
            //return Json(barchartData);

        }



        [HttpGet]
        public IActionResult KURUKSHETRA()
        {
            return View();
        }


        [HttpPost]
        public ActionResult KURUKSHETRA(BarProperties param, int Present)
        {
            List<pieProperties> pieData = new List<pieProperties>();
            //SqlCommand cmd = new SqlCommand("sp_PieDataGet", con);
            //cmd.CommandType = CommandType.StoredProcedure;
            //DataSet ds = new DataSet();
            //SqlDataAdapter adp = new SqlDataAdapter(cmd);
            //adp.Fill(ds);
            //foreach (DataRow item in ds.Tables[0].Rows)
            //{
            //    pieProperties model = new pieProperties();
            //    model.Name = Convert.ToString(item["Name"]);
            //    model.Y = Convert.ToInt32(item["Y"]);
            //    //  model.Total = Convert.ToInt32(item["Total"]);
            //    pieData.Add(model);
            //}


            int total = 14000;
            int present = Present;
            int absent = total - present;
            pieProperties totalModel = new pieProperties();
            totalModel.Name = "Total";
            totalModel.Y = total;
            pieData.Add(totalModel);
            pieProperties presentModel = new pieProperties();
            presentModel.Name = "Present";
            presentModel.Y = present;
            pieData.Add(presentModel);
            pieProperties absentModel = new pieProperties();
            absentModel.Name = "Absent";
            absentModel.Y = absent;
            pieData.Add(absentModel);


            return Json(pieData);



            //List<Center> centerData;
            //Dictionary<string, double> locationData = new Dictionary<string, double>();
            //List<BarProperties> barchartData = new List<BarProperties>();
            //using (var httpClient = new HttpClient())
            //{
            //    using (var response = httpClient.GetAsync("http://13.71.52.38/api/CenterDetail"))
            //    {
            //        string apiResponse = response.Result.Content.ReadAsStringAsync().Result;
            //        var settings = new JsonSerializerSettings
            //        {
            //            NullValueHandling = NullValueHandling.Ignore,
            //            MissingMemberHandling = MissingMemberHandling.Ignore
            //        };
            //        centerData = JsonConvert.DeserializeObject<List<Center>>(apiResponse, settings);
            //    }
            //    using (var response = httpClient.GetAsync("http://13.71.52.38/api/CenterDetail/LocationCount"))
            //    {
            //        string apiResponse = response.Result.Content.ReadAsStringAsync().Result;
            //        var settings = new JsonSerializerSettings
            //        {
            //            NullValueHandling = NullValueHandling.Ignore,
            //            MissingMemberHandling = MissingMemberHandling.Ignore
            //        };
            //        locationData = JsonConvert.DeserializeObject<Dictionary<string, double>>(apiResponse, settings);
            //    }
            //}

            //foreach (var location in locationData.Keys)
            //{

            //    BarProperties barProperty = new BarProperties();
            //    barProperty.Total = centerData.Where(c => c.location == location).Sum(c => c.capacity);
            //    barProperty.Location = location;
            //   // barProperty.Present = locationData[location];
            //    if (location == "Ambala")
            //    {
            //        barProperty.Present = Present;
            //    }
            //    barProperty.Absent = barProperty.Total - barProperty.Present;
            //    barchartData.Add(barProperty);
            //}
            //return Json(barchartData);

        }



        [HttpGet]
        public IActionResult PANCHKULA()
        {
            return View();
        }


        [HttpPost]
        public ActionResult PANCHKULA(BarProperties param, int Present)
        {
            List<pieProperties> pieData = new List<pieProperties>();
            //SqlCommand cmd = new SqlCommand("sp_PieDataGet", con);
            //cmd.CommandType = CommandType.StoredProcedure;
            //DataSet ds = new DataSet();
            //SqlDataAdapter adp = new SqlDataAdapter(cmd);
            //adp.Fill(ds);
            //foreach (DataRow item in ds.Tables[0].Rows)
            //{
            //    pieProperties model = new pieProperties();
            //    model.Name = Convert.ToString(item["Name"]);
            //    model.Y = Convert.ToInt32(item["Y"]);
            //    //  model.Total = Convert.ToInt32(item["Total"]);
            //    pieData.Add(model);
            //}


            int total = 0;
            int present = Present;
            int absent = total - present;
            pieProperties totalModel = new pieProperties();
            totalModel.Name = "Total";
            totalModel.Y = total;
            pieData.Add(totalModel);
            pieProperties presentModel = new pieProperties();
            presentModel.Name = "Present";
            presentModel.Y = present;
            pieData.Add(presentModel);
            pieProperties absentModel = new pieProperties();
            absentModel.Name = "Absent";
            absentModel.Y = absent;
            pieData.Add(absentModel);


            return Json(pieData);



            //List<Center> centerData;
            //Dictionary<string, double> locationData = new Dictionary<string, double>();
            //List<BarProperties> barchartData = new List<BarProperties>();
            //using (var httpClient = new HttpClient())
            //{
            //    using (var response = httpClient.GetAsync("http://13.71.52.38/api/CenterDetail"))
            //    {
            //        string apiResponse = response.Result.Content.ReadAsStringAsync().Result;
            //        var settings = new JsonSerializerSettings
            //        {
            //            NullValueHandling = NullValueHandling.Ignore,
            //            MissingMemberHandling = MissingMemberHandling.Ignore
            //        };
            //        centerData = JsonConvert.DeserializeObject<List<Center>>(apiResponse, settings);
            //    }
            //    using (var response = httpClient.GetAsync("http://13.71.52.38/api/CenterDetail/LocationCount"))
            //    {
            //        string apiResponse = response.Result.Content.ReadAsStringAsync().Result;
            //        var settings = new JsonSerializerSettings
            //        {
            //            NullValueHandling = NullValueHandling.Ignore,
            //            MissingMemberHandling = MissingMemberHandling.Ignore
            //        };
            //        locationData = JsonConvert.DeserializeObject<Dictionary<string, double>>(apiResponse, settings);
            //    }
            //}

            //foreach (var location in locationData.Keys)
            //{

            //    BarProperties barProperty = new BarProperties();
            //    barProperty.Total = centerData.Where(c => c.location == location).Sum(c => c.capacity);
            //    barProperty.Location = location;
            //   // barProperty.Present = locationData[location];
            //    if (location == "Ambala")
            //    {
            //        barProperty.Present = Present;
            //    }
            //    barProperty.Absent = barProperty.Total - barProperty.Present;
            //    barchartData.Add(barProperty);
            //}
            //return Json(barchartData);

        }



        [HttpGet]
        public IActionResult YAMUNANAGAR()
        {
            return View();
        }


        [HttpPost]
        public ActionResult YAMUNANAGAR(BarProperties param, int Present)
        {
            List<pieProperties> pieData = new List<pieProperties>();
            //SqlCommand cmd = new SqlCommand("sp_PieDataGet", con);
            //cmd.CommandType = CommandType.StoredProcedure;
            //DataSet ds = new DataSet();
            //SqlDataAdapter adp = new SqlDataAdapter(cmd);
            //adp.Fill(ds);
            //foreach (DataRow item in ds.Tables[0].Rows)
            //{
            //    pieProperties model = new pieProperties();
            //    model.Name = Convert.ToString(item["Name"]);
            //    model.Y = Convert.ToInt32(item["Y"]);
            //    //  model.Total = Convert.ToInt32(item["Total"]);
            //    pieData.Add(model);
            //}


            int total = 8238;
            int present = Present;
            int absent = total - present;
            pieProperties totalModel = new pieProperties();
            totalModel.Name = "Total";
            totalModel.Y = total;
            pieData.Add(totalModel);
            pieProperties presentModel = new pieProperties();
            presentModel.Name = "Present";
            presentModel.Y = present;
            pieData.Add(presentModel);
            pieProperties absentModel = new pieProperties();
            absentModel.Name = "Absent";
            absentModel.Y = absent;
            pieData.Add(absentModel);


            return Json(pieData);



            //List<Center> centerData;
            //Dictionary<string, double> locationData = new Dictionary<string, double>();
            //List<BarProperties> barchartData = new List<BarProperties>();
            //using (var httpClient = new HttpClient())
            //{
            //    using (var response = httpClient.GetAsync("http://13.71.52.38/api/CenterDetail"))
            //    {
            //        string apiResponse = response.Result.Content.ReadAsStringAsync().Result;
            //        var settings = new JsonSerializerSettings
            //        {
            //            NullValueHandling = NullValueHandling.Ignore,
            //            MissingMemberHandling = MissingMemberHandling.Ignore
            //        };
            //        centerData = JsonConvert.DeserializeObject<List<Center>>(apiResponse, settings);
            //    }
            //    using (var response = httpClient.GetAsync("http://13.71.52.38/api/CenterDetail/LocationCount"))
            //    {
            //        string apiResponse = response.Result.Content.ReadAsStringAsync().Result;
            //        var settings = new JsonSerializerSettings
            //        {
            //            NullValueHandling = NullValueHandling.Ignore,
            //            MissingMemberHandling = MissingMemberHandling.Ignore
            //        };
            //        locationData = JsonConvert.DeserializeObject<Dictionary<string, double>>(apiResponse, settings);
            //    }
            //}

            //foreach (var location in locationData.Keys)
            //{

            //    BarProperties barProperty = new BarProperties();
            //    barProperty.Total = centerData.Where(c => c.location == location).Sum(c => c.capacity);
            //    barProperty.Location = location;
            //   // barProperty.Present = locationData[location];
            //    if (location == "Ambala")
            //    {
            //        barProperty.Present = Present;
            //    }
            //    barProperty.Absent = barProperty.Total - barProperty.Present;
            //    barchartData.Add(barProperty);
            //}
            //return Json(barchartData);

        }


        [HttpGet]
        public IActionResult FARIDABAD()
        {
            return View();
        }

        [HttpPost]
        public ActionResult FARIDABAD(BarProperties param, int Present)
        {
            List<pieProperties> pieData = new List<pieProperties>();
            //SqlCommand cmd = new SqlCommand("sp_PieDataGet", con);
            //cmd.CommandType = CommandType.StoredProcedure;
            //DataSet ds = new DataSet();
            //SqlDataAdapter adp = new SqlDataAdapter(cmd);
            //adp.Fill(ds);
            //foreach (DataRow item in ds.Tables[0].Rows)
            //{
            //    pieProperties model = new pieProperties();
            //    model.Name = Convert.ToString(item["Name"]);
            //    model.Y = Convert.ToInt32(item["Y"]);
            //    //  model.Total = Convert.ToInt32(item["Total"]);
            //    pieData.Add(model);
            //}


            int total = 0;
            int present = Present;
            int absent = total - present;
            pieProperties totalModel = new pieProperties();
            totalModel.Name = "Total";
            totalModel.Y = total;
            pieData.Add(totalModel);
            pieProperties presentModel = new pieProperties();
            presentModel.Name = "Present";
            presentModel.Y = present;
            pieData.Add(presentModel);
            pieProperties absentModel = new pieProperties();
            absentModel.Name = "Absent";
            absentModel.Y = absent;
            pieData.Add(absentModel);


            return Json(pieData);



            //List<Center> centerData;
            //Dictionary<string, double> locationData = new Dictionary<string, double>();
            //List<BarProperties> barchartData = new List<BarProperties>();
            //using (var httpClient = new HttpClient())
            //{
            //    using (var response = httpClient.GetAsync("http://13.71.52.38/api/CenterDetail"))
            //    {
            //        string apiResponse = response.Result.Content.ReadAsStringAsync().Result;
            //        var settings = new JsonSerializerSettings
            //        {
            //            NullValueHandling = NullValueHandling.Ignore,
            //            MissingMemberHandling = MissingMemberHandling.Ignore
            //        };
            //        centerData = JsonConvert.DeserializeObject<List<Center>>(apiResponse, settings);
            //    }
            //    using (var response = httpClient.GetAsync("http://13.71.52.38/api/CenterDetail/LocationCount"))
            //    {
            //        string apiResponse = response.Result.Content.ReadAsStringAsync().Result;
            //        var settings = new JsonSerializerSettings
            //        {
            //            NullValueHandling = NullValueHandling.Ignore,
            //            MissingMemberHandling = MissingMemberHandling.Ignore
            //        };
            //        locationData = JsonConvert.DeserializeObject<Dictionary<string, double>>(apiResponse, settings);
            //    }
            //}

            //foreach (var location in locationData.Keys)
            //{

            //    BarProperties barProperty = new BarProperties();
            //    barProperty.Total = centerData.Where(c => c.location == location).Sum(c => c.capacity);
            //    barProperty.Location = location;
            //   // barProperty.Present = locationData[location];
            //    if (location == "Ambala")
            //    {
            //        barProperty.Present = Present;
            //    }
            //    barProperty.Absent = barProperty.Total - barProperty.Present;
            //    barchartData.Add(barProperty);
            //}
            //return Json(barchartData);

        }

        [HttpGet]
        public IActionResult GURUGRAM()
        {
            return View();
        }


        [HttpPost]
        public ActionResult GURUGRAM(BarProperties param, int Present)
        {
            List<pieProperties> pieData = new List<pieProperties>();
            //SqlCommand cmd = new SqlCommand("sp_PieDataGet", con);
            //cmd.CommandType = CommandType.StoredProcedure;
            //DataSet ds = new DataSet();
            //SqlDataAdapter adp = new SqlDataAdapter(cmd);
            //adp.Fill(ds);
            //foreach (DataRow item in ds.Tables[0].Rows)
            //{
            //    pieProperties model = new pieProperties();
            //    model.Name = Convert.ToString(item["Name"]);
            //    model.Y = Convert.ToInt32(item["Y"]);
            //    //  model.Total = Convert.ToInt32(item["Total"]);
            //    pieData.Add(model);
            //}


            int total = 12200;
            int present = Present;
            int absent = total - present;
            pieProperties totalModel = new pieProperties();
            totalModel.Name = "Total";
            totalModel.Y = total;
            pieData.Add(totalModel);
            pieProperties presentModel = new pieProperties();
            presentModel.Name = "Present";
            presentModel.Y = present;
            pieData.Add(presentModel);
            pieProperties absentModel = new pieProperties();
            absentModel.Name = "Absent";
            absentModel.Y = absent;
            pieData.Add(absentModel);


            return Json(pieData);



            //List<Center> centerData;
            //Dictionary<string, double> locationData = new Dictionary<string, double>();
            //List<BarProperties> barchartData = new List<BarProperties>();
            //using (var httpClient = new HttpClient())
            //{
            //    using (var response = httpClient.GetAsync("http://13.71.52.38/api/CenterDetail"))
            //    {
            //        string apiResponse = response.Result.Content.ReadAsStringAsync().Result;
            //        var settings = new JsonSerializerSettings
            //        {
            //            NullValueHandling = NullValueHandling.Ignore,
            //            MissingMemberHandling = MissingMemberHandling.Ignore
            //        };
            //        centerData = JsonConvert.DeserializeObject<List<Center>>(apiResponse, settings);
            //    }
            //    using (var response = httpClient.GetAsync("http://13.71.52.38/api/CenterDetail/LocationCount"))
            //    {
            //        string apiResponse = response.Result.Content.ReadAsStringAsync().Result;
            //        var settings = new JsonSerializerSettings
            //        {
            //            NullValueHandling = NullValueHandling.Ignore,
            //            MissingMemberHandling = MissingMemberHandling.Ignore
            //        };
            //        locationData = JsonConvert.DeserializeObject<Dictionary<string, double>>(apiResponse, settings);
            //    }
            //}

            //foreach (var location in locationData.Keys)
            //{

            //    BarProperties barProperty = new BarProperties();
            //    barProperty.Total = centerData.Where(c => c.location == location).Sum(c => c.capacity);
            //    barProperty.Location = location;
            //   // barProperty.Present = locationData[location];
            //    if (location == "Ambala")
            //    {
            //        barProperty.Present = Present;
            //    }
            //    barProperty.Absent = barProperty.Total - barProperty.Present;
            //    barchartData.Add(barProperty);
            //}
            //return Json(barchartData);

        }

        [HttpGet]
        public IActionResult MAHENDRAGARH()
        {
            return View();
        }


        [HttpPost]
        public ActionResult MAHENDRAGARH(BarProperties param, int Present)
        {
            List<pieProperties> pieData = new List<pieProperties>();
            //SqlCommand cmd = new SqlCommand("sp_PieDataGet", con);
            //cmd.CommandType = CommandType.StoredProcedure;
            //DataSet ds = new DataSet();
            //SqlDataAdapter adp = new SqlDataAdapter(cmd);
            //adp.Fill(ds);
            //foreach (DataRow item in ds.Tables[0].Rows)
            //{
            //    pieProperties model = new pieProperties();
            //    model.Name = Convert.ToString(item["Name"]);
            //    model.Y = Convert.ToInt32(item["Y"]);
            //    //  model.Total = Convert.ToInt32(item["Total"]);
            //    pieData.Add(model);
            //}


            int total = 0;
            int present = Present;
            int absent = total - present;
            pieProperties totalModel = new pieProperties();
            totalModel.Name = "Total";
            totalModel.Y = total;
            pieData.Add(totalModel);
            pieProperties presentModel = new pieProperties();
            presentModel.Name = "Present";
            presentModel.Y = present;
            pieData.Add(presentModel);
            pieProperties absentModel = new pieProperties();
            absentModel.Name = "Absent";
            absentModel.Y = absent;
            pieData.Add(absentModel);


            return Json(pieData);



            //List<Center> centerData;
            //Dictionary<string, double> locationData = new Dictionary<string, double>();
            //List<BarProperties> barchartData = new List<BarProperties>();
            //using (var httpClient = new HttpClient())
            //{
            //    using (var response = httpClient.GetAsync("http://13.71.52.38/api/CenterDetail"))
            //    {
            //        string apiResponse = response.Result.Content.ReadAsStringAsync().Result;
            //        var settings = new JsonSerializerSettings
            //        {
            //            NullValueHandling = NullValueHandling.Ignore,
            //            MissingMemberHandling = MissingMemberHandling.Ignore
            //        };
            //        centerData = JsonConvert.DeserializeObject<List<Center>>(apiResponse, settings);
            //    }
            //    using (var response = httpClient.GetAsync("http://13.71.52.38/api/CenterDetail/LocationCount"))
            //    {
            //        string apiResponse = response.Result.Content.ReadAsStringAsync().Result;
            //        var settings = new JsonSerializerSettings
            //        {
            //            NullValueHandling = NullValueHandling.Ignore,
            //            MissingMemberHandling = MissingMemberHandling.Ignore
            //        };
            //        locationData = JsonConvert.DeserializeObject<Dictionary<string, double>>(apiResponse, settings);
            //    }
            //}

            //foreach (var location in locationData.Keys)
            //{

            //    BarProperties barProperty = new BarProperties();
            //    barProperty.Total = centerData.Where(c => c.location == location).Sum(c => c.capacity);
            //    barProperty.Location = location;
            //   // barProperty.Present = locationData[location];
            //    if (location == "Ambala")
            //    {
            //        barProperty.Present = Present;
            //    }
            //    barProperty.Absent = barProperty.Total - barProperty.Present;
            //    barchartData.Add(barProperty);
            //}
            //return Json(barchartData);

        }


        [HttpGet]
        public IActionResult PANIPAT()
        {
            return View();
        }


        [HttpPost]
        public ActionResult PANIPAT(BarProperties param, int Present)
        {
            List<pieProperties> pieData = new List<pieProperties>();
            //SqlCommand cmd = new SqlCommand("sp_PieDataGet", con);
            //cmd.CommandType = CommandType.StoredProcedure;
            //DataSet ds = new DataSet();
            //SqlDataAdapter adp = new SqlDataAdapter(cmd);
            //adp.Fill(ds);
            //foreach (DataRow item in ds.Tables[0].Rows)
            //{
            //    pieProperties model = new pieProperties();
            //    model.Name = Convert.ToString(item["Name"]);
            //    model.Y = Convert.ToInt32(item["Y"]);
            //    //  model.Total = Convert.ToInt32(item["Total"]);
            //    pieData.Add(model);
            //}


            int total = 8325;
            int present = Present;
            int absent = total - present;
            pieProperties totalModel = new pieProperties();
            totalModel.Name = "Total";
            totalModel.Y = total;
            pieData.Add(totalModel);
            pieProperties presentModel = new pieProperties();
            presentModel.Name = "Present";
            presentModel.Y = present;
            pieData.Add(presentModel);
            pieProperties absentModel = new pieProperties();
            absentModel.Name = "Absent";
            absentModel.Y = absent;
            pieData.Add(absentModel);


            return Json(pieData);



            //List<Center> centerData;
            //Dictionary<string, double> locationData = new Dictionary<string, double>();
            //List<BarProperties> barchartData = new List<BarProperties>();
            //using (var httpClient = new HttpClient())
            //{
            //    using (var response = httpClient.GetAsync("http://13.71.52.38/api/CenterDetail"))
            //    {
            //        string apiResponse = response.Result.Content.ReadAsStringAsync().Result;
            //        var settings = new JsonSerializerSettings
            //        {
            //            NullValueHandling = NullValueHandling.Ignore,
            //            MissingMemberHandling = MissingMemberHandling.Ignore
            //        };
            //        centerData = JsonConvert.DeserializeObject<List<Center>>(apiResponse, settings);
            //    }
            //    using (var response = httpClient.GetAsync("http://13.71.52.38/api/CenterDetail/LocationCount"))
            //    {
            //        string apiResponse = response.Result.Content.ReadAsStringAsync().Result;
            //        var settings = new JsonSerializerSettings
            //        {
            //            NullValueHandling = NullValueHandling.Ignore,
            //            MissingMemberHandling = MissingMemberHandling.Ignore
            //        };
            //        locationData = JsonConvert.DeserializeObject<Dictionary<string, double>>(apiResponse, settings);
            //    }
            //}

            //foreach (var location in locationData.Keys)
            //{

            //    BarProperties barProperty = new BarProperties();
            //    barProperty.Total = centerData.Where(c => c.location == location).Sum(c => c.capacity);
            //    barProperty.Location = location;
            //   // barProperty.Present = locationData[location];
            //    if (location == "Ambala")
            //    {
            //        barProperty.Present = Present;
            //    }
            //    barProperty.Absent = barProperty.Total - barProperty.Present;
            //    barchartData.Add(barProperty);
            //}
            //return Json(barchartData);

        }


        [HttpGet]
        public IActionResult REWARI()
        {
            return View();
        }



        [HttpPost]
        public ActionResult REWARI(BarProperties param, int Present)
        {
            List<pieProperties> pieData = new List<pieProperties>();
            //SqlCommand cmd = new SqlCommand("sp_PieDataGet", con);
            //cmd.CommandType = CommandType.StoredProcedure;
            //DataSet ds = new DataSet();
            //SqlDataAdapter adp = new SqlDataAdapter(cmd);
            //adp.Fill(ds);
            //foreach (DataRow item in ds.Tables[0].Rows)
            //{
            //    pieProperties model = new pieProperties();
            //    model.Name = Convert.ToString(item["Name"]);
            //    model.Y = Convert.ToInt32(item["Y"]);
            //    //  model.Total = Convert.ToInt32(item["Total"]);
            //    pieData.Add(model);
            //}


            int total = 0;
            int present = Present;
            int absent = total - present;
            pieProperties totalModel = new pieProperties();
            totalModel.Name = "Total";
            totalModel.Y = total;
            pieData.Add(totalModel);
            pieProperties presentModel = new pieProperties();
            presentModel.Name = "Present";
            presentModel.Y = present;
            pieData.Add(presentModel);
            pieProperties absentModel = new pieProperties();
            absentModel.Name = "Absent";
            absentModel.Y = absent;
            pieData.Add(absentModel);


            return Json(pieData);



            //List<Center> centerData;
            //Dictionary<string, double> locationData = new Dictionary<string, double>();
            //List<BarProperties> barchartData = new List<BarProperties>();
            //using (var httpClient = new HttpClient())
            //{
            //    using (var response = httpClient.GetAsync("http://13.71.52.38/api/CenterDetail"))
            //    {
            //        string apiResponse = response.Result.Content.ReadAsStringAsync().Result;
            //        var settings = new JsonSerializerSettings
            //        {
            //            NullValueHandling = NullValueHandling.Ignore,
            //            MissingMemberHandling = MissingMemberHandling.Ignore
            //        };
            //        centerData = JsonConvert.DeserializeObject<List<Center>>(apiResponse, settings);
            //    }
            //    using (var response = httpClient.GetAsync("http://13.71.52.38/api/CenterDetail/LocationCount"))
            //    {
            //        string apiResponse = response.Result.Content.ReadAsStringAsync().Result;
            //        var settings = new JsonSerializerSettings
            //        {
            //            NullValueHandling = NullValueHandling.Ignore,
            //            MissingMemberHandling = MissingMemberHandling.Ignore
            //        };
            //        locationData = JsonConvert.DeserializeObject<Dictionary<string, double>>(apiResponse, settings);
            //    }
            //}

            //foreach (var location in locationData.Keys)
            //{

            //    BarProperties barProperty = new BarProperties();
            //    barProperty.Total = centerData.Where(c => c.location == location).Sum(c => c.capacity);
            //    barProperty.Location = location;
            //   // barProperty.Present = locationData[location];
            //    if (location == "Ambala")
            //    {
            //        barProperty.Present = Present;
            //    }
            //    barProperty.Absent = barProperty.Total - barProperty.Present;
            //    barchartData.Add(barProperty);
            //}
            //return Json(barchartData);

        }



        [HttpGet]
        public IActionResult CandidateDisplay()
        {
            return View();
        }

        [HttpPost]
        public JsonResult CandidateDisplay([FromBody] DtParameters param)
        {
            int count;
            var data = new DataTableViewModel();
            List<DataTableViewModel> data1 = new List<DataTableViewModel>();


            SqlCommand cmd = new SqlCommand("sp_CandidateDisplay", con);
            //SqlCommand cmd = new SqlCommand("spGetEmployees", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SearchVal", param.Search.Value);
            cmd.Parameters.AddWithValue("@Page", param.Start);
            cmd.Parameters.AddWithValue("@OrderBy", param.SortOrder);
            cmd.Parameters.AddWithValue("@PageSize", param.Length);
            cmd.CommandTimeout = 120;
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(ds);
            var recordCount = ds.Tables[0].Rows.Count;
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
                if (fpimage == null || fpimage == "")
                {
                    model.fpimage = "NA";
                }
                model.fingerid = item["fingerid"].ToString();
                model.fpreaderid = Convert.ToInt32(item["fpreaderid"]);
                // model.iristemplate = item["iristemplate"].ToString();
                String iristemplate = item["iristemplate"].ToString();
                if (iristemplate == null || iristemplate == "")
                {
                    model.iristemplate = "NA";
                }
                //model.irisimage = item["irisimage"].ToString();
                String irisimage = item["irisimage"].ToString();
                if (irisimage == null || irisimage == "")
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


            //using (var httpclient = new HttpClient())
            //{
            //    using (var response = await httpclient.GetAsync("http://52.140.82.221/api/CenterDetail"))
            //    {                 

            //        string apiResponse = await response.Content.ReadAsStringAsync();
            //        var settings = new JsonSerializerSettings
            //        {
            //            NullValueHandling = NullValueHandling.Ignore,
            //            MissingMemberHandling = MissingMemberHandling.Ignore
            //        };
            //        data1 = JsonConvert.DeserializeObject<List<DataTableViewModel>>(apiResponse, settings);
            //        count = data1.Count;
            //    }
            //}

            //foreach(var row in data1)
            //{
            //    DataTableViewModel model = new DataTableViewModel();
            //    model.rollnumber = row.rollnumber;
            //    model.name = row.name;
            //    model.fathername = row.fathername;
            //    model.gender = row.gender;            
            //    model.faceimage = row.faceimage;                
            //    model.fptemplate = row.fptemplate;              
            //    model.fpimage = row.fpimage;
            //    model.fingerid = row.fingerid;
            //    model.fpreaderid = row.fpreaderid;              
            //    model.iristemplate = row.iristemplate;
            //    model.irisimage = row.irisimage;//age;
            //    model.irislr = row.irislr;
            //    model.irisreaderid = row.irisreaderid;
            //    model.qrcodevalid = row.qrcodevalid;
            //    model.qrtext = row.qrtext;
            //    model.faceverified = row.faceverified;
            //    model.examid = row.examid;
            //    model.centerid = row.centerid;
            //    model.remarks = row.remarks;
            //    model.lastupdated = row.lastupdated;
            //    model.applicationinfoappid = row.applicationinfoappid;
            //    data.DataTableList.Add(model);

            //}
            //data.Total = count;

            data.Total = Convert.ToInt32(ds.Tables[1].Rows[0].ItemArray[0]);

            var helper = new DtResult<DataTableViewModel>()
            {
                Draw = param.Draw,
                Data = data.DataTableList.ToList(),
                RecordsFiltered = (String.IsNullOrWhiteSpace(param.Search.Value)) ? data.Total : recordCount,
                RecordsTotal = data.Total
            };

            return Json(helper);

        }






    }
}
