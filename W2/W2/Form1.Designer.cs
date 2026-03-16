namespace W2
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
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            id = new TextBox();
            names = new TextBox();
            chinese = new TextBox();
            math = new TextBox();
            count = new TextBox();
            chinese_ave = new TextBox();
            math_ave = new TextBox();
            info = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 40);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 0;
            label1.Text = "學號";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 73);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 1;
            label2.Text = "姓名";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 106);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 2;
            label3.Text = "國文";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 139);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 3;
            label4.Text = "數學";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 184);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 4;
            label5.Text = "共有";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(133, 184);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 5;
            label6.Text = "筆資料";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(214, 184);
            label7.Name = "label7";
            label7.Size = new Size(73, 20);
            label7.TabIndex = 6;
            label7.Text = "國文平均";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(361, 184);
            label8.Name = "label8";
            label8.Size = new Size(73, 20);
            label8.TabIndex = 7;
            label8.Text = "數學平均";
            // 
            // id
            // 
            id.Location = new Point(81, 37);
            id.Name = "id";
            id.Size = new Size(125, 27);
            id.TabIndex = 8;
            // 
            // names
            // 
            names.Location = new Point(81, 70);
            names.Name = "names";
            names.Size = new Size(125, 27);
            names.TabIndex = 9;
            // 
            // chinese
            // 
            chinese.Location = new Point(81, 103);
            chinese.Name = "chinese";
            chinese.Size = new Size(125, 27);
            chinese.TabIndex = 10;
            // 
            // math
            // 
            math.Location = new Point(81, 136);
            math.Name = "math";
            math.Size = new Size(125, 27);
            math.TabIndex = 11;
            // 
            // count
            // 
            count.Location = new Point(81, 181);
            count.Name = "count";
            count.ReadOnly = true;
            count.Size = new Size(52, 27);
            count.TabIndex = 12;
            count.Text = "0";
            count.TextAlign = HorizontalAlignment.Center;
            // 
            // chinese_ave
            // 
            chinese_ave.Location = new Point(293, 181);
            chinese_ave.Name = "chinese_ave";
            chinese_ave.ReadOnly = true;
            chinese_ave.Size = new Size(52, 27);
            chinese_ave.TabIndex = 13;
            chinese_ave.TextAlign = HorizontalAlignment.Center;
            // 
            // math_ave
            // 
            math_ave.Location = new Point(440, 181);
            math_ave.Name = "math_ave";
            math_ave.ReadOnly = true;
            math_ave.Size = new Size(52, 27);
            math_ave.TabIndex = 14;
            math_ave.TextAlign = HorizontalAlignment.Center;
            // 
            // info
            // 
            info.Location = new Point(227, 40);
            info.Multiline = true;
            info.Name = "info";
            info.ReadOnly = true;
            info.ScrollBars = ScrollBars.Both;
            info.Size = new Size(275, 123);
            info.TabIndex = 15;
            info.Text = "學號        姓名        國文        數學";
            info.WordWrap = false;
            // 
            // button1
            // 
            button1.Location = new Point(34, 224);
            button1.Name = "button1";
            button1.Size = new Size(151, 29);
            button1.TabIndex = 16;
            button1.Text = "資料輸入";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(191, 224);
            button2.Name = "button2";
            button2.Size = new Size(151, 29);
            button2.TabIndex = 17;
            button2.Text = "學號搜尋";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(351, 224);
            button3.Name = "button3";
            button3.Size = new Size(151, 29);
            button3.TabIndex = 18;
            button3.Text = "資料顯示";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 274);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(info);
            Controls.Add(math_ave);
            Controls.Add(chinese_ave);
            Controls.Add(count);
            Controls.Add(math);
            Controls.Add(chinese);
            Controls.Add(names);
            Controls.Add(id);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "成績陣列";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox id;
        private TextBox names;
        private TextBox chinese;
        private TextBox math;
        private TextBox count;
        private TextBox chinese_ave;
        private TextBox math_ave;
        private TextBox info;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
