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
    public partial class Product : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Clothstore;Integrated Security=True");
        public Product()
        {
            InitializeComponent();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            string q = "select * from category";
            SqlDataAdapter da = new SqlDataAdapter(q, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "categoryname";
                comboBox1.ValueMember = "id";
            }
        }
        private void txtpnm_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string q = "insert into product (productname,cat_id) values ('" + txtpnm.Text + "', '" + comboBox1.SelectedValue+ "')";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Inserted");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Deshboard d1 = new Deshboard();
            d1.Show();
            this.Hide();
        }
    }
}

