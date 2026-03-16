using System.Reflection.Emit;

namespace W1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.preForm = this;
            f.Show();
            this.Hide();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void password_status(object sender, EventArgs e)
        {
            if (password.Text.Length > 0)
            {
                label3.Visible = true;
                passwordCheck.Visible = true;
            }

            if (password.Text == passwordCheck.Text && password.Text != "")
            {
                nextForm.Enabled = true;
            }
            else
            {
                nextForm.Enabled = false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void account_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
