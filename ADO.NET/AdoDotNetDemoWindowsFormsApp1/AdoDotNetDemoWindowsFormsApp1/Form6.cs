using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AdoDotNetDemoWindowsFormsApp1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=JMS;User ID=sa;Password=sql@123");
        private void btnInsert_Click(object sender, EventArgs e)

        {
            SqlCommand cmd = new SqlCommand("prcinsert", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter p1 = new SqlParameter("@id", SqlDbType.Int);
            p1.Value = Convert.ToInt32(txtId.Text);
            cmd.Parameters.Add(p1);

            SqlParameter p2 = new SqlParameter("@name", SqlDbType.VarChar);
            p2.Value = txtName.Text;
            cmd.Parameters.Add(p2);

            SqlParameter p3 = new SqlParameter("@address", SqlDbType.VarChar);
            p3.Value = txtAddress.Text;
            cmd.Parameters.Add(p3);

            SqlParameter p4 = new SqlParameter("@salary", SqlDbType.Int);
            p4.Value = txtSalary.Text; 
            cmd.Parameters.Add(p4);

            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record is inserted ");
            con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("prcupdate", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter p1 = new SqlParameter("@id", SqlDbType.Int);
            p1.Value = Convert.ToInt32(txtId.Text);
            cmd.Parameters.Add(p1);

            SqlParameter p2 = new SqlParameter("@name", SqlDbType.VarChar);
            p2.Value = txtName.Text;
            cmd.Parameters.Add(p2);

            SqlParameter p3 = new SqlParameter("@address", SqlDbType.VarChar);
            p3.Value = txtAddress.Text;
            cmd.Parameters.Add(p3);

            SqlParameter p4 = new SqlParameter("@salary", SqlDbType.Int);
            p4.Value = txtSalary.Text;
            cmd.Parameters.Add(p4);

            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record is updated ");
            con.Close();
        }
    }
}
