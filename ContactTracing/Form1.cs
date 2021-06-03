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
        public Form1()
        {
            InitializeComponent();
        }

        private void Checking(object sender, EventArgs e)
        {
            TextBox box = sender as TextBox;

            var comb = "label" + box.Name.ToString().Substring(4);
            //int.TryParse(box.Text, out int result
            //string[] num = { "1", "2","3","4","5","6","7","8","9","0",".", "#",};
            if (!box.Text.All(char.IsLetter) || box.Text == "")
            {
                Controls.Find(comb, true)[0].Text = "•Invalid input";
            }
            else
            {
                Controls.Find(comb, true)[0].Text = "Corek";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime limit = new DateTime(1899,12,31);
            
            if (date_birth.Value > DateTime.Today || date_birth.Value <= limit)
            {
                label_birth.Text = "Invalid Input";
            }
            else
            {
                label_birth.Text = "Corek";
            }
            //label_birth.Text = DateTime.Today.ToString() ;
            if (cobx_brgy.SelectedIndex < 0)
            {
                label_brgy.Text = "Invalid input";
            }
            else
            {
                label_brgy.Text = "corek";
            }
            if (cobx_Cstatus.SelectedIndex < 0)
            {
                label_Cstatus.Text = "Invalid input";
            }
            else
            {
                label_Cstatus.Text = "corek";
            }
            if (!(radio_female.Checked || radio_male.Checked))
            {
                label_sex.Text = "Invalid input";
            }
            else
            {
                label_sex.Text = "corek";
            }
        }
    }


}
