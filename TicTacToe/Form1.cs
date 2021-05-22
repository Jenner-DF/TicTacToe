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
            }
            else
            {
                Click.Image = Image.FromFile("D:\\File s\\Github Projects\\Csharp_Calculator\\TicTacToe\\tictactoe_O.png");
                player = true;
            }

            
            
            
            count++;
            colorchange();


            /* if (count >= 5)
             {
                 var check = winner();
             }

             label1.Text = Click.Text;// test*/

            //create function to check if there is a winner

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
        }

        /*private string winner()
{
string champion;
Console.WriteLine("Hello");

return champion;

}*/
    }
}
