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

    public partial class Display : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Clothstore;Integrated Security=True");
        int id;
        public Display()
        {
            InitializeComponent();
        }

        private void Display_Load(object sender, EventArgs e)
        {
            string q = "select * from Employee";
            SqlDataAdapter da = new SqlDataAdapter(q, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deshboard d1 = new Deshboard();
            d1.Show();
            this.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Deshboard d1 = new Deshboard();
            d1.Show();
            this.Show();
        }

        
    }
}
