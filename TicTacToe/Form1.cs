﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool player = true;
        byte count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Button_Click(object sender, EventArgs e)
        {
           Button Click = sender as Button;
           Click.Enabled = false; 

            if (player)
            {
                Click.Image = Image.FromFile("D:\\File s\\Github Projects\\Csharp_Calculator\\TicTacToe\\tictactoe_X.png");
                player = false;
                Click.Text = "X";
            }
            else
            {
                Click.Image = Image.FromFile("D:\\File s\\Github Projects\\Csharp_Calculator\\TicTacToe\\tictactoe_O.png");
                player = true;
                Click.Text = "O";
            }

            count++;
            colorchange();
            //test display
            label1.Text = count.ToString();

            if (count >= 5)
            {
                winner();
                if (label1.Text == "WINNER")
                {
                    Panel.Enabled = false;
                }
            }
        } // improve design, change Click.enabled to something to preserve color
        private void winner()
        {
            if (button5.Text == button9.Text && button5.Text == button1.Text)//diagonal from left
            {
                label1.Text = "WINNER";
            }
            else if (button5.Text == button3.Text && button5.Text == button7.Text)//diagonal from right
            {
                label1.Text = "WINNER";
            }
            else if (button5.Text == button4.Text && button5.Text == button6.Text)// horizontal mid
            {
                label1.Text = "WINNER";
            }
            else if (button5.Text == button2.Text && button5.Text == button8.Text)// vertical mid
            {
                label1.Text = "WINNER";
            }
            else if (button1.Text == button2.Text && button1.Text == button3.Text)//topleft to right
            {
                label1.Text = "WINNER";
            }
            else if (button1.Text == button4.Text && button1.Text == button7.Text)//topleft to bottom
            {
                label1.Text = "WINNER";
            }
            else if (button7.Text == button8.Text && button7.Text == button9.Text)//botleft to right
            {
                label1.Text = "WINNER";
            }
            else if (button9.Text == button6.Text && button9.Text == button3.Text)//botright to top
            {
                label1.Text = "WINNER";
            }

        }//running
        private void colorchange()
        {
            foreach (Button c in Panel.Controls)
            {
                if (count % 2 == 0)
                {
                    c.FlatAppearance.MouseOverBackColor = Color.FromKnownColor(KnownColor.DodgerBlue);
                }
                else
                {
                    c.FlatAppearance.MouseOverBackColor = Color.FromKnownColor(KnownColor.IndianRed);
                }
            }
        }//running
    }
}
