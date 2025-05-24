using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient ;

namespace ticket1
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            string cstr= @"Data Source=DESKTOP-8DE8O09\SQLEXPRESS;Initial Catalog=Airline;User Id=hind;Password=hind12345;";
            try
            {
                SqlConnection conn = new SqlConnection(cstr);
                conn.Open();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new login());
        }
    }
}
