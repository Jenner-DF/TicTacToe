using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactTracing
{
    public partial class Form2 : Form
    {
        int person_count, panel_count = 0;
        string[] data = new string[11];
        readonly Image pic_check = Image.FromFile("green_circle.png");
        readonly Image pic_wrong = Image.FromFile("red_x.png");
        Panel active_panel;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            active_panel = panel_entry0;
            panel1.BackColor = Color.FromArgb(35, 0, 0, 0);

            int readall = File.ReadAllLines("Contact List.txt").Count();
            int get_pcount = readall / (data.Length);
            person_count = get_pcount;
        }
        private void but_submit_Click(object sender, EventArgs e)
        {
            //check if invalid input
            if (Check_ActivePanel())
            {
                MessageBox.Show("Invalid input/s", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //next panel
            else
            {
                active_panel.Enabled = false;
                active_panel.Visible = false;

                if (panel_count == 2 && check_terms.Checked)
                {
                    person_count++;
                    data_store();
                    reset_Form();
                }
                else if (panel_count != 2)
                {
                    next_panel();
                }
            }
        }
        private void Check_text(object sender, EventArgs e)
        {
            TextBox box = sender as TextBox;
            Label the_label = active_panel.Controls["label" + box.Name.Substring(4)] as Label;

            if (box.Name == "text_mobnum")
            {
                if (!box.Text.All(char.IsDigit) || box.Text.ToString().Length != 11 || box.Text == "")
                {
                    the_label.BackgroundImage = pic_wrong;
                }
                else
                {
                    the_label.BackgroundImage = pic_check;
                }
            }
            else if (box.Text == "")
            {
                the_label.BackgroundImage = pic_wrong;
            }
            else
            {
                the_label.BackgroundImage = pic_check;
            }
        }
        private void Check_combox(object sender, EventArgs e)
        {
            ComboBox box = sender as ComboBox;
            Label the_label = active_panel.Controls["label" + box.Name.Substring(4)] as Label;
            if (box.SelectedIndex < 0)
            {
                the_label.BackgroundImage = pic_wrong;
            }
            else
            {
                the_label.BackgroundImage = pic_check;
            }
        }
        private void Check_datetime(object sender, EventArgs e)
        {
            DateTime limit = new DateTime(1900, 12, 31);
            int age_year = DateTime.Now.Year - date_birth.Value.Year;

            if (date_birth.Value < limit.Date || date_birth.Value >= DateTime.Today)
            {
                label_birth.BackgroundImage = pic_wrong;
            }
            else
            {
                label_birth.BackgroundImage = pic_check;

                //get age
                if (date_birth.Value.Month > DateTime.Now.Month)
                {
                    age_year = age_year - 1;
                }
                else if (date_birth.Value.Month == DateTime.Now.Month && date_birth.Value.Day > DateTime.Now.Day)
                {
                    age_year = age_year - 1;
                }
                lbl_age.Text = "You are " + age_year.ToString() + " year/s old already!";
            }
        }
        private bool Check_ActivePanel()
        {
            bool get_wrong = false;
            if (panel_count == 2 && !check_terms.Checked)
            {
                get_wrong = true;
                return get_wrong;
            }
            else
            {
                foreach (Control check in active_panel.Controls)
                {
                    if (check.BackgroundImage != pic_check && check.Name.StartsWith("label"))
                    {
                        get_wrong = true;
                        check.BackgroundImage = pic_wrong;
                    }
                }
            }
            return (get_wrong);
        }
        private void inside_clicked_text(object sender, EventArgs e)
        {
            TextBox control = sender as TextBox;
            if (control.Text.Contains(" Name") || control.Text.Contains("Address") || control.Text.Contains("Mobile #"))
            {
                control.Text = "";
                control.ForeColor = Color.FromKnownColor(KnownColor.WindowText);
            }
        }
        private void but_backexit_Click(object sender, EventArgs e)
        {
            if (panel_count >= 1)
            {
                active_panel.Enabled = false;
                active_panel.Visible = false;
                panel_count--;
                active_panel = panel1.Controls["panel_entry" + panel_count.ToString()] as Panel;
                active_panel.Enabled = true;
                active_panel.Visible = true;
                but_submit.Text = "Next";
                if (panel_count == 0) { but_cancel.Text = "Exit"; }
            }
            else
            {
                if (MessageBox.Show("Exit Application?", "Exit Program", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Close();
                }
            }
        }
        private void next_panel()
        {
            panel_count++;
            but_cancel.Text = "Back";
            if (panel_count == 2) { but_submit.Text = "Submit"; }
            active_panel = panel1.Controls["panel_entry" + panel_count.ToString()] as Panel;
            active_panel.Enabled = true;
            active_panel.Visible = true;
        }

        private void data_store()
        {
            data = new string[11]{"Person " + person_count.ToString(), text_Lname.Text.ToUpper(),text_Fname.Text, text_Mname.Text, cobx_Cstatus.Text,
                                          cobx_sex.Text, date_birth.Text, cobx_brgy.Text, text_addr.Text, text_mobnum.Text,"#####*FOR ANTIPOLO CITY ONLY*#####"};
           
            StreamWriter outputFile = new StreamWriter(@"Contact List.txt", true);
            //WriteToTheFile
            foreach (string i in data) { outputFile.WriteLine(i); }
            outputFile.Close();
        }
        private void reset_Form()
        {
            Form2 resetForm = new Form2();
            resetForm.Show();
            Dispose(false);

            //add person count code
        }
        private void but_cleardata_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                File.Create(@"Contact List.txt").Close();
                text_data.Clear();
                person_count = 0;
            }
        }


        //AESTHETICS//
        private void but_cancel_hover(object sender, EventArgs e)
        {
            but_cancel.ForeColor = Color.FromKnownColor(KnownColor.MenuBar);
            but_cancel.FlatAppearance.MouseOverBackColor = Color.FromKnownColor(KnownColor.MenuHighlight);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            text_data.Visible = true;
            but_cleardata.Visible = true;
            StreamReader read = new StreamReader("Contact List.txt");
            text_data.Clear();
            while (!read.EndOfStream) { text_data.Text = text_data.Text + read.ReadLine() + Environment.NewLine; }
            read.Close();
        }

        private void text_data_Leave(object sender, EventArgs e)
        {
            text_data.Visible = false;
            but_cleardata.Visible = false;
        }

        private void but_cancel_mouseleave(object sender, EventArgs e)
        {
            but_cancel.ForeColor = Color.FromKnownColor(KnownColor.MenuHighlight);
            but_cancel.FlatAppearance.MouseOverBackColor = Color.FromKnownColor(KnownColor.MenuBar);
        }
    }
}
