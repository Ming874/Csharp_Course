namespace W2_P
{
    public partial class Form1 : Form
    {
        const int MAX_CAPACITY = 50;
        string[] names = new string[MAX_CAPACITY];
        int[,] scores = new int[MAX_CAPACITY, 2];
        int counter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void input_Click(object sender, EventArgs e)
        {
            if (counter < MAX_CAPACITY)
            {
                names[counter] = name.Text;
                scores[counter, 0] = Convert.ToInt32(chinese.Text);
                scores[counter, 1] = Convert.ToInt32(math.Text);
                counter++;

                name.Text = "";
                chinese.Text = "";
                math.Text = "";

                showData();
            }
            else
            {
                MessageBox.Show("Maximum capacity reached!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showData()
        {
            info1.Text = "共有 " + counter + " 人";
            info2.Text = "姓名\t國文\t數學\r\n";

            for (int i = 0; i < counter; i++)
            {
                info2.Text += names[i] + "\t" + scores[i, 0] + "\t" + scores[i, 1] + "\r\n";
            }
        }

        private void save_bin_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Binary Files (*.dat)|*.dat";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create);
                BinaryWriter bw = new BinaryWriter(fs);
                for (int i = 0; i < counter; i++)
                {
                    bw.Write(names[i] + "," + scores[i, 0] + "," + scores[i, 1] + "\r\n");
                }

                bw.Flush();
                bw.Close();
                fs.Close();
            }

        }

        private void info2_TextChanged(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileInfo f = new FileInfo(saveFileDialog1.FileName);
                StreamWriter sw = f.CreateText();

                for (int i = 0; i < counter; i++)
                {
                    sw.WriteLine(names[i] + "," + scores[i, 0] + "," + scores[i, 1]);
                }
                sw.Flush();
                sw.Close();
            }
        }

        private void load_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileInfo f = new FileInfo(openFileDialog1.FileName);
                StreamReader sr = f.OpenText();

                int i = 0;

                while (sr.Peek() >= 0)
                {
                    string line = sr.ReadLine();
                    string[] data = line.Split(',');

                    names[i] = data[0];
                    scores[i, 0] = Convert.ToInt32(data[1]);
                    scores[i, 1] = Convert.ToInt32(data[2]);

                    i++;
                }

                sr.Close();
                counter = i;
                showData();
            }
        }

        private void load_bin_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Binary Files (*.dat)|*.dat";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open);
                BinaryReader br = new BinaryReader(fs);

                int i = counter;
                while (br.PeekChar() >= 0)
                {
                    names[i] = br.ReadString();
                    scores[i, 0] = br.ReadInt32();
                    scores[i, 1] = br.ReadInt32();
                    i++;
                }

                br.Close();
                fs.Close();
                counter = i;
                showData();
            }
        }
    }
}
