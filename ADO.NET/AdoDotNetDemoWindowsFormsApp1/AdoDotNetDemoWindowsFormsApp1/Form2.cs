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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=JMS;Persist Security Info=True;User ID=sa;Password=sql@123");
        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into emp values(" + txtId.Text + ",'" + txtName.Text + "','" + txtAddress.Text + "'," + txtSalary.Text + ")", con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record is Inserted");
            con.Close();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update emp set name='"+txtName.Text+"',address='"+txtAddress.Text+"',salary="+txtSalary.Text+" where id = "+txtId.Text+"",con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            cmd.ExecuteNonQuery(); 
            MessageBox.Show("Record is Updated");
            con.Close();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from emp where id ="+txtId.Text +"",con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record is Deleted");
            con.Close();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //txtId.Text = "";
            //txtName.Text = "";
            //txtAddress.Text = "";
            //txtSalary.Text = "";

            // for multiple clear box 

            foreach (Control x in this.Controls )
            {
                if(x is TextBox)
                {
                    x.Text = "";
                }

            }
        }
    }
}
