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
        private void Button_Click(object sender, EventArgs e)
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
            colorchange();
            click_image(Click.Name);
            //checkwinner at > 4 clicks
            if (count >= 5 && count <= 9)
            {
                winner();
                if (count % 2 == 0 && checkwin)
                {//display winner red
                    Panel.Enabled = false;
                    panel_newgame.Enabled = true;
                    score_red.Text = (Convert.ToInt32(score_red.Text) + 1).ToString();
                    label_qmark.Text = "RED";
                    label_win.Text = "WINS";
                    label_whowill.Text = "";
                    label_qmark.ForeColor = Color.FromKnownColor(KnownColor.IndianRed);
                }
                else if (count % 2 == 1 && checkwin)
                {//display winner blue
                    Panel.Enabled = false;
                    panel_newgame.Enabled = true;
                    score_blue.Text = (Convert.ToInt32(score_blue.Text) + 1).ToString();
                    label_qmark.Text = "BLUE";
                    label_win.Text = "WINS";
                    label_whowill.Text = "";
                    label_qmark.ForeColor = Color.FromKnownColor(KnownColor.DodgerBlue);
                }
            }
            if (count == 9 && label_qmark.Text == "?")
            {//no winner
                Panel.Enabled = false;
                panel_newgame.Enabled = true;
                score_tie.Text = (Convert.ToInt32(score_tie.Text) + 1).ToString();
                label_whowill.Text = "IT'S A";
                label_qmark.Text = "TIE ";
                label_win.Text = "";
                label_qmark.ForeColor = Color.FromKnownColor(KnownColor.Khaki);
            }
        } //running
        private void winner()
        {
            if (button5.Text == button9.Text && button5.Text == button1.Text)      { checkwin = true; }//diagonal from left
            else if (button5.Text == button3.Text && button5.Text == button7.Text) { checkwin = true; }//diagonal from right
            else if (button5.Text == button4.Text && button5.Text == button6.Text) { checkwin = true; }// horizontal mid
            else if (button5.Text == button2.Text && button5.Text == button8.Text) { checkwin = true; }// vertical mid
            else if (button1.Text == button2.Text && button1.Text == button3.Text) { checkwin = true; }//topleft to right
            else if (button1.Text == button4.Text && button1.Text == button7.Text) { checkwin = true; }//topleft to bottom
            else if (button7.Text == button8.Text && button7.Text == button9.Text) { checkwin = true; }//botleft to right
            else if (button9.Text == button6.Text && button9.Text == button3.Text) { checkwin = true; }//botright to top
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
            Panel.Enabled = true;
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
                {//X_firstalways
                    foreach (Button c in Panel.Controls)
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
                foreach (Button button in Panel.Controls)
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

            if (count % 2 == 0)
            {//pictureO
                Controls.Find(picturebox_name, true)[0].BackgroundImage = Image.FromFile("tictactoe_O.png");
            }
            else
            {//pictureX
                Controls.Find(picturebox_name, true)[0].BackgroundImage = Image.FromFile("tictactoe_X.png");
            }
        }//running
    }
}//all buttons running
