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
    public partial class Dashboard : Form
    {
        SqlConnection CONN = new SqlConnection();

        public Dashboard()
        {
            CONN.ConnectionString = "data source=ACER; initial Catalog= PATHOLOGY ;" + "Integrated Security =true";
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.ShowDialog();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
           
            Form3 form3 = new Form3();
            form3.ShowDialog();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            changepass changepass = new changepass();
            changepass.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (Class1.User_type == "ADMIN")
            {
             
                Form4 form4 = new Form4();
                form4.ShowDialog();
              
            }
            else
            {
                MessageBox.Show("Only Admin can access");
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Class1.User_type == "ADMIN")
            {

                Form7 form7 = new Form7();
                form7.ShowDialog();
            }
            else
            {
                MessageBox.Show("Only Admin can access");
                return;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Form5 form5 = new Form5();
            //form5.ShowDialog();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
