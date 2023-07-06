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
    public partial class Form1 : Form
    {
        int startpoint = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            bunifuCircleProgress1.Value = startpoint;
            if(bunifuCircleProgress1.Value==100)
            {
                bunifuCircleProgress1.Value = 0;
                timer1.Stop();
                Login Mylogin= new Login();
                this.Hide();
                Mylogin.Show();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

       
    }
}
