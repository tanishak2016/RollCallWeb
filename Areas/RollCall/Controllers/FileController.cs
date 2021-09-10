using ClosedXML.Excel;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace RollCall.Areas.RollCall.Controllers
{
   [Area("RollCall")]
    public class FileController : Controller
    {
        SqlConnection con = new SqlConnection();
        private IWebHostEnvironment hostingEnv;
        private IConfiguration excelConfiguration;
        dynamic configuration;
        dynamic dynamicDt = null, dynamicSheetName = null, dynamicFilePath;
        public FileController(IWebHostEnvironment _hostingEnv, IConfiguration _excelConfiguration)
        {
            hostingEnv = _hostingEnv;
            excelConfiguration = _excelConfiguration;

            //configuration = GetConfiguration();
            //con = new SqlConnection(configuration.GetSection("Data").GetSection("ConnectionString").Value);
        }
        public IConfigurationRoot GetConfiguration()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            return builder.Build();
        }


        

        [HttpGet]
        public ActionResult ImportExcelFiledynamic()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        //to create table for each of uploaded Excel Sheet Dynamically and Import Data into db.
        public ActionResult ImportExcelFiledynamic([FromForm(Name = "fileUpload")] IFormFile postedFile)
        {
            DataTable dt = null;
            FileStream fstream = null;
            try
            {
                if (postedFile != null)
                {
                    //create a folder
                    var path = Path.Combine(this.hostingEnv.WebRootPath, "Uploads");

                    //create directory "Uploads" if it doesn't exists
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }

                    //get the file name and Save the uploaded Excel file.
                    string fileName = Path.GetFileName(postedFile.FileName);
                    string filePath = Path.Combine(path, fileName);
                    TempData["filePath"] = filePath;

                    if (!System.IO.File.Exists(filePath))
                    {
                        using (fstream = new FileStream(filePath, FileMode.Create))
                        {
                            postedFile.CopyTo(fstream);
                        }
                    }

                    //Read the connection string for the Excel file.
                    //Provide the Database Name 
                    // string DatabaseName = "RollCall";
                    //Provide the SQL Server Name 
                    //string SQLServerName = "SHAGUFTA";// RollCall.mssql.somee.com";

                    //Create Connection to SQL Server Database 
                    SqlConnection SQLConnection = new SqlConnection();
                    //   SQLConnection.ConnectionString = "Data Source = " + SQLServerName + "; Initial Catalog =" + DatabaseName + "; " + "Integrated Security=True;";

                    SQLConnection.ConnectionString = "Data Source=SQL5105.site4now.net;Initial Catalog=db_a79112_mandeep2021;User Id=db_a79112_mandeep2021_admin;Password=Janvi1234#";

                    //Create Excel Connection based on file extension
                    string extension = Path.GetExtension(postedFile.FileName);

                    string ConStr;
                    string HDR;
                    HDR = "YES";
                    ConStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath +
                        ";Extended Properties=\"Excel 12.0;HDR=" + HDR + ";IMEX=1\"";
                    switch (extension)
                    {
                        case ".xls": //Excel 97-03
                            ConStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath + ";Extended Properties=\"Excel 8.0;HDR=" + HDR + ";IMEX=1\"";
                            break;
                        case ".xlsx": //Excel 07
                            ConStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties=\"Excel 12.0;HDR=" + HDR + ";IMEX=1\"";
                            break;
                    }

                    OleDbConnection connExcel = new OleDbConnection(ConStr);

                    //Get the name of First Sheet.
                    connExcel.Open();
                    DataTable dtExcelSheet;
                    dtExcelSheet = connExcel.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

                    string sheetname;
                    sheetname = "";

                    foreach (DataRow drSheet in dtExcelSheet.Rows)
                    {
                        if (drSheet["TABLE_NAME"].ToString().Contains("$"))
                        {
                            sheetname = drSheet["TABLE_NAME"].ToString();
                            TempData["sheetname"] = sheetname;

                            //Load the DataTable with Sheet Data
                            OleDbCommand oconn = new OleDbCommand("select * from [" + sheetname + "]", connExcel);
                            OleDbDataAdapter adp = new OleDbDataAdapter(oconn);
                            dt = new DataTable();
                            TempData["dtNameExcel"] = dt.TableName;
                            adp.Fill(dt);

                            if (dt != null && dt.Rows.Count > 0)
                            {

                                //to remove extra emtpy rows of excel sheet
                                for (int i = dt.Rows.Count - 1; i >= 0; i--)
                                {
                                    if (dt.Rows[i][0].ToString() == string.Empty)
                                    {
                                        dt.Rows.RemoveAt(i);
                                    }
                                }

                                //to remove extra emtpy column of excel sheet
                                for (int i = dt.Columns.Count - 1; i >= 0; i--)
                                {
                                    DataColumn col = dt.Columns[i];
                                    //if (dt.AsEnumerable().All(r => r.IsNull(col) || string.IsNullOrWhiteSpace(r[col].ToString())))
                                    //    dt.Columns.RemoveAt(i);

                                    if (col.ColumnName.StartsWith("F"))
                                        dt.Columns.RemoveAt(i);
                                }

                                //to check photo column and display the pic
                                foreach (DataRow dr in dt.Rows)
                                {
                                    foreach (DataColumn colm in dt.Columns)
                                    {
                                        //check the column name start with photo contain image url
                                        //and pic up the urls to show candidate pic in table
                                        if (colm.ColumnName.ToString().Contains("Url") == true || colm.ColumnName.ToString().Contains("URL") == true || colm.ColumnName.ToString().Contains("url") == true)
                                        {
                                            if (string.IsNullOrEmpty(dr[colm.ColumnName].ToString()) != true)
                                            {
                                                WebClient client = new WebClient();

                                                //Download the image as stream.
                                                byte[] image = client.DownloadData(dr[colm.ColumnName].ToString());

                                                //byte[] imageByteData = System.IO.File.ReadAllBytes(dr[col.ColumnName].ToString());
                                                string imageBase64Data = Convert.ToBase64String(image);
                                                string imageDataURL = string.Format("data:image/png;base64,{0}", imageBase64Data);
                                                dr[colm.ColumnName] = imageDataURL;
                                            }

                                        }
                                    }
                                }
                                ViewBag.dynamicDt = dt;
                                HttpContext.Session.Add<DataTable>("dynamicdt", dt);

                                //remove "$" from sheet name
                                sheetname = sheetname.Replace("$", "");
                                dynamicSheetName = sheetname;

                                // Generate Create Table Script by using Header Column,
                                //It will drop the table if Exists and Recreate                  
                                string tableDDL = "";
                                tableDDL += "IF EXISTS (SELECT * FROM sys.objects WHERE object_id = ";
                                tableDDL += "OBJECT_ID(N'[dbo].[" + fileName + "_" + sheetname + "]') AND type in (N'U'))";
                                tableDDL += "Drop Table [dbo].[" + fileName + "_" + sheetname + "]";
                                tableDDL += "Create table [" + fileName + "_" + sheetname + "]";
                                tableDDL += "(";
                                for (int i = 0; i < dt.Columns.Count; i++)
                                {
                                    if (i != dt.Columns.Count - 1)
                                        tableDDL += "[" + dt.Columns[i].ColumnName + "] " + "NVarchar(max)" + ",";
                                    else
                                        tableDDL += "[" + dt.Columns[i].ColumnName + "] " + "NVarchar(max)";
                                }
                                tableDDL += ")";

                                SQLConnection.Open();
                                SqlCommand SQLCmd = new SqlCommand(tableDDL, SQLConnection);
                                SQLCmd.ExecuteNonQuery();

                                //Load the data from DataTable to SQL Server Table.
                                SqlBulkCopy blk = new SqlBulkCopy(SQLConnection);
                                blk.DestinationTableName = "[" + fileName + "_" + sheetname + "]";
                                TempData["fileName"] = fileName;
                                blk.WriteToServer(dt);
                                SQLConnection.Close();
                            }
                        }
                    }
                    //if the code reach here means everthing goes fine and excel data is imported into database
                    ViewBag.Message = "File Imported and excel data saved into database";
                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
            }
            finally
            {
                if (fstream != null)
                {
                    fstream.Close();
                }
            }

            return View(dt);
        }

        public ActionResult ExportDynamicExcelFile()
        {
            dynamicFilePath = TempData["filePath"];
            dynamicSheetName = TempData["sheetname"];
            string dynamicDtTblName = string.Empty;
            dynamicDtTblName = (string)TempData["dtNameExcel"] == string.Empty ? "Empty" : dynamicDtTblName;

            var dynamicDt = HttpContext.Session.Get<DataTable>("dynamicdt");
            string path = string.Empty;
            try
            {
                string contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                string fileName = "export" + TempData["fileName"];
                if (fileName != null)
                {
                    dynamicDt.TableName = dynamicDtTblName;
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        //Add DataTable in worksheet
                        IXLWorksheet ws = wb.Worksheets.Add(dynamicDt);

                        foreach (DataRow dr in dynamicDt.Rows)
                        {
                            foreach (DataColumn colm in dynamicDt.Columns)
                            {
                                //check the column name start with photo contain image url
                                if (colm.ColumnName.ToString().Contains("Url") == true || colm.ColumnName.ToString().Contains("URL") == true)
                                {
                                    //base64image data contains some header information at the beginning:imageCode = "data:image/png;base64,iVBO remove it
                                    var d = dr[colm.ColumnName].ToString().Substring(22);

                                    //call this function as give below.Convert Base64 String to byte[]
                                    Image image = Base64ToImage(d);

                                    var image1 = ws.AddPicture((Bitmap)image).MoveTo(ws.Cell(dynamicDt.Rows.IndexOf(dr) + 2, dynamicDt.Columns.IndexOf(colm) + 1));
                                    image1.Width = 50;
                                    image1.Height = 50;
                                    //if (dr[colm.ColumnName].ToString().StartsWith("data"))
                                    //{
                                    //    dr[colm.ColumnName] = null;// string.Empty;
                                    //}

                                    //setting excel rows value
                                    ws.Cell(dynamicDt.Rows.IndexOf(dr) + 2, dynamicDt.Columns.IndexOf(colm) + 1).Value = null;

                                    //setting Excel Image column and row height
                                    ws.Columns().AdjustToContents();
                                    var row1 = ws.Row(dynamicDt.Rows.IndexOf(dr) + 2);
                                    //row1.Style.Fill.BackgroundColor = XLColor.Red;
                                    row1.Height = 50;
                                    ////ws.Rows(1,3).AdjustToContents();
                                    //ws.Columns().AdjustToContents();
                                    ////ws.Cell(dynamicDt.Rows.IndexOf(dr), dynamicDt.Columns.IndexOf(colm)).Value=string.Empty;
                                    // ws.Cell(dynamicDt.Rows.IndexOf(dr), dynamicDt.Columns.IndexOf(colm)).SetValue("");
                                    //var image1 = ws.AddPicture(ms).MoveTo(ws.Cell(dynamicDt.Rows.IndexOf(dr) + 2, dynamicDt.Columns.IndexOf(colm) + 1));
                                    //image1.Width = 70;
                                    //image1.Height = 70;




                                    //byte[] bytes = Convert.FromBase64String(d);

                                    //using (MemoryStream ms = new MemoryStream(bytes))
                                    //{
                                    //    //pic.Image = Image.FromStream(ms);
                                    //    var image1 = ws.AddPicture(ms).MoveTo(ws.Cell(dynamicDt.Rows.IndexOf(dr) + 2, dynamicDt.Columns.IndexOf(colm) + 1));
                                    //    image1.Width = 50;
                                    //    image1.Height = 50;
                                    //}
                                }
                            }
                        }

                        using (MemoryStream stream = new MemoryStream())
                        {
                            wb.SaveAs(stream);
                            var content = stream.ToArray();
                            //Return xlsx Excel File
                            return File(content, contentType, fileName);
                        }
                    }
                }
                else
                {
                    ViewBag.Message = "Upload a file to download";
                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
            }

            return ViewBag.exportFile;
        }

        public static Image Base64ToImage(string base64String)
        {
            //Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            //Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }
    }

    public static class SessionCoreExtensions
    {
        public static void Add<T>(this ISession iSession, string key, T data)
        {
            string serializedData = JsonConvert.SerializeObject(data);
            iSession.SetString(key, serializedData);
        }
        public static T Get<T>(this ISession iSession, string key)
        {
            var data = iSession.GetString(key);
            if (null != data)
                return JsonConvert.DeserializeObject<T>(data);
            return default(T);
        }
    }
}
