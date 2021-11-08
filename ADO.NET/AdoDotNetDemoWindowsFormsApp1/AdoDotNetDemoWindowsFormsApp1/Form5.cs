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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=JMS;Persist Security Info=True;User ID=sa;Password=sql@123");
            SqlCommand cmd = new SqlCommand("prc2", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p1 = new SqlParameter("@id", SqlDbType.Int);
            p1.Value = Convert.ToInt32(txtId.Text);
            cmd.Parameters.Add(p1);

            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record is Deleted");
            con.Close();
        }
    }
} 
