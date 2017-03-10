using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyShop
{

    public partial class Entrance : Form
    {

        public Entrance()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EBHRT5L; Initial Catalog=Users; Integrated Security=True;"); // создание строки подключения


            SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder(); // создание конструктора строк подключения 
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From ShopUsers where UsersLogin='" + LoginText.Text + "'and UsersPassword = '" + PasswordText.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                try
                {
                    con.Open();
                    MessageBox.Show("Добро пожаловать в магазин!");
                    login = LoginText.Text;
                    MainShop mainshop = new MainShop();
                    Hide();
                    con.Close();
                    mainshop.ShowDialog();
                    Show();

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            else
            {
                MessageBox.Show("Такого пользователя не существует");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void shopUsersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            shopUsersBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(usersDataSet);

        }

        private void Entrance_Load(object sender, EventArgs e)
        {
            shopUsersTableAdapter.Fill(usersDataSet.ShopUsers);

        }

        private void Regestration_Click(object sender, EventArgs e)
        {
            Regestration regestration = new Regestration();
            regestration.ShowDialog();
            Hide();
            Show();
        }

        private void Regestration_Click_1(object sender, EventArgs e)
        {
            Regestration regestration = new Regestration();
            regestration.ShowDialog();
            Hide();
            Show();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string connect = "Provider=Microsoft.JET.OLEDB.4.0;data source=.\\Shop.mdb";
            OleDbConnection con = new OleDbConnection(connect);

            try
            {
                con.Open();
                MessageBox.Show("Подключение прошло успешно!");
                con.Close();
            }
            catch (Exception _ex)
            {
                MessageBox.Show(_ex.Message);
            }

        }
    }
}
