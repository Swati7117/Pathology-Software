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
    public partial class Form1 : Form
    {
        SqlConnection CONN = new SqlConnection();
        public Form1()
        {
            CONN.ConnectionString = "data source=ACER; initial Catalog= PATHOLOGY ;" + "Integrated Security =true";
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Enter user name");
                textBox1.Focus();
                return;

            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Enter password");
                textBox2.Focus();
                return;
            }
            SqlCommand CMD = new SqlCommand();
            CMD.Connection = CONN;
            CMD.CommandText = "select * from login where username='" + textBox1.Text + "'and password='" + textBox2.Text + "'";
            SqlDataAdapter DA = new SqlDataAdapter();
            DA.SelectCommand = CMD;
            DataSet DS = new DataSet();
            DA.Fill(DS);
            if (DS.Tables[0].Rows.Count > 0)
            {
                Class1.UNAME = DS.Tables[0].Rows[0].ItemArray[0].ToString();
                Class1.User_type = DS.Tables[0].Rows[0].ItemArray[2].ToString();
                this.Hide();
                Dashboard form2 = new Dashboard();
                form2.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Invalid username and password");
            return;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            textBox1.Clear();
            textBox2.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

    }

