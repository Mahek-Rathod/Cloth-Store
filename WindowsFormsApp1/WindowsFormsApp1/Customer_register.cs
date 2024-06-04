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

namespace WindowsFormsApp1
{
    public partial class Customer_register : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Clothstore;Integrated Security=True");

        public Customer_register()
        {
            InitializeComponent();
        }

        private void Customer_register_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string q = "insert into Customer_register(customername,mobileno,email) values ('" + txtcnm.Text + "','" + txtmn.Text + "','" + txtei.Text + "')";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("done....");
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            customer c1 = new customer();
            c1.Show();
            this.Hide();
        }
    }
}
