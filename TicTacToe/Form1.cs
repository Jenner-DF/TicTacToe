using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool player ;
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
            if (player)
            {
                Click.Image = Image.FromFile("D:\\File s\\Github Projects\\Csharp_Calculator\\tictactoe_X.png");
                player = false;
            }
            else
            {
                Click.Image = Image.FromFile("D:\\File s\\Github Projects\\Csharp_Calculator\\tictactoe_O.png");
                player = true;
            }

            
            label1.Text = Click.Text;

           


        }
    }
}
