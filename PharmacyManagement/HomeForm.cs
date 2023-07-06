using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagement
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        MedicForm medicForm = new MedicForm();
        Employee employee = new Employee();
        Company company = new Company();
        BillingForm billingForm = new BillingForm();
        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {
            
            medicForm.Show();
            this.Hide();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            employee.Show();
            this.Hide();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            company.Show();
            this.Hide();
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            billingForm.Show();
            this.Hide();
        }

        private void guna2ImageButton5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
