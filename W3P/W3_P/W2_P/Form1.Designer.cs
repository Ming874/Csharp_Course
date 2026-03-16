namespace W2_P
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
            name = new TextBox();
            chinese = new TextBox();
            math = new TextBox();
            input = new Button();
            load = new Button();
            save = new Button();
            info1 = new TextBox();
            info2 = new TextBox();
            load_bin = new Button();
            save_bin = new Button();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 49);
            label1.Name = "label1";
            label1.Size = new Size(50, 25);
            label1.TabIndex = 0;
            label1.Text = "姓名";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 94);
            label2.Name = "label2";
            label2.Size = new Size(50, 25);
            label2.TabIndex = 1;
            label2.Text = "國文";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 142);
            label3.Name = "label3";
            label3.Size = new Size(50, 25);
            label3.TabIndex = 2;
            label3.Text = "數學";
            // 
            // name
            // 
            name.Location = new Point(110, 46);
            name.Name = "name";
            name.Size = new Size(150, 31);
            name.TabIndex = 3;
            // 
            // chinese
            // 
            chinese.Location = new Point(110, 91);
            chinese.Name = "chinese";
            chinese.Size = new Size(150, 31);
            chinese.TabIndex = 4;
            // 
            // math
            // 
            math.Location = new Point(110, 139);
            math.Name = "math";
            math.Size = new Size(150, 31);
            math.TabIndex = 5;
            // 
            // input
            // 
            input.Location = new Point(44, 201);
            input.Name = "input";
            input.Size = new Size(216, 34);
            input.TabIndex = 6;
            input.Text = "輸入資料";
            input.UseVisualStyleBackColor = true;
            input.Click += input_Click;
            // 
            // load
            // 
            load.Location = new Point(44, 251);
            load.Name = "load";
            load.Size = new Size(216, 34);
            load.TabIndex = 7;
            load.Text = "載入資料";
            load.UseVisualStyleBackColor = true;
            load.Click += load_Click;
            // 
            // save
            // 
            save.Location = new Point(44, 302);
            save.Name = "save";
            save.Size = new Size(216, 34);
            save.TabIndex = 8;
            save.Text = "儲存資料";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // info1
            // 
            info1.Location = new Point(301, 49);
            info1.Name = "info1";
            info1.ReadOnly = true;
            info1.Size = new Size(317, 31);
            info1.TabIndex = 9;
            info1.Text = "共有 0 人";
            // 
            // info2
            // 
            info2.Location = new Point(301, 94);
            info2.Multiline = true;
            info2.Name = "info2";
            info2.ReadOnly = true;
            info2.ScrollBars = ScrollBars.Both;
            info2.Size = new Size(317, 242);
            info2.TabIndex = 10;
            info2.Text = "姓名    國文    數學\r\n";
            info2.WordWrap = false;
            info2.TextChanged += info2_TextChanged;
            // 
            // load_bin
            // 
            load_bin.Location = new Point(69, 361);
            load_bin.Name = "load_bin";
            load_bin.Size = new Size(240, 34);
            load_bin.TabIndex = 11;
            load_bin.Text = "載入資料 (binary)";
            load_bin.UseVisualStyleBackColor = true;
            load_bin.Click += load_bin_Click;
            // 
            // save_bin
            // 
            save_bin.Location = new Point(352, 361);
            save_bin.Name = "save_bin";
            save_bin.Size = new Size(240, 34);
            save_bin.TabIndex = 12;
            save_bin.Text = "儲存資料 (binary)";
            save_bin.UseVisualStyleBackColor = true;
            save_bin.Click += save_bin_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 450);
            Controls.Add(save_bin);
            Controls.Add(load_bin);
            Controls.Add(info2);
            Controls.Add(info1);
            Controls.Add(save);
            Controls.Add(load);
            Controls.Add(input);
            Controls.Add(math);
            Controls.Add(chinese);
            Controls.Add(name);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "成績存檔讀取";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox name;
        private TextBox chinese;
        private TextBox math;
        private Button input;
        private Button load;
        private Button save;
        private TextBox info1;
        private TextBox info2;
        private Button load_bin;
        private Button save_bin;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
    }
}
