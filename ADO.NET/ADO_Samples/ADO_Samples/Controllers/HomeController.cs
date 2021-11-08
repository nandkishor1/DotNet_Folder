using ADO_Samples.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ADO_Samples.Controllers
{
    public class HomeController : Controller
    {
        private string prc_GetCUSTOMBER1;
        private DataSet ds;

        public ActionResult Index()
        {

            Students objStudents = new Students();

            string str = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            DataSet ds = new DataSet();

            using (SqlConnection scn = new SqlConnection(str))
            {
                using (SqlCommand cmd = new SqlCommand(prc_GetCUSTOMBER1, scn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;



                    try
                    {
                        // scn.Open();
                        // SqlDataReader = dr cmd.ExecuteReader();

                        SqlDataAdapter da = new SqlDataAdapter();
                        da.Fill(ds);
                    }
                    catch (SqlException ex)
                    {
                        string exMessage = ex.Message;

                    }
                    finally
                    {


                    }
                    return View();
                }
            }
        }


        private ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        private ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}