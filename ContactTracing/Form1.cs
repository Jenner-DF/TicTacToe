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
        DateTime limit = new DateTime(1899, 12, 31);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control box in panel1.Controls)
            {
                var comb = "label" + box.Name.ToString().Substring(4);
                if (box.Name.Substring(0, 5) == "text_")
                {   //text check
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
                    //combobox check
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
                    //radiobutton check
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
                    //datetime check
                    if (box.Name.Substring(0,5) == "date_")
                    {

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

        }
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
