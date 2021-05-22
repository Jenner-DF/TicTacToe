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
            label1.Text = count.ToString();
            if (count >= 5)
            {
                label1.Text = "YOLO";
               winner(Click.Text);
            }

            //label1.Text = Click.Text;// test*/
            
            //create function to check if there is a winner

        }

        private void winner(string last_click)
        {
            if (last_click == button2.Text && last_click == button3.Text) //|| last_click == button4.Image || last_click == button5.Image)
            {
                label1.Text = "WINNER";
            }
            else if (last_click == button5.Text && last_click == button9.Text)
            {
                label1.Text = "WINNER";
            }
            else if(last_click == button4.Text && last_click == button7.Text)
            {
                label1.Text = "WINNER";
            }
            
        }
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
