using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactTracing
{
    public partial class Form1 : Form
    {
        bool check_all, check_empty = false;
        int person_count = 0;
        string[] data = new string[11];
        readonly Image pic_check = Image.FromFile("green_circle.png");
        readonly Image pic_wrong = Image.FromFile("red_x.png");
        public Form1()
        {
            InitializeComponent();
        }
        private void Submit_Click(object sender, EventArgs e)
        {
            check_all = true;
            foreach (Control box in panel1.Controls)
            {
                //text check
                if (box.Name.Substring(0, 5) == "text_")
                {
                    Check_text(box);
                    if (check_empty) { check_all = false; }
                }
                //combobox check
                if (box.Name.Substring(0, 5) == "cobx_")
                {
                    Check_combox(box);
                    if (check_empty) { check_all = false; }
                }
                //radiobutton check
                if (box.Name.Substring(0, 5) == "rdio_")
                {
                    Check_radio();
                    if (check_empty) { check_all = false; }
                }
                //datetime check
                if (box.Name.Substring(0, 5) == "date_")
                {
                    Check_datetime();
                    if (check_empty) { check_all = false; }
                }
            }
            if (check_all)
            {
                if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    person_count++;
                    data = new string[11]{"Person " + person_count.ToString(), text_Lname.Text.ToUpper(),text_Fname.Text, text_Mname.Text, cobx_Cstatus.Text,
                                          Getrad(), date_birth.Text, cobx_brgy.Text, txt_city.Text, text_addr.Text, "+63"+text_mobnum.Text};
                    StreamWriter outputFile = new StreamWriter(@"Contact List.txt", true);
                    //copytotheFile
                    foreach (string i in data) { outputFile.WriteLine(i); }
                    //whitespace at end
                    outputFile.WriteLine();
                    outputFile.Close();
                    But_cancel_Click(null, null);
                }
            }
            else
            {
                MessageBox.Show("Invalid input/s", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Check_text(object sender, EventArgs e = null)
        {
            Control box = sender as Control;
            var comb = "label" + box.Name.ToString().Substring(4);
            if (box.Name == "text_mobnum")
            {
                if (box.Text.All(char.IsDigit) || box.Text == "")
                {
                    check_empty = true;
                    Controls.Find(comb, true)[0].BackgroundImage = pic_wrong;
                }
            }
            else if (box.Text == "")
            {
                check_empty = true;
                Controls.Find(comb, true)[0].BackgroundImage = pic_wrong;
            } 
            else
            {
                Controls.Find(comb, true)[0].BackgroundImage = pic_check;
            }

            /* if (Check_text2(box))
             {
                 Controls.Find(comb, true)[0].BackgroundImage = pic_check;
             }
             else
             {
                 Controls.Find(comb, true)[0].BackgroundImage = pic_wrong;
             }*/

        }//textbox check
       /* private bool Check_text2(Control box)
        {
            bool check = true;
            if (box.Name == "text_mobnum")
            {
                if (!box.Text.All(char.IsDigit) || box.Text == "")
                {
                    check = false;
                }
            }
            else if (box.Text == "")
            {
                check = false;
            }
            return check;
        }*/
        private void Check_combox(object sender, EventArgs e = null)
        {
            ComboBox box = sender as ComboBox;
            var comb = "label" + box.Name.ToString().Substring(4);
            if (box.SelectedIndex < 0)
            {
                check_empty = true;
                Controls.Find(comb, true)[0].BackgroundImage = pic_wrong;
            }
            else
            {
                Controls.Find(comb, true)[0].BackgroundImage = pic_check;
            }
            /* if (Check_combox2(box))
             {
                 Controls.Find(comb, true)[0].BackgroundImage = pic_check;
             }
             else
             {
                 Controls.Find(comb, true)[0].BackgroundImage = pic_wrong;
             }*/
        }//combobox check
        /*private bool Check_combox2(Control box)
        {
            bool check = true;

            ComboBox box2 = box as ComboBox;
            if (box2.SelectedIndex < 0)
            {
                check = false;
            }
            return check;
        }*/
        private void Check_radio(object sender=null, EventArgs e=null)
        {
            if (!(rdio_female.Checked || rdio_male.Checked))
            {
                label_sex.Image = pic_wrong;
                check_empty = true;
            }
            else
            {
                label_sex.Image = pic_check;
            }

        }//radiobutton check
        private void Check_datetime(object sender=null, EventArgs e=null)
        {
            DateTime limit = new DateTime(1899, 12, 31);
            if (date_birth.Value > DateTime.Today || date_birth.Value <= limit)
            {
                label_birth.Image = pic_wrong;
                check_empty = true;
            }
            else
            {
                label_birth.Image = pic_check;
            }
        }//datetime check
        private void But_read_Click(object sender, EventArgs e)
        {
            if (text_data.Visible) { Text_data_Leave(null, null); }
            else
            {
                Form1.ActiveForm.Width = 698;
                text_data.Visible = true;
                but_cleardata.Visible = true;
                StreamReader read = new StreamReader("Contact List.txt");
                text_data.Clear();

                while (!read.EndOfStream) { text_data.Text = text_data.Text + read.ReadLine() + Environment.NewLine; }
                read.Close();
            }
        }//running
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
        private void Form1_Load(object sender, EventArgs e)
        {
            var readall = File.ReadAllLines("Contact List.txt").Count();
            var get_pcount = readall / (data.Length + 1);
            person_count = get_pcount;
        }//loadDataFile
        private void But_cancel_Click(object sender, EventArgs e)
        {
            foreach (Control box in panel1.Controls)
            {
                if (box is TextBox)
                {
                    if (box.Name != txt_city.Name)
                    {
                        box.Text = "";
                    }
                }
                else if (box is ComboBox)
                {
                    box.Text = "--N/A--";
                }
                else if (box is RadioButton)
                {
                    var radio = box as RadioButton;
                    radio.Checked = false;
                }
                else if (box is Label)
                {
                    box.BackgroundImage = null;
                }

            }
        }//running
        private void But_cleardata_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                File.Create(@"Contact List.txt").Close();
                text_data.Clear();
                person_count = 0;
            }
        }//running
        //AESTHETICS
        private void But_cancel_MouseHover(object sender, EventArgs e)
        {
            but_cancel.ForeColor = Color.FromKnownColor(KnownColor.MenuBar);
            but_cancel.FlatAppearance.MouseOverBackColor = Color.FromKnownColor(KnownColor.MenuHighlight);
        }
        private void But_cancel_MouseLeave(object sender, EventArgs e)
        {
            but_cancel.ForeColor = Color.FromKnownColor(KnownColor.MenuHighlight);
            but_cancel.FlatAppearance.MouseOverBackColor = Color.FromKnownColor(KnownColor.MenuBar);
        }
        private void Text_data_Leave(object sender, EventArgs e)
        {
            Form1.ActiveForm.Width = 510;
            text_data.Visible = false;
            but_cleardata.Visible = false;
        }

    }
}
