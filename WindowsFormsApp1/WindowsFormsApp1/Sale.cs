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
    

    public partial class Sale : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Clothstore;Integrated Security=True");

        public Sale()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string q = "insert into Sale (cust_id,cat_id,prod_id,emp_id,price,quantity) values ('" + comboBox1.SelectedValue + "', '" + comboBox2.SelectedValue + "','" + comboBox3.SelectedValue + "','" + comboBox4.SelectedValue + "','" + txtpri.Text + "','" + txtqua.Text + "')";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Inserted");
        }
        void Customer()
        {
            string q = "select * from Customer_register";
            SqlDataAdapter da = new SqlDataAdapter(q, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "customername";
                comboBox1.ValueMember = "id";
            }
        }
        void Category()
        {
            string q = "select * from category";
            SqlDataAdapter da = new SqlDataAdapter(q, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                comboBox2.DataSource = dt;
                comboBox2.DisplayMember = "categoryname";
                comboBox2.ValueMember = "id";
            }
        }
        void Product()
        {
            string q = "select * from product";
            SqlDataAdapter da = new SqlDataAdapter(q, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                comboBox3.DataSource = dt;
                comboBox3.DisplayMember = "productname";
                comboBox3.ValueMember = "id";
            }
        }
        void Employee()
        {
            string q = "select * from Employee";
            SqlDataAdapter da = new SqlDataAdapter(q, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                comboBox4.DataSource = dt;
                comboBox4.DisplayMember = "empname";
                comboBox4.ValueMember = "id";
            }
        }

        private void Sale_Load(object sender, EventArgs e)
        {
            Customer();
            Category();
            Product();
            Employee();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            customer c1 = new customer();
            c1.Show();
            this.Hide();
        }
    }

}
  