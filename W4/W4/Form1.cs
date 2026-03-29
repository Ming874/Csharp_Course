namespace W4 {
    public partial class Form1 : Form {
        int[][] kernel = new int[3][] {
            new int[] { 1, -1, -1, -1, 1, -1, -1, -1, 1},
            new int[] { 1, -1, 1, -1, 1, -1, 1, -1, 1 },
            new int[] { -1, -1, 1, -1, 1, -1, 1, -1, -1 }
        };
        int[][] pic = new int[9][];
        TextBox[][,] resultBoxes = new TextBox[3][,];

        public Form1() {
            InitializeComponent();

            for (int i = 0; i < 9; i++) {
                pic[i] = new int[9];
            }
            for (int i = 0; i < 3; i++) {
                resultBoxes[i] = new TextBox[7, 7];
            }

            var AllTextbox = this.Controls.OfType<TextBox>().OrderBy(t => t.TabIndex).ToArray();
            int counter = 0;
            for (int n = 0; n < 3; n++) {
                for (int r = 0; r < 7; r++) {
                    for (int c = 0; c < 7; c++) {
                        resultBoxes[n][r, c] = AllTextbox[counter++];
                    }
                }
            }
        }

        private void Convolve(int n) {
            int[] curkernel = kernel[n];
            double[,] buffer = new double[7, 7];

            for (int r = 0; r < 7; r++) {
                for (int c = 0; c < 7; c++) {
                    double sum = 0;

                    // Cal. an entity by pic * kernel
                    for (int i = 0; i < 3; i++) {
                        for (int j = 0; j < 3; j++) {
                            sum += pic[r + i][c + j] * curkernel[i * 3 + j];
                        }
                    }
                    buffer[r, c] = Math.Truncate((sum / 9) * 100) / 100.0;
                }
            }

            this.Invoke(new Action(() => {
                this.SuspendLayout();
                for (int r = 0; r < 7; r++) {
                    for (int c = 0; c < 7; c++) {
                        resultBoxes[n][r, c].Text = buffer[r, c].ToString();
                    }
                }
                this.ResumeLayout();
            }));
        }

        private void button1_Click(object sender, EventArgs e) {
            openFileDialog1.Filter = "CSV File (*.csv)|*.csv";

            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                using (StreamReader sr = new StreamReader(openFileDialog1.FileName)) {
                    string[] line = new string[9];
                    int i = 0;

                    while (sr.Peek() >= 0) {
                        line = sr.ReadLine().Split(',');

                        for (int j = 0; j < 9; j++) {
                            pic[i][j] = Convert.ToInt32(line[j]);
                        }
                        i++;
                    }
                }

                // Convolve the picture with kernel and display the results
                Parallel.Invoke(
                    () => Convolve(0),
                    () => Convolve(1),
                    () => Convolve(2)
                );
            }
        }
    }
}