using System;
using System.Drawing;
using System.Windows.Forms;

namespace W3
{
    public partial class Form1 : Form
    {
        bool isStarted = false; // 判斷是否正在遊戲中
        bool[] card = new bool[52]; // 紀錄 52 張牌是否已發出
        int[] dealer = new int[5];
        int[] player = new int[5];
        Random ran = new Random();
        int N1, N2, d, p, dn, pn; // 籌碼、下注、發牌索引、總點數

        public Form1()
        {
            InitializeComponent();
            chips.Text = "1000";
        }

        string GenerateColor(int a)
        {
            string color;
            if (a <= 12) color = "\u2660\n"; // 黑桃
            else if (a <= 25) color = "\u2665\n"; // 紅心
            else if (a <= 38) color = "\u2666\n"; // 方塊
            else color = "\u2663\n"; // 梅花

            int rank = a % 13;
            if (rank == 0) color += "A";
            else if (rank == 12) color += "K";
            else if (rank == 11) color += "Q";
            else if (rank == 10) color += "J";
            else color += (rank + 1).ToString();

            return color;
        }

        // 取得牌面基礎點數
        int GetCardValue(int a)
        {
            int rank = a % 13;
            if (rank >= 9) return 10;
            return rank + 1;
        }

        private void start_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. 讀取籌碼與檢查
                N1 = Convert.ToInt32(chips.Text);
                if (bet.Text == "") throw new Exception("請輸入下注籌碼");
                N2 = Convert.ToInt32(bet.Text);

                if (N2 > N1) throw new Exception("籌碼不足");
                if (N2 <= 0) throw new Exception("下注籌碼不可為 0");

                // 初始化
                isStarted = true;
                d = 2; p = 2; dn = 0; pn = 0;
                for (int i = 0; i < 52; i++) card[i] = false;

                Button[] allCards = { a1, a2, a3, a4, a5, b1, b2, b3, b4, b5 };
                foreach (var b in allCards) { b.Text = ""; b.Visible = false; }

                // 發初始牌
                dealer[0] = ran.Next(52); card[dealer[0]] = true;
                do { dealer[1] = ran.Next(52); } while (card[dealer[1]]); card[dealer[1]] = true;
                player[0] = ran.Next(52); card[player[0]] = true;
                do { player[1] = ran.Next(52); } while (card[player[1]]); card[player[1]] = true;

                // 顯示初始牌面
                a1.Visible = a2.Visible = b1.Visible = b2.Visible = true;

                // 莊家第一張蓋牌，第二張翻開
                a1.Text = "";
                a2.Text = GenerateColor(dealer[1]);
                a2.ForeColor = (dealer[1] >= 13 && dealer[1] <= 38) ? Color.Red : Color.Black;

                // 玩家兩張翻開
                b1.Text = GenerateColor(player[0]);
                b1.ForeColor = (player[0] >= 13 && player[0] <= 38) ? Color.Red : Color.Black;
                b2.Text = GenerateColor(player[1]);
                b2.ForeColor = (player[1] >= 13 && player[1] <= 38) ? Color.Red : Color.Black;

                // 計算初始點數
                dn = CalculateTotalPoint(new int[] { dealer[0], dealer[1] }, 2);
                pn = CalculateTotalPoint(new int[] { player[0], player[1] }, 2);

                // Black Jack 判定
                bool d_bj = IsBlackJack(dealer[0], dealer[1]);
                bool p_bj = IsBlackJack(player[0], player[1]);

                if (d_bj || p_bj)
                {
                    EndGameWithBlackJack(d_bj, p_bj);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void cont_Click(object sender, EventArgs e)
        {
            if (!isStarted || p >= 5) return;

            int next;
            do { next = ran.Next(52); } while (card[next]);
            card[next] = true;
            player[p] = next;

            // 顯示新拿到的牌
            Button[] playerBtns = { b1, b2, b3, b4, b5 };
            playerBtns[p].Visible = true;
            playerBtns[p].Text = GenerateColor(next);
            playerBtns[p].ForeColor = (next >= 13 && next <= 38) ? Color.Red : Color.Black;

            p++;
            pn = CalculateTotalPoint(player, p);

            if (pn > 21)
            {
                ShowDealerFirstCard();
                MessageBox.Show($"玩家爆掉！點數：{pn}，你輸了 {N2}");
                UpdateChips(-N2);
            }
        }

        private void stop_Click(object sender, EventArgs e)
        {
            if (!isStarted) return;

            ShowDealerFirstCard();

            Button[] dealerBtns = { a1, a2, a3, a4, a5 };
            while (dn < 17 && d < 5 || dn < pn)
            {
                int next;
                do { next = ran.Next(52); } while (card[next]);
                card[next] = true;
                dealer[d] = next;
                dealerBtns[d].Visible = true;
                dealerBtns[d].Text = GenerateColor(next);
                dealerBtns[d].ForeColor = (next >= 13 && next <= 38) ? Color.Red : Color.Black;
                d++;
                dn = CalculateTotalPoint(dealer, d);
            }

            // 結算勝負
            if (dn > 21) { MessageBox.Show($"莊家爆掉({dn})，你贏了！"); UpdateChips(N2); }
            else if (pn > dn) { MessageBox.Show($"玩家({pn})獲勝！"); UpdateChips(N2); }
            else if (pn < dn) { MessageBox.Show("好可惜", $"莊家點數較高({dn})獲勝！"); UpdateChips(-N2); }
            else { MessageBox.Show("雙方點數相等，平手！"); UpdateChips(0); }
        }

        int CalculateTotalPoint(int[] hand, int count)
        {
            int total = 0;
            int aceCount = 0;
            for (int i = 0; i < count; i++)
            {
                int val = GetCardValue(hand[i]);
                if (val == 1) aceCount++;
                total += val;
            }
            // 處理 Ace 是否要視為 11
            for (int i = 0; i < aceCount; i++)
            {
                if (total + 10 <= 21) total += 10;
            }
            return total;
        }

        bool IsBlackJack(int c1, int c2)
        {
            int r1 = c1 % 13; int r2 = c2 % 13;
            return (r1 == 0 && r2 >= 9) || (r2 == 0 && r1 >= 9);
        }

        void ShowDealerFirstCard()
        {
            a1.Text = GenerateColor(dealer[0]);
            a1.ForeColor = (dealer[0] >= 13 && dealer[0] <= 38) ? Color.Red : Color.Black;
        }

        void UpdateChips(int amount)
        {
            N1 += amount;
            chips.Text = N1.ToString();
            isStarted = false;
            bet.ReadOnly = false;
        }

        void EndGameWithBlackJack(bool d_bj, bool p_bj)
        {
            ShowDealerFirstCard();
            if (d_bj && p_bj) MessageBox.Show("雙方都是 Black Jack，平手！");
            else if (d_bj) { MessageBox.Show("莊家 Black Jack，你輸了！"); UpdateChips(-N2); }
            else { MessageBox.Show("玩家 Black Jack，你贏了！"); UpdateChips(N2); }
        }
    }
}

// index 問題
// 開始玩不能一直按，開始後就要玩完才能開始下一局