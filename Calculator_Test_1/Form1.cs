using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Test_1
{
   
    public partial class Form1 : Form
    {
        double Num1, Num2, Num3;
        string Operator;
        bool op, eq = true;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }
        private void num_0_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" || op == false)
            {
                label1.Text = "0";
                op = true; //to reset count after operator
            }
            else
            {
                label1.Text = label1.Text + "0";
            }
        }

        private void num_1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" || op == false)
            {
                label1.Text = "1";
                op = true;
            }
            else 
            { 
                label1.Text = label1.Text + "1";
            }
        }

        private void num_2_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" || op == false)
            {
                label1.Text = "2";
                op = true;
            }
            else
            {
                label1.Text = label1.Text + "2";
            }
        }

        private void num_3_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" || op == false)
            {
                label1.Text = "3";
                op = true;
            }
            else
            {
                label1.Text = label1.Text + "3";
            }
        }

        private void num_4_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" || op == false)
            {
                label1.Text = "4";
                op = true;
            }
            else
            {
                label1.Text = label1.Text + "4";
            }
        }

        private void num_5_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" || op == false)
            {
                label1.Text = "5";
                op = true;
            }
            else
            {
                label1.Text = label1.Text + "5";
            }
        }

        private void num_6_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" || op == false)
            {
                label1.Text = "6";
                op = true;
            }
            else
            {
                label1.Text = label1.Text + "6";
            }
        }

        private void num_7_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" || op == false)
            {
                label1.Text = "7";
                op = true;
            }
            else
            {
                label1.Text = label1.Text + "7";
            }
        }

        private void num_8_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" || op == false)
            {
                label1.Text = "8";
                op = true;
            }
            else
            {
                label1.Text = label1.Text + "8";
            }
        }

        private void num_9_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" || op == false)
            {
                label1.Text = "9";
                op = true;
            }
            else
            {
                label1.Text = label1.Text + "9";
            }
        }

        private void _backspace_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text.Remove(label1.Text.Length - 1);
        }

        private void _clearAll_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            label1.Text = "0";
        }

        private void _subtract_Click(object sender, EventArgs e)
        {
            Operator = "-";
            op = false;
            eq = true;

            Num1 = Convert.ToDouble(label1.Text);
            label2.Text = Num1.ToString() + " " + Operator;
        }

        private void _add_Click(object sender, EventArgs e)
        {
            Operator = "+";
            op = false;
            eq = true;

            //display in label 2
            
            Num1 = Convert.ToDouble(label1.Text); // must be a function (Num1 = ) so I can add commas
            Num2 = Convert.ToDouble(label1.Text);
            

            label2.Text = Num1.ToString() +" "+ Operator; //must be a function(clearEntry)
            

            /*
            if (op == true)
            {
                double result;
                Num2 = Convert.ToDouble(label1.Text);
                result = Num1 + Num2;
                label1.Text = result.ToString();
            }
            */
            // if any number button is click,reset to 0, idk for now{op}
            
        }

        private void _equals_Click(object sender, EventArgs e)
        {
            double result;
            //eq = false;
            if (eq == true)
            {
                Num2 = Convert.ToDouble(label1.Text);
                eq = false;
            }
            
            


            //Operation
            if (label2.Text.Contains("+") == true)
            {
                result = Convert.ToDouble(Num1) + Convert.ToDouble(Num2);
                label1.Text = result.ToString();
                label2.Text = label1.Text + " " + Operator + Num1.ToString();
            }
            else if (label2.Text.Contains("-") == true)
            {
                result = Convert.ToDouble(Num1) - Convert.ToDouble(Num2);
                label1.Text = result.ToString();
                label2.Text = label1.Text + " " + Operator + Num1.ToString();
            }

            


            op = false;
        }

        private void _clearEntry_Click(object sender, EventArgs e)
        {
            
            label2.Text = Num1.ToString();
            label1.Text = "0";
        }
    }
}
