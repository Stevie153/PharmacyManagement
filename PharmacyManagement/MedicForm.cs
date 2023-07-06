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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PharmacyManagement
{
    public partial class MedicForm : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\hp pc\Documents\Pharmacenter_db.mdf"";Integrated Security=True;Connect Timeout=30");
        public void populate()
        {
            Con.Open();
            string Myquery = "select * from Medicine_tbl";
            SqlDataAdapter dataAdapter= new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder commandBuilder= new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            MedicineGridView.ReadOnly= true;
            MedicineGridView.DataSource= ds.Tables[0];
            Con.Close();
        }
        public MedicForm()
        {
            InitializeComponent();
        }

        public void fillcombobox()
        {
            string sql = "select * from Company_tbl";
            SqlCommand cmd = new SqlCommand(sql, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("Compname", typeof(string));
                dt.Load(rdr = cmd.ExecuteReader());
                companycb.ValueMember = "Compname";
                companycb.DataSource = dt;
                Con.Close();
            }
            catch
            { }
        }
        private void MedicForm_Load(object sender, EventArgs e)
        {
            populate();
            fillcombobox();
        }

      

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            if (Mednametb.Text == "" || sptb.Text == "" || Bptb.Text == "" || companycb.SelectedItem == null)
            {
                MessageBox.Show("Missing Data.Fill All the Information");
            }
            else
            {


                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into Medicine_tbl values('" + Mednametb.Text + "'," + Bptb.Text + "," + sptb.Text + "," + qtytb.Text + ",'" + ExpireDate.Text + "','" + companycb.SelectedItem.ToString() + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Medicine Successfully Added");
                Con.Close();
                populate();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Con.Open() ;
            String Myquery = "UPDATE Medicine_tbl SET Bprice = " + Bptb.Text + ", Sprice = " + sptb.Text + ", MedQty = " + qtytb.Text + ", ExpDate = '" + ExpireDate.Text + "', Company = '" + companycb.SelectedItem.ToString() + "' WHERE MedName = '" + Mednametb.Text + "';";

/*            String Myquery = "UPDATE Medicine_tbl SET Bprice= " + Bptb.Text + ",Sprice=" + sptb.Text + ",MedQty=" + qtytb.Text + ",ExpDate= " + ExpireDate.Text + ",Company='" + companycb.SelectedItem.ToString() + "' + WHERE MedName='"+Mednametb.Text +"';";
*/            SqlCommand cmd = new SqlCommand(Myquery,Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Medicine Updated Successfully");
            Con.Close() ;
            populate();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (Mednametb.Text == "")
            {
                MessageBox.Show("Wrong Operation.Click on the medicine to be Deleted");
            }
            else
            {
                Con.Open();
                string query = "DELETE FROM Medicine_tbl WHERE MedName = '" + Mednametb.Text + "';";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Medicine Deleted Successfully");
                Con.Close();
                populate();
            }
          
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Hide();
        }

        private void MedicineGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Mednametb.Text= MedicineGridView.SelectedRows[0].Cells[0].Value.ToString();
            Bptb.Text= MedicineGridView.SelectedRows[0].Cells[1].Value.ToString();
            sptb.Text= MedicineGridView.SelectedRows[0].Cells[2].Value.ToString();
            qtytb.Text= MedicineGridView.SelectedRows[0].Cells[3].Value.ToString();
        }
    }
}
