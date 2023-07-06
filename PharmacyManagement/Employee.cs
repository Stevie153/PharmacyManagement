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
    public partial class Employee : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\hp pc\Documents\Pharmacenter_db.mdf"";Integrated Security=True;Connect Timeout=30");

        public void populate()
        {
            Con.Open();
            string Myquery = "select * from Employee_tbl";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            //EmployeeDataGridView.ReadOnly = true;
            EmployeeDataGridView.DataSource = ds.Tables[0];
            Con.Close();
        }
        public Employee()
        {
            InitializeComponent();
        }

        private void AddEmpbtn_Click(object sender, EventArgs e)
        {

            if (Empidtb.Text == "" || Empnametb.Text == "" || empsaltb.Text == "" || empphonetb.Text == "" || Emppasstb.Text=="")
            {
                MessageBox.Show("Missing Data.Fill All the Information");
            }
            else
            {


                Con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Employee_tbl (Empid, Empname, Empsalary, Empphone,EmpAge, EmpPassword) VALUES('" + Empidtb.Text + "','" + Empnametb.Text + "'," + empsaltb.Text + ",'" + empphonetb.Text + "','" + empagetb.Text + "','" + Emppasstb.Text + "')", Con);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Successfully Added");
                Con.Close();
                populate();
            }
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void EmployeeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Empidtb.Text = EmployeeDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            Empnametb.Text= EmployeeDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            empsaltb.Text= EmployeeDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            empagetb.Text= EmployeeDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            empphonetb.Text= EmployeeDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            Emppasstb.Text= EmployeeDataGridView.SelectedRows[0].Cells[5].Value.ToString();

        }

        private void UpdateEmpbtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            String Myquery = "UPDATE Employee_tbl SET Empid = '" + Empidtb.Text + "', Empname = '" + Empnametb.Text + "', Empsalary = '" + empsaltb.Text + "', Empphone = '" + empphonetb.Text + "', EmpAge = '" + empagetb.Text + "',EmpPassword = '" + Emppasstb.Text + "' WHERE Empid = '" + Empidtb.Text + "';";

           
            SqlCommand cmd = new SqlCommand(Myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Employee Updated Successfully");
            Con.Close();
            populate();
        }

        private void DelEmpbtn_Click(object sender, EventArgs e)
        {
            if (Empidtb.Text == "")
            {
                MessageBox.Show("Wrong Operation.Click on the Employee to be Deleted");
            }
            else
            {
                Con.Open();
                string query = "DELETE FROM Employee_tbl WHERE Empid = '" + Empidtb.Text + "';";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Deleted Successfully");
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
