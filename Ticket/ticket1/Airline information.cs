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
    public partial class Airline_information : Form
    {
        public Airline_information()
        {
            InitializeComponent();
        }
        string str = @"Data Source=DESKTOP-8DE8O09\SQLEXPRESS;Initial Catalog=Airline;User Id=hind;Password=hind12345;";
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Airline_information_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from air";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
