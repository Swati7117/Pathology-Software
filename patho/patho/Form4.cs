using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace patho
{
    public partial class Form4 : Form
    {
        SqlConnection CONN = new SqlConnection();

        public Form4()
        {
            CONN.ConnectionString = "data source=ACER;Initial Catalog=PATHOLOGY;" +
                "Integrated Security=true";

            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Enter User Name");
                    textBox1.Focus();
                    return;
                }
                if (textBox2.Text == "")
                {
                    MessageBox.Show("Enter User Password");
                    textBox2.Focus();
                    return;
                }
                string AB;
                AB = "";
                if (radioButton1.Checked == true)
                {
                    AB = "ADMIN";
                }
                else if (radioButton2.Checked == true)
                {
                    AB = "LOCAL USER";
                }
                CONN.Open();
                SqlCommand CMD = new SqlCommand();
                CMD.Connection = CONN;
                CMD.CommandText = "insert into login values('" +textBox1.Text + "','" + textBox2.Text + "','" + AB + "')";
                CMD.ExecuteNonQuery();
                CONN.Close();
                MessageBox.Show("New user created");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
