using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyShop
{
    public partial class MainMenuShop : Form
    {
        public MainMenuShop()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ForMens formens = new ForMens();
            Hide();
            formens.ShowDialog();
            Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ForWooman forwoomen = new ForWooman();
            Hide();
            forwoomen.ShowDialog();
            Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ForKids forkids = new ForKids();
            Hide();
            forkids.ShowDialog();
            Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Footwear footwear = new Footwear();
            Hide();
            footwear.ShowDialog();
            Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Outerwear outerwear = new Outerwear();
            Hide();
            outerwear.ShowDialog();
            Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string commandText = @"C:\Users\Denis Korotin\Desktop\Shop\MyShop\MyShop\Resources\CHMHelp.chm";
            var proc = new Process();
            proc.StartInfo.FileName = commandText;
            proc.StartInfo.UseShellExecute = true;
            proc.Start();
        }
    }
}
