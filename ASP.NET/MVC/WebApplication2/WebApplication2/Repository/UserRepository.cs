using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
namespace WebApplication2.Repository
{
    public class UserRepository
    {
       public string RegisterUser(int id,string name,string password)
        {
            try
            {
                string connection = "Data Source=.;Initial Catalog=users;User ID=sa;Password=sql@123";
                SqlConnection con = new SqlConnection(connection);
                con.Open();
                SqlCommand cmd = new SqlCommand("InsertUserInfo", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@password", password);
                int inserted = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception ex)
            {

            }



            return null;
        }
    }
}