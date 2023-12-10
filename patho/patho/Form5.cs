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
    public partial class Form5 : Form
    {
        int I = 0;
        SqlConnection CONN = new SqlConnection();

        public Form5()
        {
            CONN.ConnectionString = "data source=ACER; initial Catalog= PATHOLOGY ;" + "Integrated Security =true";
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            textBox1.Text = Class1.reg_no;
        }
        
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Add(comboBox2.SelectedItem);
            SqlCommand CMD = new SqlCommand();
            CMD.Connection = CONN;
            CMD.CommandText = "select * from TEST_LIST where TEST_name ='" + comboBox2.Text + "'";
            SqlDataAdapter DA = new SqlDataAdapter();
            DA.SelectCommand = CMD;
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView1.Rows.Add();
            dataGridView1.Rows[I].Cells[0].Value = DS.Tables[0].Rows[0].ItemArray[0].ToString();
            dataGridView1.Rows[I].Cells[1].Value = DS.Tables[0].Rows[0].ItemArray[4 ].ToString();
            dataGridView1.Rows[I].Cells[2].Value = DS.Tables[0].Rows[0].ItemArray[2].ToString();
            I += 1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand CMD = new SqlCommand();
            CMD.Connection = CONN;
            CMD.CommandText = "select test_name from TEST_LIST where TEST_SAMPLE ='" + comboBox1.Text + "'";
            SqlDataAdapter DA = new SqlDataAdapter();
            DA.SelectCommand = CMD;
            DataSet DS = new DataSet();
            DA.Fill(DS);
            comboBox2.Items.Clear();
            for(int i = 0; i < DS.Tables[0].Rows.Count;i++)
            {
                comboBox2.Items.Add(DS.Tables[0].Rows[i].ItemArray[0].ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand CMD = new SqlCommand();
            CMD.Connection = CONN;

            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                CONN.Open();
                string A = dataGridView1.Rows[i].Cells[0].Value.ToString();
                CMD.CommandText = "insert into Report (Reg_No, Test_Name,Unit,Range,Record) values (" + textBox1.Text + ",'" + dataGridView1.Rows[i].Cells[0].Value.ToString() + "','" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "','" + dataGridView1.Rows[i].Cells[2].Value.ToString() + "','" + dataGridView1.Rows[i].Cells[3].Value.ToString() + "' ) ";
                CMD.ExecuteNonQuery();
                CONN.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
