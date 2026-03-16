using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace W1
{
    public partial class Form2 : Form
    {
        public Form1 preForm;
        public Form2()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.preForm.Close();
            this.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.preForm.Show();
            this.Close();
        }

        private void nextForm_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.preForm = this;
            f.Show();
            this.Hide();
        }

        private void agree_CheckedChanged(object sender, EventArgs e)
        {
            if (agree.Checked == true)
            {
                nextForm.Enabled = true;
            }
            else
            {
                nextForm.Enabled = false; 
            }
        }
    }
}
