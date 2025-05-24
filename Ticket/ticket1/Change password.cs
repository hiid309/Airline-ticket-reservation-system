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
    public partial class Change_password : Form
    {
        public static string id;

        public static string Id
        {
            get { return login.id; }
            set { login.id = value; }
        }

        string str = @"Data Source=DESKTOP-8DE8O09\SQLEXPRESS;Initial Catalog=Airline;User Id=hind;Password=hind12345;";
        public Change_password()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)//Confirm password change
        {
            string pwd="";
            string id = login.Id;
            try
            {
                SqlConnection conn = new SqlConnection(str);
                conn.Open();
                string sql = "select * from  customer where idno='" +id+"'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                         pwd = dr["pwd"].ToString();                     
                    }
                 }
                conn.Close();
                if (textBox1_old.Text.Trim() == pwd.Trim())
                {
                    if (textBox2_new.Text.Trim() == textBox3_newr.Text.Trim())//Determine whether two passwords are equal
                    {
                        string sql1 = "update customer set pwd=N'" + textBox2_new.Text.Trim() + "'" + " where idno='" + id + "'";
                        string sql2 = "update logins set pwd=N'" + textBox2_new.Text.Trim() + "'" + " where idno='" + id + "'";
                        
                            conn.Open();
                            SqlCommand cmd1 = new SqlCommand(sql1, conn);
                            cmd1.ExecuteNonQuery();
                            SqlCommand cmd2 = new SqlCommand(sql2, conn);
                            cmd2.ExecuteNonQuery();
                            MessageBox.Show("Password changed successfully"); 
                    }
                    else
                    {
                        MessageBox.Show("The two passwords you entered not match!");
                        textBox1_old.Focus();
                        textBox2_new.Clear();
                        textBox3_newr.Clear();
                        return;
                    }
                        }
                else
                {
                    MessageBox.Show("The old passwords you entered not match!");
                    textBox1_old.Clear();
                    textBox2_new.Clear();
                    textBox3_newr.Clear();
                    return;
                }

            }
       
              catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    
}
         