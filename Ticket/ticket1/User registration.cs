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
    public partial class User_registration : Form
    {
        public User_registration()
        {
            InitializeComponent();
        }
        string str = @"Data Source=DESKTOP-8DE8O09\SQLEXPRESS;Initial Catalog=Airline;User Id=hind;Password=hind12345;";
        private void button1_Click(object sender, EventArgs e)
        {
             SqlConnection conn = new SqlConnection(str);
                conn.Open();
              if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") || (textBox4.Text == "") || (textBox5.Text == "") || (textBox6.Text == ""))   
              {                 
                  MessageBox.Show("Please enter complete registration information", "Input error", MessageBoxButtons.OK,MessageBoxIcon.Warning);         
              
              }            
              else if (textBox5.Text != textBox6.Text)           
              {               
                  MessageBox.Show("The passwords you entered not match", "Passwords are inconsistent", MessageBoxButtons.OK, MessageBoxIcon.Warning);  
              }            
              else 
              {   
                
                 string sql = string.Format("insert into customer values ('{0}',N'{1}',N'{2}',N'{3}',N'{4}')",textBox1.Text.Trim(),textBox2.Text.Trim(),textBox3.Text.Trim() ,textBox4.Text.Trim() ,textBox5.Text.Trim() );
                 string sql1 = string.Format("insert into logins values  ('{0}' ,'{1}' )", textBox4.Text.Trim(), textBox5.Text.Trim());  
                   SqlCommand cmd1 = new SqlCommand(sql, conn);
                   cmd1.ExecuteNonQuery();
                   SqlCommand cmd2 = new SqlCommand(sql1, conn);
                   cmd2.ExecuteNonQuery();
                 DataSet ds = new DataSet();         
                  DataSet Table = new DataSet();
                             
                  MessageBox.Show("Successful registration!", "Registration successful", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                  Form1 a = new Form1();
                  a.Show();
              }        
              }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }       
        
        }
    }

