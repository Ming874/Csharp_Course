using System.Diagnostics.Metrics;

namespace W2
{
    public partial class Form1 : Form
    {
        string[,] name = new string[50, 2];
        int[,] score = new int[50, 2];
        int counter = 0, mathScore = 0, chineseScore = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (counter >= 50)
                {
                    MessageBox.Show("資料已滿");
                    return;
                }

                name[counter, 0] = id.Text;
                name[counter, 1] = names.Text;
                score[counter, 0] = Convert.ToInt32(chinese.Text);
                score[counter, 1] = Convert.ToInt32(math.Text);

                chineseScore += score[counter, 0];
                mathScore += score[counter, 1];
                counter++;
                count.Text = counter.ToString();
                chinese_ave.Text = Math.Round(chineseScore / (double)counter, 2).ToString();
                math_ave.Text = Math.Round(mathScore / (double)counter, 2).ToString();

                id.Clear();
                names.Clear();
                chinese.Clear();
                math.Clear();

                button3_Click(sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show("輸入字串格式不正確", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            info.Text = "學號\t姓名\t國文\t數學";

            for (int i = 0; i < counter; i++)
            {
                info.Text += $"\r\n{name[i, 0]}\t{name[i, 1]}\t{score[i, 0]}\t{score[i, 1]}";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string key = id.Text;
            bool found = false;
            info.Text = "搜尋結果:\r\n學號\t姓名\t國文\t數學";

            for (int i = 0; i < counter; i++)
            {
                if (name[i, 0] == key)
                {
                    info.Text += $"\r\n{name[i, 0]}\t{name[i, 1]}\t{score[i, 0]}\t{score[i, 1]}";
                    found = true;
                }
            }

            if (!found)
            {
                MessageBox.Show("資料不存在", "搜尋學號" + key, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
