using System.Text;

namespace W5
{
    public partial class Form1 : Form
    {
        TextBox[,] board = new TextBox[6, 6];
        int[,] arr = new int[6, 6];

        public Form1()
        {
            InitializeComponent();
            var AllTextBoxes = this.Controls.OfType<TextBox>()
                                   .Where(tb => tb.Name.StartsWith("textBox"))
                                   .OrderBy(tb => tb.TabIndex)
                                   .ToArray();
            int counter = 0;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    board[i, j] = AllTextBoxes[counter++];
                    board[i, j].ForeColor = Color.Black;
                }
            }
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "DAT Files (*.dat)|*.dat";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string content = File.ReadAllText(openFileDialog1.FileName);
                string[] numbers = content.Split(new char[] { (char)2, (char)3 }, StringSplitOptions.RemoveEmptyEntries);
                int counter = 0;

                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        arr[i, j] = Convert.ToInt32(numbers[counter++].Trim());
                        board[i, j].Text = arr[i, j].ToString();
                        board[i, j].ForeColor = Color.Black;
                    }
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "DAT Files (*.dat)|*.dat";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        sb.Append((char)2);
                        sb.Append(board[i, j].Text);
                    }
                }
                sb.Append((char)3);
                File.WriteAllText(saveFileDialog1.FileName, sb.ToString());
                MessageBox.Show("Data saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnGenRoute_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    board[i, j].ForeColor = Color.Black;
                    if (!int.TryParse(board[i, j].Text, out arr[i, j]))
                    {
                        arr[i, j] = 0;
                    }
                }
            }

            int[,] dp = new int[6, 6];
            dp[0, 0] = arr[0, 0];
            for (int j = 1; j < 6; j++)     dp[0, j] = dp[0, j - 1] + arr[0, j];
            for (int i = 1; i < 6; i++)     dp[i, 0] = dp[i - 1, 0] + arr[i, 0];

            for (int i = 1; i < 6; i++)
            {
                for (int j = 1; j < 6; j++)
                {
                    dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]) + arr[i, j];
                }
            }

            TbScore.Text = dp[5, 5].ToString();

            int currI = 5, currJ = 5;
            while (currI >= 0 && currJ >= 0)
            {
                board[currI, currJ].ForeColor = Color.Red;

                if (currI == 0 && currJ == 0) break;

                if (currI == 0) currJ--;
                else if (currJ == 0) currI--;
                else
                {
                    if (dp[currI - 1, currJ] < dp[currI, currJ - 1])
                        currJ--;
                    else
                        currI--;
                }
            }
        }
    }
}
