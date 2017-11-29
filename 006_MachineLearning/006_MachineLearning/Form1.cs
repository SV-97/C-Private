using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _006_MachineLearning
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = "Tic Tac Toe";
        }

        private void box_1A_Click(object sender, EventArgs e)
        {
            box_1A.Visible = true;
            box_1A.Text = "X";
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\SV-97\Desktop\AUD - WA0033[1].wav");
            player.Play();
        }

        private void box_2A_Click(object sender, EventArgs e)
        {
            box_2A.Text = "X";
        }

        private void box_3A_Click(object sender, EventArgs e)
        {
            box_3A.Text = "X";
        }

        private void box_1B_Click(object sender, EventArgs e)
        {
            box_1B.Text = "X";
        }

        private void box_2B_Click(object sender, EventArgs e)
        {
            box_2B.Text = "X";
        }

        private void box_3B_Click(object sender, EventArgs e)
        {
            box_3B.Text = "X";
        }

        private void box_1C_Click(object sender, EventArgs e)
        {
            box_1C.Text = "X";
        }

        private void box_2C_Click(object sender, EventArgs e)
        {
            box_2C.Text = "X";
        }

        private void box_3C_Click(object sender, EventArgs e)
        {
            box_3C.Text = "X";
        }

    }
}
