using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _006_MachineLearning
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            char[,] values = new char[3,3] { { box_1A.Text , box_2A.Text, box_3A.Text } , { box_1B.Text, box_2B.Text, box_3B.Text } , { box_1C.Text, box_2C.Text, box_3C.Text } };

        }
    }
}
