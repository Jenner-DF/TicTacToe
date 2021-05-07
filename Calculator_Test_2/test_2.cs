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
    public partial class test_label2 : Form
    {
        bool optr, clicked = false;
        public test_label2()
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
        } //running

        private void _backspace_Click(object sender, EventArgs e)
        {
            try { label1.Text = label1.Text.Remove(label1.Text.Length - 1); }
            catch { }
        } //running

        private void sass(object sender, EventArgs e)
        {
            Button nums = (Button)sender;
            if (label1.Text == "0")
            {  
                label1.Text = nums.Text;
                test_label.Text = label2.Text.Substring(0, label2.Text.Length);
            }
            else
            {
                label1.Text = label1.Text + nums.Text;
            }
            //need to seperate, if not = "bug selecting 0" 
            if (optr == true)
            {
                label1.Text = nums.Text;
                optr = false;
                clicked = true;
            }
        }//if else statement lacking
        private void Operator(object sender, EventArgs e)
        {
            Button op = (Button)sender;

            string[] opcheck = { "+", "-", "x", "÷" };

            if (opcheck.Any(label2.Text.Contains) && clicked)
            {
                var som = label2.Text.Substring(label2.Text.Length - 1);
                var mos = label2.Text.Substring(0, label2.Text.Length - 1);
                test_label.Text = mos;
                label3.Text = label1.Text;
                switch (som.ToString())
                {
                    case "+":
                        double b = Convert.ToDouble(mos) + Convert.ToDouble(label1.Text);
                        label2.Text = b.ToString() + " " + op.Text;
                        label1.Text = b.ToString();
                        break;

                    case "-":
                        b = (Convert.ToDouble(mos)) - (Convert.ToDouble(label1.Text));

                        label2.Text = b.ToString() + " " + op.Text;
                        label1.Text = b.ToString();
                        break;
                    case "x":
                        b = Convert.ToDouble(mos) * Convert.ToDouble(label1.Text);
                        label2.Text = b.ToString() + " " + op.Text;
                        label1.Text = b.ToString();
                        break;
                    case "÷":
                        b = Convert.ToDouble(mos) / Convert.ToDouble(label1.Text);
                        label2.Text = b.ToString() + " " + op.Text;
                        label1.Text = b.ToString();
                        break;
                }
                clicked = false;
            }
            else
            {
                label2.Text = Convert.ToDouble(label1.Text) + " " + op.Text;
                test_label.Text = label2.Text;
            }
            optr = true;
        }//can now use operators
        private void test_2_Load(object sender, EventArgs e)
        {
        }
    }   
}
