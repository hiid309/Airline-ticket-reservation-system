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
    public partial class login : Form
    {
        public static string id;

        public static string Id
        {
            get { return login.id; }
            set { login.id = value; }
        }
        string str = @"Data Source=DESKTOP-8DE8O09\SQLEXPRESS;Initial Catalog=Airline;User Id=hind;Password=hind12345;";

        public login()
        {
            InitializeComponent();
        }

        private void button_load_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(str);
                conn.Open();
                string sql = "select * from logins where idno=" + textBox_id.Text;
                login.Id = textBox_id.Text;
                SqlCommand cmd = new SqlCommand(sql, conn);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        string pwd = dr["PWD"].ToString();
                        if (textBox_pwd.Text.Trim() == pwd.Trim())
                        {
                            MessageBox.Show("Welcome to the air ticket booking system!");
                            
                            Form1 a = new Form1();
                           a.ShowDialog();                     
                            this.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Wrong userID or password!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User_registration a = new User_registration();
            a.Show();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }



}
