using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _006_TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            areaLabels[0, 0] = label00;
            areaLabels[1, 0] = label10;
            areaLabels[2, 0] = label20;
            areaLabels[0, 1] = label01;
            areaLabels[1, 1] = label11;
            areaLabels[2, 1] = label21;
            areaLabels[0, 2] = label02;
            areaLabels[1, 2] = label12;
            areaLabels[2, 2] = label22;
        }

        public bool turn = false; //false = player 1
        char[,] area = new char[3, 3]; //[x,y]
        Label[,] areaLabels = new Label[3, 3];

        private void Field_Clicked(object sender, EventArgs e)
        {
            Label current_label = sender as Label;
            int current_x = Convert.ToInt32(current_label.Name.Remove(0, current_label.Name.Length-2).Remove(1,1)); //extract current x coordinate from label name
            int current_y = Convert.ToInt32(current_label.Name.Remove(0, current_label.Name.Length - 1)); //extract current y coordinate from label name
           
            if (radioButton1.Checked) //selection player/AI
            {
                if (area[current_x, current_y] == '\0') //if clicked field is empty
                {
                    if (turn) //check which players turn it is and select corresponding char
                    {
                        area[current_x, current_y] = 'X';
                        turn = false;
                    }
                    else
                    {
                        area[current_x, current_y] = 'O';
                        turn = true;
                    }
                }
                current_label.Text = Convert.ToString(area[current_x, current_y]);
            }
            else
            {
                if (area[current_x, current_y] == '\0') //if clicked field is empty
                {
                    area[current_x, current_y] = 'X';
                    current_label.Text = Convert.ToString(area[current_x, current_y]);
                    turn = false;
                    CheckWin();
                    AI();
                }
            }
            CheckWin();
        }

        private void AI()
        {
            Random random = new Random();
            int ai_x = random.Next(0, 3);
            int ai_y = random.Next(0, 3);
            int filledFields = 0;
            foreach (var field in area)
            {
                if (field != '\0')
                {
                    filledFields++;
                }
            }
            if (filledFields >= 9)
            {
                return;
            }
            while (area[ai_x, ai_y] != '\0')
            {
                ai_x = random.Next(0, 3);
                ai_y = random.Next(0, 3);
            }
            area[ai_x,ai_y] = 'O';
            areaLabels[ai_x, ai_y].Text = Convert.ToString(area[ai_x, ai_y]);
            turn = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearArea();
        }

       private void ClearArea()
        {
            for (int i = 0; i < area.GetLength(0); i++)
            {
                area[i, 0] = '\0';
                area[i, 1] = '\0';
                area[i, 2] = '\0';
                areaLabels[i, 0].Text = "";
                areaLabels[i, 1].Text = "";
                areaLabels[i, 2].Text = "";
            }
        }

        private void CheckWin()
        {
            bool win = false;
            char winning_sign = '\0';
            string winning_party = "";
            for (int i = 0; i < area.GetLength(0); i++)
            {
                if (area[i, 0] != '\0')
                {
                    if (area[i, 0] == area[i, 1]) //check for horizontal wincase
                    {
                        if (area[i, 0] == area[i, 2])
                        {
                            win = true;
                            winning_sign = area[i, 0];
                        }
                    }

                    if (area[0, i] == area[1, i]) //check for vertical wincase
                    {
                        if (area[0, i] == area[2, i])
                        {
                            win = true;
                            winning_sign = area[0, i];
                        }
                    }
                }
            }

            if (area[1,1] != '\0')
            {
                if (area[0, 0] == area[1, 1]) //check diagonal wincase 1
                {
                    if (area[0, 0] == area[2, 2])
                    {
                        win = true;
                        winning_sign = area[1, 1];
                    }
                }

                if (area[2, 0] == area[1, 1]) //check diagonal wincase 2
                {
                    if (area[2, 0] == area[0, 2])
                    {
                        win = true;
                        winning_sign = area[1, 1];
                    }
                }
            }
            
            if (win)
            {
                if (winning_sign == 'X')
                {
                    winning_party = "Player 1";
                }
                else
                {
                    if (radioButton1.Checked)
                    {
                        winning_party = "Player 2";
                    }
                    else
                    {
                        winning_party = "AI";
                    }
                }
                MessageBox.Show(String.Format("Game Over! {0} won", winning_party),"Game Over!");
                ClearArea();
            }
        }
    }
}
