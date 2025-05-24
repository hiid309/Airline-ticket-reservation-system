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
    public partial class Refund_information : Form
    {
        public Refund_information()
        {
            InitializeComponent();
        }
        string str = @"Data Source=DESKTOP-8DE8O09\SQLEXPRESS;Initial Catalog=Airline;User Id=hind;Password=hind12345;";
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Refund_information_Load(object sender, EventArgs e)
        {

            try
            {
                string sql = "select * from orders";
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)//Refund
        {          
            try
            {
                SqlConnection conn = new SqlConnection(str);
                conn.Open();              
                string sql = "delete from orders where orno='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";
                MessageBox.Show("Refund successful");
                string sql2 = "update ticket set ticknum=ticknum+1";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                SqlCommand cmd2= new SqlCommand(sql2, conn);
                cmd2.ExecuteNonQuery();
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter("select * from orders", conn);
                sda.Fill(ds);  //Populate the dataset
                dataGridView1.DataSource = ds.Tables[0];
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
