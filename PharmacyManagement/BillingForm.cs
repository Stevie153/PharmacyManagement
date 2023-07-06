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
    public partial class BillingForm : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\hp pc\Documents\Pharmacenter_db.mdf"";Integrated Security=True;Connect Timeout=30");
        public void populatecombobox()
        {
            string sql = "select * from Medicine_tbl";
            SqlCommand cmd =new SqlCommand(sql, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("Medname",typeof(string));
                dt.Load(rdr= cmd.ExecuteReader());
                comboBox1.ValueMember= "Medname";
                comboBox1.DataSource= dt;
                Con.Close();
            }
            catch
            { }
        }
        int x,unitp;
        public void fetchQty()
        {
            Con.Open();
            string mysql = "select * from Medicine_tbl where Medname = '" + comboBox1.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(mysql, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                x = Convert.ToInt32(dr["medQty"].ToString());
                unitp = Convert.ToInt32( dr["Sprice"].ToString());
                Stocklbl.Text = "Available Stock is "+ dr["medQty"].ToString();
                Stocklbl.Visible = true;
            }
            Con.Close() ;
        }

        public void updateMedicine()
        {
            Con.Open();
            int newQty = x - Convert.ToInt32(Qty.Text);
            String Myquery = "UPDATE Medicine_tbl SET MedQty = " + newQty + "  WHERE MedName = '" + comboBox1.SelectedValue.ToString() + "';";

         
            SqlCommand cmd = new SqlCommand(Myquery, Con);
            cmd.ExecuteNonQuery();
           // MessageBox.Show("Medicine Updated Successfully");
            Con.Close();
        }
        public BillingForm()
        {
            InitializeComponent();
        }

        private void BillingForm_Load(object sender, EventArgs e)
        {
            populatecombobox();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchQty();
        }
        int GrdTotal = 0;
        Bitmap bitmap;

        private void printbtn_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics graphics = panel.CreateGraphics();
            Size size = this.ClientSize;
            bitmap = new Bitmap(size.Width, size.Height, graphics);
            graphics = Graphics.FromImage(bitmap);
            Point point = PointToScreen(panel.Location);
            graphics.CopyFromScreen(point.X, point.Y, 0, 0, size);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Hide();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            int n = 0;
            if (Qty.Text == "" || Convert.ToInt32(Qty.Text) > x)
            {
                MessageBox.Show("No Enough Stock Please Check Available Stock ");

            }
            else
            {
                int total= Convert.ToInt32(Qty.Text) * unitp;
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(BillGridView);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = comboBox1.SelectedValue.ToString();
                newRow.Cells[2].Value = Qty.Text;
                newRow.Cells[3].Value = unitp;
                newRow.Cells[4].Value = unitp * Convert.ToInt32(Qty.Text);
                BillGridView.Rows.Add(newRow);
                GrdTotal = GrdTotal + total;
                totalamount.Text = "$" + GrdTotal;
                updateMedicine();
            }
        }
    }
}
