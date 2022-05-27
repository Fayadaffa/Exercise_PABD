using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PABD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BTNLogin_Click(object sender, EventArgs e)
        {
            if (TBUser.Text == "Admin" && TBPass.Text == "admin12345")
            {
                this.Hide();
                Form2 F2 = new Form2();
                F2.Show();
            }
            else
            {
                MessageBox.Show("Username/Password Salah Ulangi lagi");
            }
        }
    }
}
