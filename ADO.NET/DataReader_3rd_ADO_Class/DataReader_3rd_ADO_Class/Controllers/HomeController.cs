using DataReader_3rd_ADO_Class.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataReader_3rd_ADO_Class.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            Student objStudent = new Student();
            string str = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            List<People> lstPeople = new List<People>();

            try
            {
                using (SqlConnection con = new SqlConnection(str))
                {
                    using (SqlCommand cmd = new SqlCommand("prc_GetPeople", con))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        try
                        {
                            con.Open();
                            SqlDataReader dr = cmd.ExecuteReader();
                            while (dr.Read())
                            {
                                People pl = new People();
                                pl.ID = Convert.ToInt32(dr["ID"]);
                                pl.FName = Convert.ToString(dr["FName"]);
                                pl.LName = Convert.ToString(dr["LName"]);
                                pl.DName = Convert.ToString(dr["DName"]);

                                lstPeople.Add(pl);
                            }
                            dr.Close();
                            int i = 5;

                        }
                        catch (Exception ex)
                        {
                            string msg = ex.Message;
                        }
                        finally
                        {
                            con.Close();
                        }
                    }

                }
            }

            catch (Exception ex)
            {
                string msg = ex.Message;
            }
            return null;
        }
    }


    public class People
    {
        public int ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string DName { get; set; }
    }
}

//        public ActionResult About()
//        {
//            ViewBag.Message = "Your application description page.";

//            return View();
//        }

//        public ActionResult Contact()
//        {
//            ViewBag.Message = "Your contact page.";

//            return View();
//        }
//}
