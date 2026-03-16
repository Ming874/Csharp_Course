using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace W1
{
    public partial class Form3 : Form
    {
        public Form2 preForm;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateTotal(object sender, EventArgs e)
        {
            int total = 0;
            
            foreach (Control c in groupBox1.Controls)
            {
                if (c is CheckBox ch && ch.Checked && ch.Tag != null)
                {
                    total += Convert.ToInt32(ch.Tag.ToString());
                }
            }

            if (chFries.Checked)
            {
                if (bigFries.Checked) total += Convert.ToInt32(bigFries.Tag.ToString());
                if (smallFries.Checked) total += Convert.ToInt32(smallFries.Tag.ToString());
            }

            if (chDrink.Checked)
            {
                if (cola.Checked) total += Convert.ToInt32(cola.Tag.ToString());
                if (blacktea.Checked) total += Convert.ToInt32(blacktea.Tag.ToString());
                if (coffee.Checked) total += Convert.ToInt32(coffee.Tag.ToString());
            }

            totalPrice.Text = total.ToString();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.preForm.Show();
            this.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.preForm.preForm.Close();
            this.preForm.Close();
            this.Close();
        }

        private void chFries_CheckedChanged(object sender, EventArgs e)
        {
            if (chFries.Checked)
            {
                bigFries.Enabled = true;
                smallFries.Enabled = true;
            }
            else
            {
                bigFries.Enabled = false;
                smallFries.Enabled = false;

                bigFries.Checked = false;
                smallFries.Checked = false;
            }
        }

        private void chDrink_CheckedChanged(object sender, EventArgs e)
        {
            if (chDrink.Checked)
            {
                cola.Enabled = true;
                coffee.Enabled = true;
                blacktea.Enabled = true;
            }
            else
            {
                cola.Enabled = false;
                coffee.Enabled = false;
                blacktea.Enabled = false;

                cola.Checked = false;
                coffee.Checked = false;
                blacktea.Checked = false;
            }
        }
    }
}
