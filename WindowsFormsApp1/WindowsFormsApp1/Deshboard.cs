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
    public partial class Deshboard : Form
    {
        public Deshboard()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            Category c1 = new Category();
            c1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Product p1 = new Product();
            p1.Show();
            this.Hide();
        }
        private void Deshboard_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Employee em1 = new Employee();
            em1.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Display di1 = new Display();
            di1.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Admin_login d1 = new Admin_login();
            d1.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Admin_login a1 = new Admin_login();
            a1.Show();
            this.Hide();
        }
    }
}
