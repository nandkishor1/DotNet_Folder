using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataAdapter_4th_class.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //InsertData(113, "Suraj", "Kumar", "Finance");

            // UpdateData(113, "Suraj", "Yadav", "Sales");
            #region Tabledata
            DataTable dt = new DataTable();
            dt.Columns.Add("UID", typeof(int));
            dt.Columns.Add("Hoby", typeof(string));

            dt.Rows.Add(2, "Coding");
            dt.Rows.Add(2, "playing");
            dt.Rows.Add(2, "watching");
            dt.Rows.Add(2, "dancing");
            #endregion
            //     InsertHobbies(dt);

            //ReadTwoResultset();


            ExecScaler();

            return View();

            
        }

        public void ExecScaler()
        {
            string str = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            using(SqlConnection con = new SqlConnection(str))
            {
                using(SqlCommand cmd = new SqlCommand("select * from People", con))
                {
                    try
                    {
                        cmd.CommandType = CommandType.Text;
                        con.Open();
                        object v = cmd.ExecuteScalar();
                        if (v!= null)
                        {
                            //string FName = Convert.ToString(v);
                        }
                        con.Close();

                    }
                    catch(Exception ex)
                    {
                        string message = ex.Message;

                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                            con.Close();
                    }
                }
            }
        }
        public void InsertData(int id, string fname, string lname, string dname)
        {
            string str = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;

            using (SqlConnection con = new SqlConnection(str))
            {
                using (SqlCommand cmd = new SqlCommand("prc_InsertData", con))
                {
                    try
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                        cmd.Parameters.Add("@First_Name", SqlDbType.VarChar).Value = fname;
                        cmd.Parameters.Add("@Last_Name", SqlDbType.VarChar).Value = lname;
                        cmd.Parameters.Add("@Department", SqlDbType.VarChar).Value = dname;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        string message = ex.Message;
                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                            con.Close();

                    }



                }
            }


        }


        public void UpdateData(int id, string fname, string lname, string dname)
        {
            string str = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;

            using (SqlConnection con = new SqlConnection(str))
            {
                using (SqlCommand cmd = new SqlCommand("prc_UpdateData", con))
                {
                    try
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        //cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                        //cmd.Parameters.Add("@FName", SqlDbType.VarChar).Value = fname;
                        cmd.Parameters.Add("@LName", SqlDbType.VarChar).Value = lname;
                        cmd.Parameters.Add("@DName", SqlDbType.VarChar).Value = dname;
                        con.Open();
                        int count = cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        string message = ex.Message;
                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                            con.Close();

                    }



                }
            }
        }

        public void InsertHobbies(DataTable dt)
        {
            string str = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;

            using (SqlConnection con = new SqlConnection(str))
            {
                using (SqlCommand cmd = new SqlCommand("prc_InsertHobbies", con))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@TempTable", SqlDbType.Structured).Value = dt;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                    }
                    catch (Exception ex)
                    {
                        string message = ex.Message;

                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                            con.Close();
                    }
                }

            }
        }

        public void ReadTwoResultset()
        {
            string str = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            List<People> lstPeople = new List<People>();
            List<Hobbies> lstHobbies = new List<Hobbies>();
            using (SqlConnection con = new SqlConnection(str))
            {
                using (SqlCommand cmd = new SqlCommand("prc_GetData", con))
                {
                    try
                    {


                        cmd.CommandType = CommandType.StoredProcedure;
                        con.Open();
                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr.HasRows)
                        {
                            while (dr.Read())

                            {
                                People objPeople = new People();

                                objPeople.ID = Convert.ToInt32(dr["ID"]);
                                objPeople.FName = Convert.ToString(dr["FName"]);
                                objPeople.LName = Convert.ToString(dr["LName"]);
                                objPeople.DName = Convert.ToString(dr["DName"]);
                                lstPeople.Add(objPeople);
                            }
                        }
                        else
                        {
                            //No Rows
                        }
                        dr.NextResult();

                        while (dr.Read())
                        {
                            Hobbies objHobbies = new Hobbies();

                            objHobbies.UID = Convert.ToInt32(dr["UID"]);
                            objHobbies.Hoby = Convert.ToString(dr["Hoby"]);
                            lstHobbies.Add(objHobbies);
                        }
                        dr.NextResult();

                        bool b = dr.Read();

                        dr.Close();
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        string msg = ex.Message;
                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                            con.Close();

                    }
                }
            }
        }
    }

    public class People
    {
        public int ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string DName { get; set; }
    }

    public class Hobbies
    {
        public int UID { get; set; }
        public string Hoby { get; set; }
    }
}