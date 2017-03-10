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
    public partial class Regestration : Form
    {
        public Regestration()
        {
            InitializeComponent();
        }

        private void btnRegestration_Click(object sender, EventArgs e)
        {

            string myRegLogin = regLogin.Text;
            string myRegPassword = regPassword.Text;

            if (myRegPassword != regRepPassword.Text)
            {
                MessageBox.Show("Пароли не совпадают");
            }
            else if (myRegPassword.Length < 6)
            {
                MessageBox.Show("Пароль должен быть более 6 символов");
            }
            else
            {
                string conStr = @"Data Source=DESKTOP-EBHRT5L; Initial Catalog=Users; Integrated Security=True;"; // создание строки подключения  
                    using (SqlConnection con = new SqlConnection(conStr))
                    {
                        SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From ShopUsers where UsersLogin='" + regLogin.Text + "'", con);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        if (dt.Rows[0].ToString() == "1")
                        {
                            con.Open();
                            MessageBox.Show("Такой пользователь уже существует!");
                            con.Close();
                        }
                        else
                        {
                            try
                            {
                                string sql = string.Format("INSERT Into ShopUsers (UsersLogin, UsersPassword) VALUES ('{0}','{1}')", myRegLogin, myRegPassword);
                                SqlCommand cmd = new SqlCommand(sql, con);
                                cmd.CommandType = CommandType.Text;
                                con.Open();
                                cmd.ExecuteNonQuery();
                                con.Close();
                                MessageBox.Show("Спасибо за регистрацию!");
                                Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }



                    }
                }
              
            }





        }
    }
