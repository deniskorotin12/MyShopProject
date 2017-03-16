using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyShop
{
    public partial class Letter : Form
    {
        public Letter()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (myLetter.Text == "" || myTelephone.Text == "(   )    -")
            {
                MessageBox.Show("Один из полей не заполнены!");
            }
            else{ 
            MessageBox.Show("Ваше письмо отправлено");
            Close();
            }
        }
    }
}
