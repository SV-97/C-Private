using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
        string gamestream;
        int turns = 0;

        private void Field_Clicked(object sender, EventArgs e)
        {
            Label current_label = sender as Label;
            int current_x = Convert.ToInt32(current_label.Name.Remove(0, current_label.Name.Length-2).Remove(1,1)); //extract current x coordinate from label name
            int current_y = Convert.ToInt32(current_label.Name.Remove(0, current_label.Name.Length - 1)); //extract current y coordinate from label name
           
            if (radioButton1.Checked) //selection player/AI
            { //PvP
                if (area[current_x, current_y] == '\0') //if clicked field is empty
                {
                    if (turn) //check which player's turn it is and select corresponding char
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
            { //PvE
                if (area[current_x, current_y] == '\0') //if clicked field is empty
                {
                    area[current_x, current_y] = 'X';
                    current_label.Text = Convert.ToString(area[current_x, current_y]);
                    turn = false;
                    if (CheckWin())
                    {
                        return;
                    }
                    else
                    {
                        Gamestream(current_x, current_y);
                        AI();
                    }
                }
            }
            CheckWin();
        }

        private void AI()
        {
            using (StreamReader sr = new StreamReader(textBox1.Text))
            {
                string brain = sr.ReadToEnd(); //Read brain
                string[] lines = brain.Split('\n'); //Seperate into array of lines
                List<string> winLines = new List<string>();
                List<string> loseLines = new List<string>();

                foreach (var line in lines) //write all lines where AI won into a list
                {
                    if (line.Contains("Winner: AI"))
                    {
                        winLines.Add(line);
                    }
                    if (line.Contains("Winner: Player 1"))
                    {
                        loseLines.Add(line);
                    }
                }

                string current_xy = gamestream.Remove(0,gamestream.Length-3).Replace(" ", ""); //last  player action
                string[] splitline;
                int[] weights = new int[lines.Length]; //weight for each line
                int current_line = 0;
                int line_to_choose = 0;
                try
                {
                    foreach (var line in winLines) //forEach case where AI won
                    {
                        splitline = line.Split(' ');
                        if (Convert.ToInt32(splitline[splitline.Length - 1]) < turns + 1) //if current line had less than the current number of turns
                        {
                            winLines.Remove(line);
                        }
                        else
                        {
                            if (splitline[turns] == current_xy) //if last player action is equal to legacy action
                            {
                                weights[current_line]++; //increase weight on line 
                            }
                        }
                        current_line++;
                    }
                }
                catch (Exception)
                {
                }
                
                current_line = 0;

                foreach (var line in loseLines) //forEach case where AI lost
                {
                    splitline = line.Split(' ');
                    if (splitline[turns] == current_xy) //if last player action is equal to legacy action
                    {
                        weights[current_line]--; //decrease weight on line 
                    }
                    current_line++;
                }

                for (int i = 0; i < weights.Length; i++) //Set line with most weight
                {
                    if (weights[i] > line_to_choose)
                    {
                        line_to_choose = i;
                    }
                }

                //set action to most weighted legacy AI choice
                //select line with most weight, split into arrays at whitespace, select element in array corresponding to current turn, remove x component from that string
                int legacy_ai_x = Convert.ToInt32(lines[line_to_choose].Split(' ')[turns].Remove(1,1)); 
                int legacy_ai_y = Convert.ToInt32(lines[line_to_choose].Split(' ')[turns].Remove(0, 1)); 

                Random random = new Random();
                int ai_x = random.Next(0, 3);
                int ai_y = random.Next(0, 3);
                int filledFields = 0;

                if (random.Next(0,1) == 0)
                {
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
                }
                else
                {
                    ai_x = legacy_ai_x;
                    ai_y = legacy_ai_y;
                }
                
                Gamestream(ai_x, ai_y);
                area[ai_x,ai_y] = 'O';
                areaLabels[ai_x, ai_y].Text = Convert.ToString(area[ai_x, ai_y]);
                turn = true;
            }
        }

        private void button1_Click(object sender, EventArgs e) //Reset
        {
            ClearArea();
            turns = 0;
            gamestream = "";
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

        private bool CheckWin()
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

                }
                if (area[0, i] != '\0')
                {
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
                exportBrain(winning_party);
                ClearArea();
                return true;
            }
            else
            {
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
                    winning_party = "Nobody";
                    MessageBox.Show(String.Format("Game Over! {0} won", winning_party), "Game Over!");
                    exportBrain(winning_party);
                    ClearArea();
                    return true;
                }
                return false;
            }
        }

        private void Gamestream(int x, int y)
        {
            gamestream += Convert.ToString(x);
            gamestream += Convert.ToString(y) + " ";
            turns++;
        }

        private void exportBrain(string winning_party)
        {
            string path = textBox1.Text; //Path to brain that's to be used
            
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@path, true))
            {
                file.WriteLine(gamestream + " Winner: " + winning_party + " at " + Convert.ToString(turns));
            }
            turns = 0;
            gamestream = "";
        }
    }
}
