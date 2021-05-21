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
        bool optr_clicked, num_clicked, equal_clicked, symbols_clicked, reciprocal_clicked, percent_clicked = false; //can merge reciprocal and symbol
        double first_num, second_num, symbol_base;
        byte char_symbols = 0;
        char optr_selected;

        string[] optr_check = { "+", "-", "x", "÷" };

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
            test_label2.Text = "";
            optr_clicked = false;
            equal_clicked = false;
            num_clicked = false;
            reciprocal_clicked = false;
            symbols_clicked = false;
            char_symbols = 0;

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

        private void _reciprocal_Click(object sender, EventArgs e)
        {
            var reciprocal = 1 / Convert.ToDouble(label1.Text);
            label1.Text = reciprocal.ToString();
            reciprocal_clicked = true;
        }//running

        private void _sqr_Click(object sender, EventArgs e)
        {
            var sqr_char = "sqr( ";

            if (symbols_clicked)
            {
                //to display 
                test_label2.Text = label2.Text.Length.ToString();

                var minus_symbol = symbol_base.ToString().Length + (char_symbols);
                label2.Text = label2.Text.Insert(label2.Text.Length - minus_symbol, sqr_char);
                label2.Text = label2.Text.Insert(label2.Text.Length, " )");

                //to display 
                test_label.Text = (minus_symbol).ToString();
            }
            else
            {
                symbol_base = Convert.ToDouble(label1.Text);
                var sqr_name = sqr_char + symbol_base.ToString() + " )"; 
                label2.Text = label2.Text.Insert(label2.Text.Length, sqr_name);

                //to display
                test_label.Text = label2.Text;
                test_label2.Text = label2.Text.Length.ToString();
                symbols_clicked = true;  // when clicked
            }

            char_symbols += 7;
            var sqr = Math.Pow(Convert.ToDouble(label1.Text), 2);
            label1.Text = sqr.ToString();
            //(symbol_base.Length + (7 * sqr_name_clicked)


        }//running
        private void _sqrroot_Click(object sender, EventArgs e)
        {
            var sqr_root = "√( ";

            if (symbols_clicked)
            {
                var minus_symbol = symbol_base.ToString().Length + (char_symbols);
                label2.Text = label2.Text.Insert(label2.Text.Length - minus_symbol, sqr_root);
                label2.Text = label2.Text.Insert(label2.Text.Length, " )");
            }
            else
            {
                symbol_base = Convert.ToDouble(label1.Text);
                var sqr_name = sqr_root + symbol_base.ToString() + " )"; //added space for proper format (ex. 10 +sqr => 10 + sqr) 
                label2.Text = label2.Text.Insert(label2.Text.Length, sqr_name);
                symbols_clicked = true;  // when clicked

                //to display
                test_label.Text = label2.Text;
                test_label2.Text = label2.Text.Length.ToString();
            }
            char_symbols += 5;
            var sqr = Math.Sqrt(Convert.ToDouble(label1.Text));
            label1.Text = sqr.ToString();
        } //running
        private void _percent_Click(object sender, EventArgs e)
        {
            if (optr_check.Any(label2.Text.Contains))
            {
                var percent = first_num * (Convert.ToDouble(label1.Text) / 100);
                label1.Text = percent.ToString();
                optr_selected = Convert.ToChar(label2.Text.Substring(first_num.ToString().Length + 1, 1));
                label2.Text = first_num.ToString() + " " + optr_selected.ToString() + " " + percent.ToString();
            }
            else
            {
                label1.Text = "0";
            }
            percent_clicked = true; 
        }//running

        private void num_click(object sender, EventArgs e)
        {
            Button nums = (Button)sender;
            if (optr_clicked) //I separate it, will not work if i put it here both as optr needs to be click to run  
            {
                label1.Text = nums.Text;
                optr_clicked = false;
                equal_clicked = false;
                num_clicked = true;

            }
            else if (equal_clicked || symbols_clicked || reciprocal_clicked || percent_clicked)
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
            symbols_clicked = false;
            reciprocal_clicked = false;
            percent_clicked = false;
            char_symbols = 0;
            
        }//running

        private void Operator(object sender, EventArgs e)
        {
            Button optr = (Button)sender;

            if (optr_check.Any(label2.Text.Contains) && num_clicked || symbols_clicked || percent_clicked)
            {
                second_num = Convert.ToDouble(label1.Text);

                //test diplay
                test_label.Text = first_num.ToString();
                test_label2.Text = label1.Text;

                //solving using function/method
                var ans = solve(first_num, second_num);
                label1.Text = ans.ToString();
                label2.Text = ans.ToString() + " " + optr.Text;

                num_clicked = false; // to not increment by itself

                first_num = Convert.ToDouble(label1.Text);
            }
            else
            {
                label2.Text = Convert.ToDouble(label1.Text) + " " + optr.Text;
                first_num = Convert.ToDouble(label1.Text);
                
                //test display
                test_label.Text = label2.Text;
            }

            //button reset
            symbols_clicked = false;
            reciprocal_clicked = false;
            percent_clicked = false;
            char_symbols = 0;
            equal_clicked = false; //need to put if clicking equals without clicking a number (operator clicked only)
            optr_clicked = true;
        }//running

        private void _equals_Click(object sender, EventArgs e)
        {
            try
            {
                if (equal_clicked && optr_check.Any(label2.Text.Contains)) // if equals button clicked once // if num clicked: else will run
                {
                    first_num = Convert.ToDouble(label1.Text);
                    label2.Text = first_num.ToString() + " " + optr_selected.ToString() + " " + second_num.ToString();

                    var ans = solve(first_num, second_num);
                    label1.Text = ans.ToString();

                    //test display
                    test_label.Text = optr_selected.ToString();
                }
                else  //if equals button clicked for first time
                {
                    //constant
                    second_num = Convert.ToDouble(label1.Text);

                    var ans = solve(first_num, second_num);
                    label1.Text = ans.ToString();
                    label2.Text = first_num.ToString() + " " + optr_selected.ToString() + " " + second_num.ToString();

                    equal_clicked = true;
                    num_clicked = false; // to not increment if operator is clicked after equals button is clicked again

                    //test display
                    test_label.Text =  first_num.ToString();
                    test_label2.Text = second_num.ToString();
                }       
            }
            catch
            {
                label2.Text = "";// label1.Text;
                equal_clicked = true;
            }
            //button reset
            symbols_clicked = false;
            reciprocal_clicked = false;
            percent_clicked = false;
            char_symbols = 0;
        } //running 

        private double solve(double first, double second)
        {
            double the_solve = 0;
            
            optr_selected = Convert.ToChar(label2.Text.Substring(first_num.ToString().Length + 1 , 1));

            switch (optr_selected)
            {
                case '+':
                    the_solve = first + second;
                    label2.Text = first_num.ToString() + " + " + second_num.ToString();
                    break;
                case '-':
                    the_solve = first - second;
                    label2.Text = first_num.ToString() + " - " + second_num.ToString();
                    break;
                case 'x':
                    the_solve = first * second;
                    label2.Text = first_num.ToString() + " x " + second_num.ToString(); 
                    break;
                case '÷':
                    the_solve = first / second;
                    label2.Text = first_num.ToString() + " ÷ " + second_num.ToString();
                    break;
            }
            return the_solve;
       
      
        }//running
        private void test_2_Load(object sender, EventArgs e)
        {
        }
    }
}
