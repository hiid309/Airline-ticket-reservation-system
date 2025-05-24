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
    public partial class Flight_information : Form
    {
        public static int orno = 0;
        string str = @"Data Source=DESKTOP-8DE8O09\SQLEXPRESS;Initial Catalog=Airline;User Id=hind;Password=hind12345;";
        public Flight_information()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string fno = "";
                string departure = comboBox1_departure.Text.Trim();
                string destination = comboBox1_destination.Text.Trim();
                string date = dateTimePicker1.Value.ToString("yyyy/MM/dd");
                string sql = "select * from flight where departure" + comboBox1_departure.Text.Trim() + "'" + " and destination= " + comboBox1_destination.Text.Trim() + " '" + "and date='" + date + "'";
                SqlConnection conn = new SqlConnection(str);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        fno = dr["fno"].ToString();
                    }
                }
                cmd.ExecuteNonQuery();
                DataSet ds = new DataSet();
                string sql1 = string.Format("select * from ticket where fno='" + fno + "'");
                SqlDataAdapter sda = new SqlDataAdapter(sql1, conn);
                sda.Fill(ds);  //Populate the dataset
                dataGridView1.DataSource = ds.Tables[0];
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button3_Click(object sender, EventArgs e)//Buy tickets
        {
            orno++;
            string id = login.Id;
            try
            {
                string date = dateTimePicker1.Value.ToString("yyyy/MM/dd");
                string sql = string.Format("insert into orders(orno,fno,fclass,date,price,idno) values('{0}',N'{1}',N'{2}',N'{3}',N'{4}','{5}')", orno, dataGridView1.CurrentRow.Cells[0].Value.ToString(), dataGridView1.CurrentRow.Cells[1].Value.ToString(), date, dataGridView1.CurrentRow.Cells[2].Value.ToString(), id);
                string sql2 = "update ticket set ticknum=ticknum-1";

                SqlConnection conn = new SqlConnection(str);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand(sql2, conn);
                cmd2.ExecuteNonQuery();
                Order_information a = new Order_information();
                a.ShowDialog();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.DialogResult = DialogResult.Cancel;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_departure_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
