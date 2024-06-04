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
    public partial class Employee : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Clothstore;Integrated Security=True");
        string g;
        int id;
        public Employee()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (Female.Checked == true)
            {
                g = "male";
            }
            else
            {
                g = "female";
            }
            con.Open();
            string q = "insert into Employee (empname,gender,dob,email,address,mobilenumber,username,password) values ('" + txtenm.Text + "','" + g + "','" + dateTimePicker1.Text + "','" + txteid.Text + "','" + txtad.Text + "','" + txtmno.Text + "','" + txtunm.Text + "','" + txtpnm.Text + "')";
            SqlCommand cmd = new SqlCommand(q, con);
             cmd.ExecuteNonQuery();
            MessageBox.Show("Record inserted");
            con.Close();
        }
        public void display()
        {
            con.Open();
            string q = "select * from Employee";
            SqlDataAdapter da = new SqlDataAdapter(q, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Deshboard d1 = new Deshboard();
            d1.Show();
            this.Hide();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            display();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                id = Convert.ToInt32(row.Cells[0].Value);
                txtenm.Text = row.Cells[1].Value.ToString();
                string s = row.Cells[2].Value.ToString();
                if(g == "male")
                {
                    Male.Checked = true;
                }
                else
                {
                    Female.Checked = true;
                }
                dateTimePicker1.Text = row.Cells[3].Value.ToString();
                txteid.Text = row.Cells[4].Value.ToString();
                txtad.Text = row.Cells[5].Value.ToString();
                txtmno.Text = row.Cells[6].Value.ToString();
                txtunm.Text = row.Cells[6].Value.ToString();
                txtpnm.Text = row.Cells[7].Value.ToString();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            con.Open();
            string q = "delete from employee where id = "+ id +"";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            txtenm.Text = "";
            Female.Checked = false;
            radioButton2.Checked = false;
            dateTimePicker1.Text = dateTimePicker1.Value.ToString();
            txteid.Text = "";
            txtad.Text = "";
            txtmno.Text = "";
            txtunm.Text = "";
            txtpnm.Text = "";
            MessageBox.Show("Record Deleted Successfuly");
            con.Close();
        }
    }
}
