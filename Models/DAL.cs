using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.IO;
using RollCall.Areas.RollCall.Models;
using static RollCall.Areas.RollCall.Models.DataTableHelper;


namespace RollCall.Models
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
        public Int32 adminLoginCheck(adminLoginProperties prop)
        {         
           
                SqlCommand cmd = new SqlCommand("sp_LoginCheck", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@adminUserName", prop.userName);
                cmd.Parameters.AddWithValue("@adminPassword", prop.userPassword);
                cmd.Parameters.AddWithValue("@ret", SqlDbType.Int);
                cmd.Parameters["@ret"].Direction = ParameterDirection.ReturnValue;
                con.Open();
                cmd.ExecuteNonQuery();
                 Int32 k = Convert.ToInt32(cmd.Parameters["@ret"].Value);
                con.Close();
                cmd.Dispose();
                return k;        
            
           

        }        
    }
}
