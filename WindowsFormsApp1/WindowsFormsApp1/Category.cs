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
    public partial class Category : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Clothstore;Integrated Security=True");

        public Category()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string q = "insert into category (categoryname) values('" + txtcatnm.Text + "')";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            display();
            MessageBox.Show("Record inserted");
            con.Close();
        }

        private void Category_Load(object sender, EventArgs e)
        {
            display();

        }
        public void display()
        { 
            string q1 = "select *from category";
            SqlDataAdapter da = new SqlDataAdapter(q1,con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Deshboard d1 = new Deshboard();
            d1.Show();
            this.Hide();
        }
    }
}
