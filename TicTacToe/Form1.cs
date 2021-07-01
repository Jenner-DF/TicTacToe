using System;
using System.Drawing;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool player, checkwin = false;
        byte count = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Tile_Click(object sender, EventArgs e)
        {
           Button Click = sender as Button;
           Click.Enabled = false;
           Click.SendToBack();

            if (!player)
            {
                player = true;
                Click.Text = "X";
            }
            else
            {
                player = false;
                Click.Text = "O";
            }    
            count++;

            colorchange(); //swap color blue/red when mouse hover
            click_image(Click.Name); //get tile image
            winner();

        } //running
        private void winner()
        {
            if      (button5.Text == button9.Text && button5.Text == button1.Text) { checkwin = true; }//diagonal from left
            else if (button5.Text == button3.Text && button5.Text == button7.Text) { checkwin = true; }//diagonal from right
            else if (button5.Text == button4.Text && button5.Text == button6.Text) { checkwin = true; }// horizontal mid
            else if (button5.Text == button2.Text && button5.Text == button8.Text) { checkwin = true; }// vertical mid
            else if (button1.Text == button2.Text && button1.Text == button3.Text) { checkwin = true; }//topleft to right
            else if (button1.Text == button4.Text && button1.Text == button7.Text) { checkwin = true; }//topleft to bottom
            else if (button7.Text == button8.Text && button7.Text == button9.Text) { checkwin = true; }//botleft to right
            else if (button9.Text == button6.Text && button9.Text == button3.Text) { checkwin = true; }//botright to top

            if (checkwin)
            {
                panel_controls.Enabled = false;
                panel_newgame.Enabled = true;
                label_whowill.Text = "";
                label_win.Text = "WINS";

                if (count % 2 == 0)
                {
                    winner_red();
                }
                else
                {
                    winner_blue();
                }
            }
            else if (!checkwin && count == 9)
            {
                winner_TIE();
            }

            //get Winner
            void winner_blue()
            {
                label_qmark.Text = "BLUE";
                score_blue.Text = (Convert.ToInt32(score_blue.Text) + 1).ToString();
                label_qmark.ForeColor = Color.FromKnownColor(KnownColor.DodgerBlue);
            }
            void winner_red()
            {
                label_qmark.Text = "RED";
                score_red.Text = (Convert.ToInt32(score_red.Text) + 1).ToString();
                label_qmark.ForeColor = Color.FromKnownColor(KnownColor.IndianRed);
            }

            void winner_TIE()
            {
                panel_controls.Enabled = false;
                panel_newgame.Enabled = true;
                score_tie.Text = (Convert.ToInt32(score_tie.Text) + 1).ToString();
                label_whowill.Text = "IT'S A";
                label_qmark.Text = "TIE ";
                label_win.Text = "";
                label_qmark.ForeColor = Color.FromKnownColor(KnownColor.Khaki);
            }
        }//running
        private void score_reset_Click(object sender, EventArgs e)
        {
            score_blue.Text = "0";
            score_red.Text = "0";
            score_tie.Text = "0";
            Panel_clicked(null,null);
        }//running
        private void Panel_clicked(object sender, EventArgs e)
        {
            panel_controls.Enabled = true;
            for (int button_count = 1; button_count <= 9; button_count++)
            {
                var reset_text = "button" + button_count; { checkwin = true; }
                Controls.Find(reset_text, true)[0].Text = button_count.ToString();
                Controls.Find(reset_text, true)[0].Enabled = true;
                Controls.Find(reset_text, true)[0].BringToFront();
                 
                label_qmark.Text = "?";
                label_win.Text = "WIN";
                label_whowill.Text = "WHO WILL";
                label_qmark.ForeColor = Color.FromKnownColor(KnownColor.SpringGreen);
                try
                {//X <- firstalways
                    foreach (Button c in panel_controls.Controls) //reset to blue color when mouse hover
                    {
                        c.FlatAppearance.MouseOverBackColor = Color.FromKnownColor(KnownColor.DodgerBlue);
                    }
                }
                catch { }
            }
            count = 0;
            checkwin = false;
            panel_newgame.Enabled = false;
        }//running
        //AESTHETICS
        private void colorchange()
        {//whenMouseHover
            try
            {
                foreach (Button button in panel_controls.Controls)
                {
                    if (count % 2 == 0)
                    {//colorBlue
                        button.FlatAppearance.MouseOverBackColor = Color.FromKnownColor(KnownColor.DodgerBlue);
                    }
                    else
                    {//colorRed
                        button.FlatAppearance.MouseOverBackColor = Color.FromKnownColor(KnownColor.IndianRed);
                    }
                }
            }
            catch { }
        }//running
        private void click_image(string btn_name)
        {
            var last = btn_name.Substring(btn_name.Length - 1);
            var picturebox_name = "pictureBox" + last;

            if (count % 2 == 0) //image O
            {
                //panel_controls[1].BackgroundImage = Image.FromFile("tictactoe_O.png");
                Controls.Find(picturebox_name, true)[0].BackgroundImage = Image.FromFile("tictactoe_O.png");
            }
            else //image X
            {
                Controls.Find(picturebox_name, true)[0].BackgroundImage = Image.FromFile("tictactoe_X.png");
            }
        }//running
    }
}//all buttons running
