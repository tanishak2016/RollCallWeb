using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using RollCall.Areas.RollCall.Models;
using static RollCall.Areas.RollCall.Models.DataTableHelper;

namespace RollCall.Areas.morning.Data
{
    public class DAL
    {
        SqlConnection con = new SqlConnection();

        public DAL()
        {
            var configuration = GetConfiguration();
            con = new SqlConnection(configuration.GetSection("Data").GetSection("ConnectionString").Value);
        }
        public IConfigurationRoot GetConfiguration()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            return builder.Build();
        }


       


    }
}
