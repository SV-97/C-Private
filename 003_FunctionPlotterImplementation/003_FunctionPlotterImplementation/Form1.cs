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
        }    
    }
}