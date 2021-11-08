using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FoodOrderProject.Repository
{
    public class UserRepository
    {
        public string RegisterUser(string name,string pwd,string ID)
        {
            try
            {
             string connection = "Data Source = .; Initial Catalog = User; User ID = sa; Password = sql@123; Integrated Security=true";

                //string connection = "Data Source=.;Initial Catalog=User;User ID=sa;Password=sql@123";
                SqlConnection con = new SqlConnection(connection);
                con.Open();
                SqlCommand cmd = new SqlCommand("InsertUserInfo", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@nmae", name);
                cmd.Parameters.AddWithValue("@password", pwd);
                int inserted = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }

            return null;
        }
    }
}