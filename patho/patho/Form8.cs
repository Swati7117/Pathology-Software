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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace patho
{
    public partial class Form8 : Form
    {
        SqlConnection CONN = new SqlConnection();
        public Form8()
        {
            CONN.ConnectionString = "data source=ACER; initial Catalog= PATHOLOGY ;" + "Integrated Security =true";
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand CMD = new SqlCommand();
            CMD.Connection = CONN;
            CMD.CommandText = "select * from Patient_details where Registration_No = " + textBox1.Text + "";
            SqlDataAdapter DA = new SqlDataAdapter();
            DA.SelectCommand = CMD;
            DataSet DS = new DataSet();
            DA.Fill(DS);
            if (DS.Tables[0].Rows.Count > 0)
            {
                textBox2.Text = DS.Tables[0].Rows[0].ItemArray[1].ToString();
                textBox3.Text = DS.Tables[0].Rows[0].ItemArray[2].ToString();
                textBox4.Text = DS.Tables[0].Rows[0].ItemArray[3].ToString();
                textBox5.Text = DS.Tables[0].Rows[0].ItemArray[4].ToString();
            }
            else
            {
                MessageBox.Show("Wrong Input");
            }
        }
    }
}
