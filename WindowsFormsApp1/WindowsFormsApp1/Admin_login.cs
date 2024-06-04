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
    public partial class Admin_login :Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Clothstore;Integrated Security=True");

        public Admin_login()
        {
            InitializeComponent();
        }

        private void Admin_login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtunm.Text == "admin" && txtpnm.Text == "admin")
            {
                Deshboard d1 = new Deshboard();
                d1.Show();
                this.Hide();
            }
            else
            {

                string q = "select * from employee where username='" + txtunm.Text + "' and password = '" + txtpnm.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(q, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    customer c1 = new customer();
                    c1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("incorret....");
                }
            }
        }
    }
}
