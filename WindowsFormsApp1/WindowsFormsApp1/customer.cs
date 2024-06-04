using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class customer : Form
    {
        public customer()
        {
            InitializeComponent();
        }

        private void customer_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer_register c1 = new Customer_register();
            c1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sale s1 = new Sale();
            s1.Show();
            this.Hide();

        }
    }
}
