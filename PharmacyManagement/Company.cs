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

namespace PharmacyManagement
{
    public partial class Company : Form
    {

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\hp pc\Documents\Pharmacenter_db.mdf"";Integrated Security=True;Connect Timeout=30");
        public void populate()
        {
            Con.Open();
            string Myquery = "select * from Company_tbl";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            CompanyDataGridView.ReadOnly = true;
            CompanyDataGridView.DataSource = ds.Tables[0];
            Con.Close();
        }

        public Company()
        {
            InitializeComponent();
        }

        private void AddCompbtn_Click(object sender, EventArgs e)
        {



            if (Compidtb.Text == "" || Compnametb.Text == "" || Compphonetb.Text == "" || CompAddresstb.Text == "" )
            {
                MessageBox.Show("Missing Data.Fill All the Information");
            }
            else
            {


                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into Company_tbl values('" + Compidtb.Text + "','" + Compnametb.Text + "','" + Compphonetb.Text + "','" + CompAddresstb.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Company Successfully Added");
                Con.Close();
               populate();
            }
        }

        private void Company_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void UpdateCompbtn_Click(object sender, EventArgs e)
        {

            Con.Open();
            String Myquery = "UPDATE Company_tbl SET CompId = '" + Compidtb.Text + "', Compname = '" + Compnametb.Text + "', CompPhone = '" + Compphonetb.Text + "', CompAddress = '" + CompAddresstb.Text + "'  WHERE CompId = '" + Compidtb.Text + "';";

          
            SqlCommand cmd = new SqlCommand(Myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Company Updated Successfully");
            Con.Close();
            populate();
        }

        private void CompanyDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Compidtb.Text = CompanyDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            Compnametb.Text = CompanyDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            Compphonetb.Text = CompanyDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            CompAddresstb.Text = CompanyDataGridView.SelectedRows[0].Cells[3].Value.ToString();

        }

        private void DelCompbtn_Click(object sender, EventArgs e)
        {
            if (Compidtb.Text == "")
            {
                MessageBox.Show("Wrong Operation.Click on the Caompany to be Deleted");
            }
            else
            {
                Con.Open();
                string query = "DELETE FROM Company_tbl WHERE CompId = '" + Compidtb.Text + "';";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Company Deleted Successfully");
                Con.Close();
                populate();
            }
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Hide();
        }
    }
}
