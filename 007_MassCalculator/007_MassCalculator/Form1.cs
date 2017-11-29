using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _007_MassCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void calculate()
        {
            double val1 = 1;
            double val2 = 1;
            double val3 = 1;
            double density;
            double mass;
            label5.Visible = false;
            try
            {
                if (dimension1.Text != "")
                {
                    val1 = Convert.ToDouble(dimension1.Text.Replace(".", ",")); //Substringsubstitution to assure valid float-values in arithmetics
                };
                if (dimension2.Text != "")
                {
                    val2 = Convert.ToDouble(dimension2.Text.Replace(".", ","));
                };
                if (dimension3.Text != "")
                {
                    val3 = Convert.ToDouble(dimension3.Text.Replace(".", ","));
                };
            }
            catch (FormatException)
            {
                label5.Visible = true;
            }
            

            switch (dropdown.Text) // set density in kg/dm^3 or g/cm^3
            {
                case "Aluminium":
                    density = 2.6989;
                    break;
                case "Stahl":
                    density = 7.85;
                    break;
                default:
                    density = 1;
                    break;
            }
            density = density / 1000000; //transfer kg/dm^3 to km/mm^3
            mass = density * val1 * val2 * val3;
            massBox.Text = Convert.ToString(mass);
        }

        private void enterToTab(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void dimension1_TextChanged(object sender, EventArgs e)
        {
            calculate();
        }

        private void dimension2_TextChanged(object sender, EventArgs e)
        {
            calculate();
        }

        private void dimension3_TextChanged(object sender, EventArgs e)
        {
            calculate();
        }
        
        private void dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculate();
        }

        private void dimension1_KeyDown(object sender, KeyEventArgs e)
        {
            enterToTab(e);
        }

        private void dimension2_KeyDown(object sender, KeyEventArgs e)
        {
            enterToTab(e);
        }

        private void dimension3_KeyDown(object sender, KeyEventArgs e)
        {
            enterToTab(e);
        }

        private void dropdown_KeyDown(object sender, KeyEventArgs e)
        {
            enterToTab(e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
