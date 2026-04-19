using System.Text;

namespace W6
{
    public partial class Form1 : Form
    {
        private List<string> result = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Permute(ref char[] arr, int start, int end)
        {
            if (start == end)
            {
                result.Add(new string(arr));
                return;
            }

            for (int i = start; i <= end; i++)
            {
                (arr[start], arr[i]) = (arr[i], arr[start]);    // Swap
                Permute(ref arr, start + 1, end);
                (arr[start], arr[i]) = (arr[i], arr[start]);    // Swap back
            }
            return;
        }

        private void genBtn_Click(object sender, EventArgs e)
        {
            result.Clear();

            string input = inputTb.Text.Trim();
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Please enter a valid input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            char[] arr = input.ToCharArray();
            Permute(ref arr, 0, arr.Length - 1);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < result.Count; i++)
            {
                sb.Append(result[i] + ", ");
                if (i % 4 == 3)
                {
                    sb.AppendLine();
                }
            }

            resultTb.Text = sb.ToString();
            countTb.Text = result.Count.ToString();
            return;
        }
    }
}
