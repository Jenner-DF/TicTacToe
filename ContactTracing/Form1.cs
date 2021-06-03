using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactTracing
{
    public partial class Form1 : Form
    {
        bool check_all = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            check_all = true;
            foreach (Control box in panel1.Controls)
            {
                var comb = "label" + box.Name.ToString().Substring(4);
                //text check
                if (box.Name.Substring(0, 5) == "text_")
                {
                    if (box.Name == "text_mobnum")
                    {
                        if (!box.Text.All(char.IsDigit) || box.Text == "")
                        {
                            Controls.Find(comb, true)[0].Text = "•Invalid input";
                            check_all = false;
                        }
                        else
                        {
                            Controls.Find(comb, true)[0].Text = "Corek";
                            
                        }
                    }
                    else if (box.Name == "text_addr")
                    {
                        if (box.Text == "")
                        {
                            Controls.Find(comb, true)[0].Text = "•Invalid input";
                            check_all = false;
                        }
                        else
                        {
                            Controls.Find(comb, true)[0].Text = "Corek";
                        }
                    }
                    else if (box.Text.All(char.IsDigit) || box.Text == "")
                    {
                        Controls.Find(comb, true)[0].Text = "•Invalid input";
                        check_all = false;
                    }
                    else
                    {
                        Controls.Find(comb, true)[0].Text = "Corek";
                    }
                }
                //combobox check
                if (box.Name.Substring(0, 5) == "cobx_")
                {
                    ComboBox box2 = box as ComboBox;
                    if (box2.SelectedIndex < 0)
                    {
                        Controls.Find(comb, true)[0].Text = "•Invalid input";
                        check_all = false;
                    }
                    else
                    {
                        Controls.Find(comb, true)[0].Text = "Corek";
                    }
                }
                //radiobutton check
                if (box.Name.Substring(0, 5) == "rdio_")
                {
                    if (!(rdio_female.Checked || rdio_male.Checked))
                    {
                        label_sex.Text = "Invalid input";
                        check_all = false;
                    }
                    else
                    {
                        label_sex.Text = "corek";
                    }
                }
                //datetime check
                if (box.Name.Substring(0, 5) == "date_")
                {
                    DateTime limit = new DateTime(1899, 12, 31);
                    if (date_birth.Value > DateTime.Today || date_birth.Value <= limit)
                    {
                        label_birth.Text = "Invalid Input";
                        check_all = false;
                    }
                    else
                    {
                        label_birth.Text = "Corek";
                    }
                }
            }
            if (check_all)
            {
                if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    label1.Text = label1.Text + text_Fname.Text + "\n";
                    label1.Text = label1.Text + text_Mname.Text + "\n";
                    label1.Text = label1.Text + text_Lname.Text + "\n";
                    label1.Text = label1.Text + cobx_Cstatus.Text + "\n";
                    label1.Text = label1.Text + Getrad() + "\n";
                    label1.Text = label1.Text + date_birth.Text + "\n";
                    label1.Text = label1.Text + cobx_brgy.Text + "\n";
                    label1.Text = label1.Text + txt_city.Text + "\n";
                    label1.Text = label1.Text + text_addr.Text + "\n";
                    label1.Text = label1.Text + text_mobnum.Text + "\n";
                }
              
            }
            else
            {
                MessageBox.Show("Invalid input/s", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//submit button
        private string Getrad()
        {  
            if (rdio_male.Checked)
            {
                return rdio_male.Text;
            }
            else
            {
                return rdio_female.Text;
            }
        }//get radio buttion value
        private void Checking(object sender, EventArgs e)
        {
            TextBox box = sender as TextBox;

            var comb = "label" + box.Name.ToString().Substring(4);
            if (box.Name == "text_mobnum")
            {
                if (!box.Text.All(char.IsDigit) || box.Text == "")
                {
                    Controls.Find(comb, true)[0].Text = "•Invalid input";
                }
                else
                {
                    Controls.Find(comb, true)[0].Text = "Corek";
                }
            }
            else if (box.Name == "text_addr")
            {
                if (box.Text == "")
                {
                    Controls.Find(comb, true)[0].Text = "•Invalid input";
                }
                else
                {
                    Controls.Find(comb, true)[0].Text = "Corek";
                }
            }
            else if (!box.Text.All(char.IsLetter) || box.Text == "")
            {
                Controls.Find(comb, true)[0].Text = "•Invalid input";
            }
            else
            {
                Controls.Find(comb, true)[0].Text = "Corek";
            }
        }//text check
        private void Checking2(object sender, EventArgs e)
        {
            ComboBox box = sender as ComboBox;

            var comb = "label" + box.Name.ToString().Substring(4);
            if (box.Name.Substring(0, 5) == "cobx_")
            {
                ComboBox box2 = box as ComboBox;
                if (box2.SelectedIndex < 0)
                {
                    Controls.Find(comb, true)[0].Text = "•Invalid input";
                }
                else
                {
                    Controls.Find(comb, true)[0].Text = "Corek";
                }
            }
        }//combobox check
        private void checking3(object sender, EventArgs e)//radiobutton check
        {
            RadioButton box = sender as RadioButton;

            var comb = "label" + box.Name.ToString().Substring(4);
            if (box.Name.Substring(0, 5) == "rdio_")
            {
                if (!(rdio_female.Checked || rdio_male.Checked))
                {
                    label_sex.Text = "Invalid input";
                }
                else
                {
                    label_sex.Text = "corek";
                }
            }
        }
        private void Checking4(object sender, EventArgs e)//datetime check
        {
            DateTime limit = new DateTime(1899, 12, 31);
            if (date_birth.Value > DateTime.Today || date_birth.Value <= limit)
            {
                label_birth.Text = "Invalid Input";
            }
            else
            {
                label_birth.Text = "Corek";
            }
        }
    }
}
