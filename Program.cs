using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QC = System.Data.SqlClient;

namespace MyShop
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void connection_StateChange(object sender, System.Data.StateChangeEventArgs e)
        {
            SqlConnection connection = sender as SqlConnection;
           MessageBox.Show(
                "Connection to" + Environment.NewLine +
                "Data Source: " + connection.DataSource + Environment.NewLine +
                "Database: " + connection.Database + Environment.NewLine +
                "State: " + connection.State
                );
        }
        static void Main()
        {
            
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Headpiece());

            

        }
    }
}
