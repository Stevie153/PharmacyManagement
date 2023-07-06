using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\hp pc\Documents\Pharmacenter_db.mdf"";Integrated Security=True;Connect Timeout=30");

        private void bunifuTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            /*
                if (Username.Text == "Admin" && Password.Text == "admin")
                { 
                    homeForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wring Username or Password");
                }*/
            Con.Open();
        SqlDataAdapter sda = new SqlDataAdapter("select COUNT(*) from Employee_tbl where Empname='"+Username.Text+"' and EmpPassword = '"+Password.Text+"'",Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString()== "1")
            {
                homeForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }
            Con.Close();
        }
    }
}
