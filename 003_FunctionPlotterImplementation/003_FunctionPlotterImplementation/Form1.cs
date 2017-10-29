using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _003_FunctionPlotterImplementation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Btn_done_Click(object sender, EventArgs e)
        {
           
            string m = Txt_m.Text;
            string t = Txt_t.Text;
            string Start = Txt_Lo.Text;
            string End = Txt_Hi.Text;
            string i = Txt_i.Text;
            double[,] values = Program.Calculator( m, t, Start, End , i); //Call Calculator method

            
            for (int i1 = 0; i1 == values.GetLength(1); i1++)
            {
                ListView1.Items.Add(Convert.ToString(values[0,i1]));
                ListView2.Items.Add(Convert.ToString(values[1,i1]));
            }
        }
        
    }
}