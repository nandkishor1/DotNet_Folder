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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=JMS;User ID=sa;Password=sql@123");
        SqlCommand cmd;
        SqlDataReader dr;

        private void Form3_Load(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from emp", con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Data isAvaliable to Read");
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(dr.Read() == true)
            {
                txtId.Text = dr[0].ToString();
                txtName.Text = dr[1].ToString();
                txtAddress.Text = dr[2].ToString();
                txtSalary.Text = dr[3].ToString();

            }
            else
            {
                MessageBox.Show("There is No record to read");
                con.Close();
                txtId.Text = txtName.Text = txtAddress.Text = txtSalary.Text = "";
                btnNext.Enabled = false;
            }
        }
    }
}
