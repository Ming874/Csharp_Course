namespace W3
{
    public partial class Form1 : Form
    {
        bool start = false;
        bool[] card = new bool[52];
        int[] dealer = new int[5];
        int[] player = new int[5];
        Random rand = new Random();
        int N1, N2, d, p, dn, pn;

        public Form1()
        {
            InitializeComponent();
        }

        private string GenColor(int i)
        {
            string color;
            if (i <= 12) color = "\u2660\r\n";
            else if (i <= 25) color = "\u2665\r\n";
            else if (i <= 38) color = "\u2666\r\n";
            else color = "\u2663\r\n";

            if (i % 13 == 0) color += "A";
            else if (i % 13 == 10) color += "J";
            else if (i % 13 == 11) color += "Q";
            else if (i % 13 == 12) color += "K";
            else color += (i % 13 + 1).ToString();

            return color;
        }

        private int getPoint(int Card)
        {
            int rank = Card % 13;
            if (rank >= 9) return 10;
            else return (rank + 1);
        }

        private void DrawCard(int[] hand, int index, Button btn)
        {
            int next;
            do { next = rand.Next(52); }
            while (card[next] == true);
            card[next] = true;
            hand[index] = next;

            btn.Visible = true;
            btn.Text = GenColor(next);
            btn.ForeColor = (next >= 13 && next <= 38) ? Color.Red : Color.Black;
        }


        private int CalculateScore(int[] hand, int cardCount)
        {
            int total = 0;
            bool hasAce = false;

            for (int i = 0; i < cardCount; i++)
            {
                int p = getPoint(hand[i]);
                if (p == 1) hasAce = true;
                total += p;
            }

            if (hasAce && total + 10 <= 21)
            {
                total += 10;
            }

            return total;
        }

        private void getResult()
        {
            string msg = "雙方點數相等，平手!";
            if (dn > pn)
            {
                msg = $"莊家點數較高，你輸了 {N2} 籌碼";
                N1 -= N2;
            }
            else if (dn < pn)
            {
                msg = $"玩家點數較高，你贏了 {N2} 籌碼";
                N1 += N2;
            }

            MessageBox.Show(msg, "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            chipsText.Text = N1.ToString();
            start = false;
            betText.ReadOnly = false;
            return;
        }

        private void startbtn_Click(Object sender, EventArgs e)
        {
            try
            {
                if (start == false)
                {
                    d = 2; p = 2; dn = 0; pn = 0;
                    for (int i = 0; i < 52; i++) card[i] = false;
                    for (int i = 0; i < 5; i++) { dealer[i] = -1; player[i] = -1; }

                    Button[] buttons = { d1, d2, d3, d4, d5, p1, p2, p3, p4, p5 };
                    foreach (var b in buttons) { b.Text = ""; b.Visible = false; }

                    d1.Visible = d2.Visible = p1.Visible = p2.Visible = true;

                    N1 = Convert.ToInt32(chipsText.Text);
                    N2 = Convert.ToInt32(betText.Text);

                    if (N2 > N1) throw new Exception("籌碼不足");
                    if (N2 <= 0) throw new Exception("請輸入正確的賭注");

                    start = true;
                    betText.ReadOnly = true;

                    dealer[0] = rand.Next(52);
                    card[dealer[0]] = true;

                    DrawCard(dealer, 1, d2);
                    DrawCard(player, 0, p1);
                    DrawCard(player, 1, p2);

                    dn = CalculateScore(dealer, 2);
                    pn = CalculateScore(player, 2);

                    if (dn == 21)
                    {
                        d1.Text = GenColor(dealer[0]);
                        d1.ForeColor = (dealer[0] >= 13 && dealer[0] <= 38) ? Color.Red : Color.Black;
                        start = false;
                        betText.ReadOnly = false;

                        if (pn == 21)
                        {
                            MessageBox.Show("雙方都是 Black Jack，平手!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show($"莊家 Black Jack，你輸了 {N2} 籌碼", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            N1 -= N2;
                            chipsText.Text = N1.ToString();
                        }
                    }
                    else if (pn == 21)
                    {
                        d1.Text = GenColor(dealer[0]);
                        d1.ForeColor = (dealer[0] >= 13 && dealer[0] <= 38) ? Color.Red : Color.Black;
                        start = false;
                        betText.ReadOnly = false;

                        MessageBox.Show($"玩家 Black Jack，你贏了 {N2} 籌碼", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        N1 += N2;
                        chipsText.Text = N1.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void passBtn_Click(object sender, EventArgs e)
        {
            if (!start) return;

            d1.Text = GenColor(dealer[0]);
            d1.ForeColor = (dealer[0] >= 13 && dealer[0] <= 38) ? Color.Red : Color.Black;
            Button[] buttons = { d1, d2, d3, d4, d5 };

            while (d < 5 && dn < 17)
            {
                DrawCard(dealer, d, buttons[d]);
                dn = CalculateScore(dealer, d + 1);
                d++;

                if (dn > 21)
                {
                    MessageBox.Show($"莊家爆掉，你贏了 {N2} 籌碼", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    N1 += N2;
                    chipsText.Text = N1.ToString();
                    start = false;
                    betText.ReadOnly = false;
                    return;
                }
            }

            getResult();
            return;
        }
        private void contBtn_Click(object sender, EventArgs e)
        {
            if (!start) return;

            Button[] buttons = { p1, p2, p3, p4, p5 };

            DrawCard(player, p, buttons[p]);
            pn = CalculateScore(player, p + 1);
            p++;

            if (p == 5)
            {
                passBtn_Click(sender, e);
                return;
            }
            if (pn > 21)
            {
                d1.Text = GenColor(dealer[0]);
                d1.ForeColor = (dealer[0] >= 13 && dealer[0] <= 38) ? Color.Red : Color.Black;
                MessageBox.Show($"玩家爆掉，你輸了 {N2} 籌碼", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                N1 -= N2;
                chipsText.Text = N1.ToString();
                start = false;
                betText.ReadOnly = false;
                return;
            }
        }
    }
}