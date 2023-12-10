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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace patho
{
    public partial class Form3 : Form
    {
        SqlConnection CONN = new SqlConnection();
        public Form3()
        {
            CONN.ConnectionString = "data source=ACER; initial Catalog= PATHOLOGY ;" + "Integrated Security =true";
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string AB;
            AB = "";
            if (radioButton1.Checked == true)
            {
                AB = "MALE";
            }
            else if (radioButton2.Checked == true)
            {
                AB = "FEMALE";
            } 
            else if (radioButton3.Checked == true)
            {
                AB = "OTHERS";
            }
            String CD;
            CD= dateTimePicker1.Value.ToShortDateString();

            CONN.Open();
            SqlCommand CMD = new SqlCommand();
            CMD.Connection = CONN;
            CMD.CommandText = "insert into Patient_details values ('"+ textBox5.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + AB + "','" + comboBox1.Text + "','" + CD + "','"+ comboBox2.Text + "' )";
            CMD.ExecuteNonQuery();
            CONN.Close();
            MessageBox.Show("NEW PATIENT DETAILS ENTERED");

            Class1.reg_no = textBox5.Text;

            this.Hide();
            Form5 form5 = new Form5();
            form5.ShowDialog();
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            SqlCommand cmdmax = new SqlCommand();
            cmdmax.CommandText = "SELECT COUNT(REGISTRATION_NO)+1 FROM Patient_details";
            cmdmax.Connection = CONN;
            SqlDataAdapter dA = new SqlDataAdapter();
            dA.SelectCommand = cmdmax;
            DataSet DS = new DataSet();
            dA.Fill(DS);
            textBox5.Text = DS.Tables[0].Rows[0].ItemArray[0].ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.ShowDialog();
        }
    }
}
