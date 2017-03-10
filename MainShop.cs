using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyShop
{
         
    public partial class MainShop : Form
    {
       private Basket basket = new Basket();
        public MainShop()
        {
            InitializeComponent();

        }

        private void aboutAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Letter letter = new Letter();
            Hide();
            letter.ShowDialog();
            Show();

        }
        
        private void MainShop_Shown(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sort sort = new Sort();
            Hide();
            sort.ShowDialog();
            Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string commandText = @"C:\Users\Denis Korotin\Desktop\Shop\MyShop\MyShop\bin\Debug\Help.docx";
            var proc = new Process();
            proc.StartInfo.FileName = commandText;
            proc.StartInfo.UseShellExecute = true;
            proc.Start();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Inquiry inquiry = new Inquiry();

            Hide();
            inquiry.ShowDialog();
            Show();
        }
        private void BasketMethod()
        {
            basket.basketResult.Controls.Add(label21);
            basket.basketResult.Controls.Add(label10);
            basket.basketResult.Controls.Add(label9);
            basket.basketResult.Controls.Add(label2);
            basket.basketResult.Controls.Add(pictureBox1);
            basket.basketResult.Location = new Point(22, 125);
            basket.basketResult.Size = new Size(370, 298);
            basket.basketResult.TabIndex = 7;
            basket.basketResult.TabStop = false;
            basket.basketResult.Text = "-";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Товар в корзине!");
            BasketMethod();
        }

        private void Jordan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Товар в корзине!");
        }

        private void Georgia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Товар в корзине!");
        }

        private void Zara_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Товар в корзине!");
        }

        private void Pants_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Товар в корзине!");
        }

        private void Jacket_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Товар в корзине!");
        }

        private void Basket_Click(object sender, EventArgs e)
        {
            Basket basket = new Basket();
            Hide();
            basket.ShowDialog();
            Show();
        }
    }
}
