using ADO_2nd_Samples.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ADO_2nd_Samples.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //DataAdapterByDepartment();

            DataAdapterByDepartment("IT","Yadav",101);


            return View();
        }
        public void DataAdapter()
        {
            string str = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            DataSet ds = new DataSet();

            using (SqlConnection scn = new SqlConnection(str))
            {
                try
                {


                    SqlDataAdapter da = new SqlDataAdapter("prc_GetPeopleByDepartment", scn);
                    da.Fill(ds);
                }
                catch (SqlException ex)
                {
                    string exMessage = ex.Message;
                }
                finally
                {

                }
            }


        }

        //public void DataAdapterByDepartment()
            public void DataAdapterByDepartment(string depType,string lastName,int id)
        {
            string str = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            DataSet ds = new DataSet();

            using (SqlConnection scn = new SqlConnection(str))
            {

                try
                {


                    SqlDataAdapter da = new SqlDataAdapter("prc_GetPeopleByDepartment", scn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    //da.SelectCommand.Parameters.AddWithValue("@DName", depType);
                    //da.SelectCommand.Parameters.AddWithValue("@lastName", lastName);

                    da.SelectCommand.Parameters.Add("@DName", SqlDbType.VarChar, 500).Value = depType;
                    da.SelectCommand.Parameters.Add("@lastName", SqlDbType.VarChar, 500).Value = lastName;
                    da.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = id;

                    da.Fill(ds);
                }
                catch (SqlException ex)
                {
                    string exMessage = ex.Message;
                }
                finally
                 {

                }
            }

        }
    }

}





