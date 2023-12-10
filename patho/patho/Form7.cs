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

namespace patho
{
    public partial class Form7 : Form
    {
        SqlConnection CONN = new SqlConnection();

        public Form7()
        {
            CONN.ConnectionString = "data source=ACER; initial Catalog= PATHOLOGY ;" + "Integrated Security =true";
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Enter user name");
                textBox1.Focus();
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Enter user password");
                textBox2.Focus();
                return;
            }
            string AB;
            AB = "";
            if (radioButton1.Checked == true)
            {
                AB = "Admin";
            }
            else if (radioButton2.Checked == true)
            {
                AB = "Local User";
            }
            CONN.Open();
            SqlCommand CMD = new SqlCommand();
            CMD.Connection = CONN;
            CMD.CommandText = "Delete from login where USERNAME='" + textBox1.Text + "' and PASSWORD='" + textBox2.Text + "' and user_type='" + AB + "'";
             CMD.ExecuteNonQuery();
            CONN.Close();

            MessageBox.Show("User Deleted");
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
