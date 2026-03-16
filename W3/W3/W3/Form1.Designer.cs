namespace W3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            chips = new TextBox();
            start = new Button();
            cont = new Button();
            stop = new Button();
            bet = new TextBox();
            a1 = new Button();
            a2 = new Button();
            a3 = new Button();
            a4 = new Button();
            a5 = new Button();
            b1 = new Button();
            b2 = new Button();
            b3 = new Button();
            b4 = new Button();
            b5 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 29);
            label1.Name = "label1";
            label1.Size = new Size(50, 25);
            label1.TabIndex = 0;
            label1.Text = "莊家";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 185);
            label2.Name = "label2";
            label2.Size = new Size(50, 25);
            label2.TabIndex = 1;
            label2.Text = "玩家";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(318, 44);
            label3.Name = "label3";
            label3.Size = new Size(88, 25);
            label3.TabIndex = 6;
            label3.Text = "玩家籌碼";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(318, 103);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 7;
            label4.Text = "下注籌碼";
            // 
            // chips
            // 
            chips.Location = new Point(412, 41);
            chips.Name = "chips";
            chips.ReadOnly = true;
            chips.Size = new Size(150, 31);
            chips.TabIndex = 8;
            chips.Text = "1000";
            // 
            // start
            // 
            start.Location = new Point(318, 166);
            start.Name = "start";
            start.Size = new Size(244, 34);
            start.TabIndex = 9;
            start.Text = "開始玩";
            start.UseVisualStyleBackColor = true;
            start.Click += start_Click;
            // 
            // cont
            // 
            cont.Location = new Point(318, 224);
            cont.Name = "cont";
            cont.Size = new Size(244, 34);
            cont.TabIndex = 10;
            cont.Text = "要牌";
            cont.UseVisualStyleBackColor = true;
            cont.Click += cont_Click;
            // 
            // stop
            // 
            stop.Location = new Point(318, 282);
            stop.Name = "stop";
            stop.Size = new Size(244, 34);
            stop.TabIndex = 11;
            stop.Text = "不再要牌";
            stop.UseVisualStyleBackColor = true;
            stop.Click += stop_Click;
            // 
            // bet
            // 
            bet.Location = new Point(412, 103);
            bet.Name = "bet";
            bet.Size = new Size(150, 31);
            bet.TabIndex = 12;
            // 
            // a1
            // 
            a1.Location = new Point(24, 66);
            a1.Name = "a1";
            a1.Size = new Size(50, 80);
            a1.TabIndex = 13;
            a1.UseVisualStyleBackColor = true;
            // 
            // a2
            // 
            a2.Location = new Point(80, 66);
            a2.Name = "a2";
            a2.Size = new Size(50, 80);
            a2.TabIndex = 14;
            a2.UseVisualStyleBackColor = true;
            // 
            // a3
            // 
            a3.Location = new Point(136, 66);
            a3.Name = "a3";
            a3.Size = new Size(50, 80);
            a3.TabIndex = 15;
            a3.UseVisualStyleBackColor = true;
            a3.Visible = false;
            // 
            // a4
            // 
            a4.Location = new Point(192, 66);
            a4.Name = "a4";
            a4.Size = new Size(50, 80);
            a4.TabIndex = 16;
            a4.UseVisualStyleBackColor = true;
            a4.Visible = false;
            // 
            // a5
            // 
            a5.Location = new Point(248, 66);
            a5.Name = "a5";
            a5.Size = new Size(50, 80);
            a5.TabIndex = 17;
            a5.UseVisualStyleBackColor = true;
            a5.Visible = false;
            // 
            // b1
            // 
            b1.Location = new Point(24, 224);
            b1.Name = "b1";
            b1.Size = new Size(50, 80);
            b1.TabIndex = 18;
            b1.UseVisualStyleBackColor = true;
            // 
            // b2
            // 
            b2.Location = new Point(80, 224);
            b2.Name = "b2";
            b2.Size = new Size(50, 80);
            b2.TabIndex = 19;
            b2.UseVisualStyleBackColor = true;
            // 
            // b3
            // 
            b3.Location = new Point(136, 224);
            b3.Name = "b3";
            b3.Size = new Size(50, 80);
            b3.TabIndex = 20;
            b3.UseVisualStyleBackColor = true;
            b3.Visible = false;
            // 
            // b4
            // 
            b4.Location = new Point(192, 224);
            b4.Name = "b4";
            b4.Size = new Size(50, 80);
            b4.TabIndex = 21;
            b4.UseVisualStyleBackColor = true;
            b4.Visible = false;
            // 
            // b5
            // 
            b5.Location = new Point(248, 224);
            b5.Name = "b5";
            b5.Size = new Size(50, 80);
            b5.TabIndex = 22;
            b5.UseVisualStyleBackColor = true;
            b5.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 339);
            Controls.Add(b5);
            Controls.Add(b4);
            Controls.Add(b3);
            Controls.Add(b2);
            Controls.Add(b1);
            Controls.Add(a5);
            Controls.Add(a4);
            Controls.Add(a3);
            Controls.Add(a2);
            Controls.Add(a1);
            Controls.Add(bet);
            Controls.Add(stop);
            Controls.Add(cont);
            Controls.Add(start);
            Controls.Add(chips);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Black Jack";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox chips;
        private Button start;
        private Button cont;
        private Button stop;
        private TextBox bet;
        private Button a1;
        private Button a2;
        private Button a3;
        private Button a4;
        private Button a5;
        private Button b1;
        private Button b2;
        private Button b3;
        private Button b4;
        private Button b5;
    }
}
