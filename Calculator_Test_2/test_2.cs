using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Test_2
{
    public partial class Form1 : Form
    {
        bool optr_clicked, num_clicked, equal_clicked = false;
        double first_num, second_num;
        char optr_selected;

        public Form1()
        {
            InitializeComponent();
        }
        private void _decimal_Click(object sender, EventArgs e)
        {
            if (!label1.Text.Contains("."))
            {
                label1.Text = label1.Text.Insert(label1.Text.Length, ".");
            }
        } //running
        private void _Sign_Click(object sender, EventArgs e)
        {
            if (label1.Text.Contains("-"))
            {
                label1.Text = label1.Text.Trim('-');
            }
            else
            {
                label1.Text = label1.Text.Insert(0, "-");
            }
        } //running

        private void _clearEntry_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
        } //running

        private void _clearAll_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            label1.Text = "0";
            test_label.Text = "";
            optr_clicked = false;
            equal_clicked = false;
            num_clicked = false;
        } //running

        private void _backspace_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length == 1)
            {
                label1.Text = "0";
            }
            else
            {
                label1.Text = label1.Text.Remove(label1.Text.Length - 1);
            }

        } //running
        private void num_click(object sender, EventArgs e)
        {
            Button nums = (Button)sender;
            if (optr_clicked) //i separate it will not work if i put it here both as optr needs to be click to run  
            { 
                label1.Text = nums.Text;
                optr_clicked = false;
                equal_clicked = false;
                num_clicked = true;
                
            }
            else if (equal_clicked)
            {
                label2.Text = "";
                label1.Text = nums.Text;
                optr_clicked = false;
                equal_clicked = false;
                num_clicked = true;
            }
            else if (label1.Text == "0")
            {
                label1.Text = nums.Text;
                test_label.Text = label2.Text.Substring(0, label2.Text.Length);
            }
            else
            {
                label1.Text = label1.Text + nums.Text;
            }

        }//running

        private void Operator(object sender, EventArgs e)
        {
            Button optr = (Button)sender;

            string[] optr_check = { "+", "-", "x", "÷" };

            if (optr_check.Any(label2.Text.Contains) && num_clicked)
            {
                
                first_num = Convert.ToDouble(label2.Text.Substring(0, label2.Text.Length - 1)); //change first second num add num1 num 2
                second_num = Convert.ToDouble(label1.Text);
                optr_selected = Convert.ToChar(label2.Text.Substring(first_num.ToString().Length + 1, 1)); //cannot find if there is second number (equals button)
                test_label.Text = first_num.ToString();
                test_label2.Text = label1.Text;

                switch (optr_selected)  
                {
                    case '+':
                        double optr_answer = first_num + second_num;
                        label2.Text = optr_answer.ToString() + " " + optr.Text;
                        label1.Text = optr_answer.ToString();
                        break;
                    case '-':
                        optr_answer = first_num - second_num;

                        label2.Text = optr_answer.ToString() + " " + optr.Text;
                        label1.Text = optr_answer.ToString();
                        break;
                    case 'x':
                        optr_answer = first_num * second_num;
                        label2.Text = optr_answer.ToString() + " " + optr.Text;
                        label1.Text = optr_answer.ToString();
                        break;
                    case '÷':
                        optr_answer = first_num / second_num;
                        label2.Text = optr_answer.ToString() + " " + optr.Text;
                        label1.Text = optr_answer.ToString();
                        break;
                }
               num_clicked = false;
            }
            else
            {   
                label2.Text = Convert.ToDouble(label1.Text) + " " + optr.Text;
                test_label.Text = label2.Text;
            }
            optr_clicked = true;
        }//running, can now use operators

        private void _equals_Click(object sender, EventArgs e) 
        {
            if (equal_clicked)
            {
                optr_selected = Convert.ToChar(label2.Text.Substring(label2.Text.Length - (second_num.ToString().Length + 2), 1));
                first_num = Convert.ToDouble(label1.Text);

                switch (optr_selected) //some adjustments needed to switch places so label 1 and label 2 is not the same value
                {
                    case '+':
                        label2.Text = first_num.ToString() + " + " + second_num.ToString();
                        var optr_answer = first_num + second_num;
                        label1.Text = optr_answer.ToString();
                        break;
                    case '-':
                        label2.Text = first_num.ToString() + " - " + second_num.ToString();
                        optr_answer = first_num - second_num;
                        label1.Text = optr_answer.ToString();
                        break;
                    case 'x':
                        label2.Text = first_num.ToString() + " x " + second_num.ToString();
                        optr_answer = first_num * second_num;
                        label1.Text = optr_answer.ToString();
                        break;
                    case '÷':
                        label2.Text = first_num.ToString() + " ÷ " + second_num.ToString();
                        optr_answer = first_num / second_num;
                        label1.Text = optr_answer.ToString();
                        break;
                }//need to improve later for other operations(%,1/x,sqrroot,x^2)


            }
            else if (num_clicked)//just copy and pasted it (must not copy and paste, fix this) use function 
            {
                try
                {
                    first_num = Convert.ToDouble(label2.Text.Substring(0, label2.Text.Length - 1)); //change first second num add num1 num 2
                    second_num = Convert.ToDouble(label1.Text);


                    optr_selected = Convert.ToChar(label2.Text.Substring(first_num.ToString().Length + 1, 1)); //cannot find if there is second number (equals button)
                    test_label.Text = first_num.ToString();
                    test_label2.Text = label1.Text;

                    switch (optr_selected)
                    {
                        case '+':
                            var optr_answer = first_num + second_num;
                            label2.Text = first_num.ToString() + " + " + second_num.ToString();
                            label1.Text = optr_answer.ToString();
                            break;
                        case '-':
                            optr_answer = first_num - second_num;

                            label2.Text = first_num.ToString() + " - " + second_num.ToString();
                            label1.Text = optr_answer.ToString();
                            break;
                        case 'x':
                            optr_answer = first_num * second_num;
                            label2.Text = first_num.ToString() + " x " + second_num.ToString();
                            label1.Text = optr_answer.ToString();
                            break;
                        case '÷':
                            optr_answer = first_num / second_num;
                            label2.Text = first_num.ToString() + " ÷ " + second_num.ToString();
                            label1.Text = optr_answer.ToString();
                            break;
                    }
                    equal_clicked = true;
                    num_clicked = false;
                }
                catch
                {
                    label2.Text = label1.Text;
                }
            }
            
        } //running (repetitive, need to replace with function/method)
        private void test_2_Load(object sender, EventArgs e)
        {
        }
    }
}


