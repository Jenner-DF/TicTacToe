using System;
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
           Click.SendToBack();
            if (player)
            {
                player = false;
                Click.Text = "X";
            }
            else
            {
                player = true;
                Click.Text = "O";
            }

            count++;
            colorchange();
            click_image(Click.Name);
            //test display
            label1.Text = count.ToString();

            if (count == 9)
            {
                Panel.Enabled = false;
                panel_newgame.Enabled = true;
                score_tie.Text = (Convert.ToInt32(score_tie.Text) + 1).ToString();
            }

            else if (count >= 5)
            {
                winner();
                if (count % 2 == 0 && label1.Text == "WINNER")
                {
                    Panel.Enabled = false ;
                    panel_newgame.Enabled = true;
                    score_red.Text = (Convert.ToInt32(score_red.Text) + 1).ToString();
                }
                else if(count % 2 == 1 && label1.Text == "WINNER")
                {
                    Panel.Enabled = false;
                    panel_newgame.Enabled = true;
                    score_blue.Text = (Convert.ToInt32(score_blue.Text) + 1).ToString();
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
            //use try catch if adding picture box
            try
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
            }
            catch
            {

            }
            
        }//running

        private void click_image(string btn_name) //substring last letter of button name (number) then combine that number to picturebox name 
        { //I can change this in color change same pattern
            var a = btn_name.Substring(btn_name.Length-1);
            var b = "pictureBox" + a;
            

            if (count % 2 == 0)
            {
                Controls.Find(b, true)[0].BackgroundImage = Image.FromFile("D:\\File s\\Github Projects\\Csharp_Calculator\\TicTacToe\\tictactoe_O.png");
            }
            else
            {
                Controls.Find(b, true)[0].BackgroundImage = Image.FromFile("D:\\File s\\Github Projects\\Csharp_Calculator\\TicTacToe\\tictactoe_X.png");
            }
            
        }

        private void score_reset_Click(object sender, EventArgs e)
        {
            score_blue.Text = "0";
            score_red.Text = "0";
            score_tie.Text = "0";
            Panel_clicked(null,null);
        }

        private void Panel_clicked(object sender, EventArgs e)
        {
            Panel.Enabled = true;

           
             for (int button_count = 1; button_count <= 9; button_count++)
             {
                 var reset_text = "button" + button_count;
                 Controls.Find(reset_text, true)[0].Text = button_count.ToString();
                 Controls.Find(reset_text, true)[0].Enabled = true;
                 Controls.Find(reset_text, true)[0].BringToFront();

                try
                {
                    foreach (Button c in Panel.Controls)
                    {
                        c.FlatAppearance.MouseOverBackColor = Color.FromKnownColor(KnownColor.DodgerBlue);
                    }
                }
                catch { }
            }

            count = 0;
            panel_newgame.Enabled = false;
        }
    }
}//no reset, scoreboard, display winner, 
