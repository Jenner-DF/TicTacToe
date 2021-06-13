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
        bool optr_clicked, num_clicked, equal_clicked, symbols_clicked, percent_clicked, error_clicked = false; //can merge reciprocal and symbol
        double first_num, second_num, symbol_base;
        byte char_symbols = 0;
        char optr_selected;

        string[] optr_check = { "+", "-", "x", "÷" };

        public Form1()
        {
            InitializeComponent();
        }
        private void error_enable_but()
        {
            foreach (Button a in but_group1.Controls)
            {
                if (a.Name.Substring(0, 1) == "_")
                {
                    if (a.Name == "_Sign" || a.Name == "_decimal")
                    {
                        a.BackColor = Color.FromArgb(242, 242, 242);
                    }
                    else
                    {
                        a.BackColor = Color.FromArgb(229, 229, 229);
                    }
                    a.Enabled = true;
                }
            }

        } //running
        private void _decimal_Click(object sender, EventArgs e)
        {
            if (!display_1.Text.Contains("."))
            {
                display_1.Text = display_1.Text.Insert(display_1.Text.Length, ".");
            }
        } //running
        private void _Sign_Click(object sender, EventArgs e)
        {
            if (display_1.Text.Contains("-"))
            {
                display_1.Text = display_1.Text.Trim('-');
            }
            else
            {
                display_1.Text = display_1.Text.Insert(0, "-");
            }
        } //running
        private void _clearEntry_Click(object sender, EventArgs e)
        {
            if (error_clicked)
            {
                error_enable_but();
            }
            display_1.Text = "0";
        } //running

        private void _clearAll_Click(object sender, EventArgs e)
        {
            if (error_clicked)
            {
                error_enable_but();
            }
            display_2.Text = "";
            display_1.Text = "0";
            test_label.Text = "";
            test_label2.Text = "";
            optr_clicked = false;
            equal_clicked = false;
            num_clicked = false;
            symbols_clicked = false;
            char_symbols = 0;

        } //running

        private void _backspace_Click(object sender, EventArgs e)
        {
            if (error_clicked)
            {
                error_enable_but();
            }
            if (display_1.Text.Length == 1)
            {
                display_1.Text = "0";
            }
            else
            {
                display_1.Text = display_1.Text.Remove(display_1.Text.Length - 1);
            }

        } //running

        private void _reciprocal_Click(object sender, EventArgs e)
        {
            var reciprocal_char = "1/( ";

            //adding characters to label 2
            if (symbols_clicked)
            {
                //to display 
                test_label2.Text = display_2.Text.Length.ToString();

                var minus_symbol = symbol_base.ToString().Length + (char_symbols);
                display_2.Text = display_2.Text.Insert(display_2.Text.Length - minus_symbol, reciprocal_char);
                display_2.Text = display_2.Text.Insert(display_2.Text.Length, " )");

                //to display 
                test_label.Text = (minus_symbol).ToString();
            }
            else
            {
                if (equal_clicked) { display_2.Text = ""; }

                symbol_base = Convert.ToDouble(display_1.Text);
                var reciprocal_name = reciprocal_char + symbol_base.ToString() + " )";
                display_2.Text = display_2.Text.Insert(display_2.Text.Length, reciprocal_name);

                //to display
                test_label.Text = display_2.Text;
                test_label2.Text = display_2.Text.Length.ToString();
                symbols_clicked = true;  // when clicked
            }

            char_symbols += 6;
            //solving
            display_1.Text = per_rec_sqr_rt('/');

        }//running

        private void _sqr_Click(object sender, EventArgs e)
        {
            var sqr_char = "sqr( ";

            if (symbols_clicked)
            {
                //to display 
                test_label2.Text = display_2.Text.Length.ToString();

                var minus_symbol = symbol_base.ToString().Length + (char_symbols);
                display_2.Text = display_2.Text.Insert(display_2.Text.Length - minus_symbol, sqr_char);
                display_2.Text = display_2.Text.Insert(display_2.Text.Length, " )");

                //to display 
                test_label.Text = (minus_symbol).ToString();
            }
            else
            {
                if (equal_clicked) { display_2.Text = ""; }

                symbol_base = Convert.ToDouble(display_1.Text);
                var sqr_name = sqr_char + symbol_base.ToString() + " )";
                display_2.Text = display_2.Text.Insert(display_2.Text.Length, sqr_name);

                //to display
                test_label.Text = display_2.Text;
                test_label2.Text = display_2.Text.Length.ToString();
                symbols_clicked = true;  // when clicked
            }
            char_symbols += 7;
            display_1.Text = per_rec_sqr_rt('^');
        }//running
        private void _sqrroot_Click(object sender, EventArgs e)
        {
            var sqr_root = "√( ";

            if (symbols_clicked)
            {
                var minus_symbol = symbol_base.ToString().Length + (char_symbols);
                display_2.Text = display_2.Text.Insert(display_2.Text.Length - minus_symbol, sqr_root);
                display_2.Text = display_2.Text.Insert(display_2.Text.Length, " )");
            }
            else
            {
                if (equal_clicked) { display_2.Text = ""; }

                symbol_base = Convert.ToDouble(display_1.Text);
                var sqr_name = sqr_root + symbol_base.ToString() + " )"; //added space for proper format (ex. 10 +sqr => 10 + sqr) 
                display_2.Text = display_2.Text.Insert(display_2.Text.Length, sqr_name);
                symbols_clicked = true;  // when clicked

                //to display
                test_label.Text = display_2.Text;
                test_label2.Text = display_2.Text.Length.ToString();
            }
            char_symbols += 5;
            display_1.Text = per_rec_sqr_rt('v');
        } //running
        private void _percent_Click(object sender, EventArgs e)
        {
            if (optr_check.Any(display_2.Text.Contains))
            {
                display_1.Text = per_rec_sqr_rt('%');
                optr_selected = Convert.ToChar(display_2.Text.Substring(first_num.ToString().Length + 1, 1));
                display_2.Text = first_num.ToString() + " " + optr_selected.ToString() + " " + display_1.Text;
            }
            else
            {
                display_1.Text = "0";
            }
            percent_clicked = true;
        }//running
        private string per_rec_sqr_rt(char select)
        {
            double get = 0;
            var base_num = display_1.Text;
            switch (select)
            {
                case '%':
                    get = first_num * (Convert.ToDouble(base_num) / 100);
                    break;
                case '/':
                    get = 1 / Convert.ToDouble(base_num);
                    break;
                case '^':
                    get = Math.Pow(Convert.ToDouble(base_num), 2);
                    break;
                case 'v':
                    get = Math.Sqrt(Convert.ToDouble(display_1.Text));
                    break;
            }
            return error_return(get);
        }

        private void num_click(object sender, EventArgs e)
        {
            Button nums = (Button)sender;
            if (error_clicked)
            {
                error_enable_but();
            }

            if (optr_clicked) //I separate it, will not work if i put it here both as optr needs to be click to run  
            {
                display_1.Text = nums.Text;
                optr_clicked = false;
                equal_clicked = false;
                num_clicked = true;

            }
            else if (equal_clicked || symbols_clicked || percent_clicked)
            {
                display_2.Text = "";
                display_1.Text = nums.Text;
                optr_clicked = false;
                equal_clicked = false;
                num_clicked = true;
            }
            else if (display_1.Text == "0" || display_1.Text == "-0")
            {
                display_1.Text = nums.Text;
                test_label.Text = display_2.Text.Substring(0, display_2.Text.Length);
            }
            else
            {
                display_1.Text = display_1.Text + nums.Text;

            }
            symbols_clicked = false;
            percent_clicked = false;
            char_symbols = 0;
            
        }//running

        private void Operator(object sender, EventArgs e)
        {
            Button optr = (Button)sender;

            if (optr_check.Any(display_2.Text.Contains) && num_clicked )//|| symbols_clicked || percent_clicked) 
            {
                second_num = Convert.ToDouble(display_1.Text);

                //test diplay
                test_label.Text = first_num.ToString();
                test_label2.Text = display_1.Text;

                //solving using function/method
                var ans = solve(first_num, second_num);
                display_1.Text = ans;
                display_2.Text = ans + " " + optr.Text;

                num_clicked = false; // to not increment by itself

                first_num = Convert.ToDouble(display_1.Text);
            }
            else
            {
                display_2.Text = Convert.ToDouble(display_1.Text) + " " + optr.Text;
                first_num = Convert.ToDouble(display_1.Text);
                
                //test display
                test_label.Text = display_2.Text;
            }

            //button reset
            symbols_clicked = false;
            percent_clicked = false;
            char_symbols = 0;
            equal_clicked = false; //need to put if clicking equals without clicking a number (operator clicked only)
            optr_clicked = true;
        }//running

        private void _equals_Click(object sender, EventArgs e)
        {
            if (error_clicked)
            {
                error_enable_but();
            }
            try
            {
                if (!optr_check.Any(display_2.Text.Contains))
                {
                    if (display_1.Text == "Invalid input")
                    {
                        display_1.Text = "0";
                    }
                    else
                    {
                        display_2.Text = display_1.Text + " =";
                    }
                }
                else if (equal_clicked && optr_check.Any(display_2.Text.Contains)) // if equals button clicked once // if num clicked: else will run
                {
                    first_num = Convert.ToDouble(display_1.Text);
                    display_2.Text = first_num.ToString() + " " + optr_selected.ToString() + " " + second_num.ToString();

                    if (display_1.Text == "Invalid input")
                    {
                        display_1.Text = "0";
                    }
                    else
                    {
                        var ans = solve(first_num, second_num);
                        display_1.Text = ans;
                    }

                    //test display
                    test_label.Text = optr_selected.ToString();
                }
                else  //if equals button clicked for first time
                {
                    //constant
                    second_num = Convert.ToDouble(display_1.Text);

                    //error check
                    var ans = solve(first_num, second_num);
                    display_1.Text = ans;
                    display_2.Text = first_num.ToString() + " " + optr_selected.ToString() + " " + second_num.ToString();

                    //equal_clicked = true;
                    num_clicked = false; // to not increment if operator is clicked after equals button is clicked again

                    //test display
                    test_label.Text = first_num.ToString();
                    test_label2.Text = second_num.ToString();
                }       
            }
            catch
            {
                display_2.Text = "";
                equal_clicked = true;
            }
            //button reset
            equal_clicked = true;
            symbols_clicked = false;
            percent_clicked = false;
            char_symbols = 0;
        } //running 
        private string solve(double first, double second)
        {
            double the_solve = 0;

            optr_selected = Convert.ToChar(display_2.Text.Substring(first_num.ToString().Length + 1, 1));

            switch (optr_selected)
            {
                case '+':
                    the_solve = first + second;
                    display_2.Text = first_num.ToString() + " + " + second_num.ToString();
                    break;
                case '-':
                    the_solve = first - second;
                    display_2.Text = first_num.ToString() + " - " + second_num.ToString();
                    break;
                case 'x':
                    the_solve = first * second;
                    display_2.Text = first_num.ToString() + " x " + second_num.ToString();
                    break;
                case '÷':
                    the_solve = first / second;
                    display_2.Text = first_num.ToString() + " ÷ " + second_num.ToString();
                    break;
            }
            return error_return(the_solve);
        }//running
        private string error_return(double error)
        {
            if (double.IsNaN(error) || double.IsInfinity(error))
            {
                foreach (Button a in but_group1.Controls)
                {
                    if (a.Name.Substring(0,1) == "_")
                    {
                        a.BackColor = Color.FromKnownColor(KnownColor.Silver);
                        a.Enabled = false;
                    } 
                }
                error_clicked = true;
                string error_1 = "Invalid input";
                return error_1;
            }
            else { return error.ToString(); }
        }//running

        private void _mc_Click(object sender, EventArgs e)
        {

        }

        private void _mr_Click(object sender, EventArgs e)
        {

        }

        private void _mplus_Click(object sender, EventArgs e)
        {
            
        }

        private void _mminus_Click(object sender, EventArgs e)
        {

        }

        private void _mstore_Click(object sender, EventArgs e)
        {

        }

        private void _mlist_Click(object sender, EventArgs e)
        {

        }

        private void test_2_Load(object sender, EventArgs e)
        {
        }
    }
}
