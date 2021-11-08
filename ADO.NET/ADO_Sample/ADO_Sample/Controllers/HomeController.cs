using ADO_Sample.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ADO_Sample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Student objStudent = new Student();

            string str = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
             DataSet ds = new DataSet();

            using (SqlConnection scn = new SqlConnection(str))
            {
                using (SqlCommand cmd = new SqlCommand("prc_GetPeople", scn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    try
                    {
                        //scn.Open();
                        //SqlDataReader dr = new SqlDataReader();

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(ds);
                    }
                    catch(SqlException ex)
                    {
                        string exMessage = ex.Message;
                    }
                    finally
                    {

                    }
                }

            }

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}