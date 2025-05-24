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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
         
        }
        private void Flight_informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Flight_information a = new Flight_information();
            a.Show();
        }
        private void OrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order_information a = new Order_information();
            a.Show();
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void User_informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User_information a = new User_information();
            a.Show();
        }

        private void RefundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Airline_information a =  new Airline_information();
            a.Show();

        }

        private void Refund_informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Refund_information a = new Refund_information();
            a.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
