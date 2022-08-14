using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleMinefield
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int mineScore;


        private void btnStart_Click(object sender, EventArgs e)
        {

            //int mineScore = 0;
            Random rnd = new Random();      //for allocating bombs at random places in the specified interval
            int bomb1 = rnd.Next(1, 64);
            int bomb2 = rnd.Next(1, 64);
            int bomb3 = rnd.Next(1, 64);
            int bomb4 = rnd.Next(1, 64);
            int bomb5 = rnd.Next(1, 64);
            int bomb6 = rnd.Next(1, 64);
            int bomb7 = rnd.Next(1, 64);
            int bomb8 = rnd.Next(1, 64);
            int bomb9 = rnd.Next(1, 64);
            int bomb10 = rnd.Next(1, 64);
            int bomb11 = rnd.Next(1, 64);
            int bomb12 = rnd.Next(1, 64);


            for (int i = 1; i <= 64; i++)
            {
                Button btnTemp = new Button();
                
                //btnTemp.Text = mineScore.ToString();
                mineScore = 0;

                btnTemp.Size = new System.Drawing.Size(30, 30);     //makes a matrix that fits in flow layout panel

                if (bomb1 == i - 9 || bomb1 == i - 8 || bomb1 == i - 7 || bomb1 == i - 1 || bomb1 == i + 1 || bomb1 == i + 7 || bomb1 == i + 8 || bomb1 == i + 9)
                    mineScore++;
                if (bomb2 == i - 9 || bomb2 == i - 8 || bomb2 == i - 7 || bomb2 == i - 1 || bomb2 == i + 1 || bomb2 == i + 7 || bomb2 == i + 8 || bomb2 == i + 9)
                    mineScore++;
                if (bomb3 == i - 9 || bomb3 == i - 8 || bomb3 == i - 7 || bomb3 == i - 1 || bomb3 == i + 1 || bomb3 == i + 7 || bomb3 == i + 8 || bomb3 == i + 9)
                    mineScore++;
                if (bomb4 == i - 9 || bomb4 == i - 8 || bomb4 == i - 7 || bomb4 == i - 1 || bomb4 == i + 1 || bomb4 == i + 7 || bomb4 == i + 8 || bomb4 == i + 9)
                    mineScore++;
                if (bomb5 == i - 9 || bomb5 == i - 8 || bomb5 == i - 7 || bomb5 == i - 1 || bomb5 == i + 1 || bomb5 == i + 7 || bomb5 == i + 8 || bomb5 == i + 9)
                    mineScore++;
                if (bomb6 == i - 9 || bomb6 == i - 8 || bomb6 == i - 7 || bomb6 == i - 1 || bomb6 == i + 1 || bomb6 == i + 7 || bomb6 == i + 8 || bomb6 == i + 9)
                    mineScore++;
                if (bomb7 == i - 9 || bomb7 == i - 8 || bomb7 == i - 7 || bomb7 == i - 1 || bomb7 == i + 1 || bomb7 == i + 7 || bomb7 == i + 8 || bomb7 == i + 9)
                    mineScore++;
                if (bomb8 == i - 9 || bomb8 == i - 8 || bomb8 == i - 7 || bomb8 == i - 1 || bomb8 == i + 1 || bomb8 == i + 7 || bomb8 == i + 8 || bomb8 == i + 9)
                    mineScore++;
                if (bomb9 == i - 9 || bomb9 == i - 8 || bomb9 == i - 7 || bomb9 == i - 1 || bomb9 == i + 1 || bomb9 == i + 7 || bomb9 == i + 8 || bomb9 == i + 9)
                    mineScore++;
                if (bomb10 == i - 9 || bomb10 == i - 8 || bomb10 == i - 7 || bomb10 == i - 1 || bomb10 == i + 1 || bomb10 == i + 7 || bomb10 == i + 8 || bomb10 == i + 9)
                    mineScore++;
                if (bomb11 == i - 9 || bomb11 == i - 8 || bomb11 == i - 7 || bomb11 == i - 1 || bomb11 == i + 1 || bomb11 == i + 7 || bomb11 == i + 8 || bomb11 == i + 9)
                    mineScore++;
                if (bomb12 == i - 9 || bomb12 == i - 8 || bomb12 == i - 7 || bomb12 == i - 1 || bomb12 == i + 1 || bomb12 == i + 7 || bomb12 == i + 8 || bomb12 == i + 9)
                    mineScore++;



                
                btnTemp.ForeColor = Color.AntiqueWhite;
                if (bomb1 == i || bomb2 == i || bomb3 == i || bomb4 == i || bomb5 == i || bomb6 == i || bomb7 == i || bomb8 == i || bomb9 == i || bomb10 == i || bomb11 == i || bomb12 == i)
                {
                    btnTemp.Tag = true;
                    
                }
                else
                {
                    btnTemp.Tag = false;
                    btnTemp.Text = mineScore.ToString();
                    
                }


                
                btnTemp.Click += BtnTemp_Click;     //indicates a click has occured
                flowLayoutPanel1.Controls.Add(btnTemp);
                

                Console.WriteLine(mineScore);
            }
        }

        private void BtnTemp_Click(object sender, EventArgs e)      //for matrix buttons
        {
            Button btnTemp = (Button)sender;        //assign a button to object
            bool tag = (bool)btnTemp.Tag;           //assigns a tag to store the value and check above condition
            
            if (tag)
            {
                
                btnTemp.BackColor = Color.Red;
                btnTemp.ForeColor = Color.AntiqueWhite;//red for bomb
                int score = int.Parse(lblBomb.Text);        //converting string to int to display bomb when it bursts
                score++;    
                lblBomb.Text = score.ToString();        //Bomb gets one

                if (score == 1)        //whenever bomb is pressed it asksyou for restart
                {
                    DialogResult result = MessageBox.Show("You are lost\nRestart ?", "Game Result", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                    if (result == DialogResult.Yes)
                        Application.Restart();
                    else
                        Close();
                }
            }
            else
            {
                //btnTemp.Text=mineScore.ToString();
                btnTemp.BackColor = Color.Green;        //green for a non-bomb box
                btnTemp.ForeColor = Color.AntiqueWhite;
                int score = int.Parse(lblScore.Text);       
                score++;        //the score gets incremented until bomb is pressed
                lblScore.Text = score.ToString();
            }
        }
        private void BtnTemp2_Click(object sender, EventArgs e)
        {

        }


    }
}
