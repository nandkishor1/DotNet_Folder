using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace WebApplication3.Repository
{
    public class ContactRepository
    {
        public bool CreateNewContact(string firstname, string lastname, string country, string subject)
        {
            try
            {
                string connection = "Data Source =.; Initial Catalog = users; User ID = sa; Password = sql@123";
                SqlConnection con = new SqlConnection(connection);

                SqlCommand cmd = new SqlCommand("sp_CreateContact", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                cmd.Parameters.AddWithValue("@FristName", firstname);
                cmd.Parameters.AddWithValue("@LastName", lastname);
                cmd.Parameters.AddWithValue("@Country", country);
                cmd.Parameters.AddWithValue("@Subject", subject);

                int i = cmd.ExecuteNonQuery();
                con.Close();
         
            }
            catch(Exception ex)
            {

            }
            return true;
        }
    }
}