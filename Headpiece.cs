using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Threading;

namespace MyShop
{
    public partial class Headpiece : Form
    {
        public Headpiece()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Entrance entrance = new Entrance();
            entrance.Show();
            Hide();
            Close();
            
        }

        private void Headpiece_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Entrance entrance = new Entrance();
            Hide();
            entrance.ShowDialog();
            Close();
           
        }

        private void Headpiece_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false; 
            Entrance entrance = new Entrance();
            Hide();
            entrance.ShowDialog();
            Close();
        }
    }


}
