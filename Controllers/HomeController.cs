using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using RollCall.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using static RollCall.Areas.RollCall.Models.DataTableHelper;

namespace RollCall.Controllers
{
    public class HomeController : Controller
    {
        DAL obj = new DAL();
        private readonly ILogger<HomeController> _logger;
        SqlConnection con = new SqlConnection();


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;

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
        public IActionResult Calculate()
        {
            return View();
        }

        

        [HttpGet]
        public IActionResult adminLoginCheck()
        {
            return View();
        }
        [HttpPost]
        public IActionResult adminLoginCheck(adminLoginProperties prop)
        {


            Int32 returnValue = obj.adminLoginCheck(prop);
            if (returnValue == -1)
            {
                TempData["msg"] = "Wrong User Name";
            }
            if (returnValue == -2)
            {
                TempData["msg"] = "Wrong Password";
            }
            if (returnValue == 1)
            {
                String userName = string.Empty;
                userName = prop.userName;
                TempData["userName"] = userName;
                ViewBag.userName = userName;
                return RedirectToAction("CandidateDisplay", "Candidate", new { area = "RollCall" });

            }
            return View();

        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
