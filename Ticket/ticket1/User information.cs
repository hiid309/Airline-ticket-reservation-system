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

namespace ticket1
{
    public partial class User_information : Form
    {
        public User_information()
        {
            InitializeComponent();
        }
        string str = @"Data Source=DESKTOP-8DE8O09\SQLEXPRESS;Initial Catalog=Airline;User Id=hind;Password=hind12345;";
        private void User_information_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)//View user information
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Change_password a = new Change_password();
            a.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)//Show information
        {
            try
            {
                
                string sql = "select * from customer where idno='"+textBox1.Text.Trim()+"'";

                SqlConnection conn = new SqlConnection(str);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                sda.Fill(ds);  //Populate the dataset
                dataGridView1.DataSource = ds.Tables[0];
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)//Log out user
        {
            try
            {

                string sql = "delete from customer where idno='" + textBox1.Text.Trim() + "'";
                string sql1 = "delete from logins where idno='" + textBox1.Text.Trim() + "'";

                SqlConnection conn = new SqlConnection(str);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                SqlCommand cmd1= new SqlCommand(sql1, conn);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("User has deleted");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
