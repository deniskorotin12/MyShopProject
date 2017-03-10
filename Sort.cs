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

namespace MyShop
{
    public partial class Sort : Form
    {
        string a1;
        public Sort()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conStr = @"Data Source = DESKTOP-EBHRT5L; Initial Catalog = ShopDB; Integrated Security = True";
            SqlConnection connection = new SqlConnection(conStr);
            connection.Open();

            SqlCommand cmd = new SqlCommand("Select Tovar FROM Tovar ORDER BY Tovar", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            mySort.Text = "";
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    mySort.Text += reader[i]+ Environment.NewLine;
                }
               
              
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string conStr = @"Data Source = DESKTOP-EBHRT5L; Initial Catalog = ShopDB; Integrated Security = True";
            SqlConnection connection = new SqlConnection(conStr);
            connection.Open();

            SqlCommand cmd = new SqlCommand("Select Tovar FROM Tovar ORDER BY Tovar DESC", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            mySort.Text = "";
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    mySort.Text += reader[i] + Environment.NewLine;
                }


            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            Microsoft.Office.Interop.Word.Document doc = app.Documents.Add();
            doc.Paragraphs[1].Range.Text = this.mySort.Text;
            app.Visible = true;
            this.button1.Enabled = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            mySort.Text = a1;
            Microsoft.Office.Interop.Excel.Application ObjExcel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ObjWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ObjWorkSheet;
            //Книга.
            ObjWorkBook = ObjExcel.Workbooks.Add(System.Reflection.Missing.Value);
            //Таблица.
            ObjWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ObjWorkBook.Sheets[1];

            //Значения [y - строка,x - столбец]
            ObjWorkSheet.Cells[1, 1] = a1;
            //Вызываем нашу созданную эксельку.
            ObjExcel.Visible = true;
            ObjExcel.UserControl = true;
        }
    }
    }

