namespace W1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            agree = new CheckBox();
            nextForm = new Button();
            back = new Button();
            exit = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(140, 20);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "約定事項";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(71, 56);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.Size = new Size(219, 103);
            textBox1.TabIndex = 1;
            textBox1.Text = "1. 上課認真聽\r\n2. 作業認真寫\r\n3. 晚上認真睡\r\n4. 一天一程式，Fail 遠離我";
            textBox1.WordWrap = false;
            // 
            // agree
            // 
            agree.AutoSize = true;
            agree.Location = new Point(134, 175);
            agree.Name = "agree";
            agree.Size = new Size(79, 24);
            agree.TabIndex = 2;
            agree.Text = "我同意";
            agree.UseVisualStyleBackColor = true;
            agree.CheckedChanged += agree_CheckedChanged;
            // 
            // nextForm
            // 
            nextForm.Enabled = false;
            nextForm.Location = new Point(23, 225);
            nextForm.Name = "nextForm";
            nextForm.Size = new Size(94, 29);
            nextForm.TabIndex = 3;
            nextForm.Text = "下一步";
            nextForm.UseVisualStyleBackColor = true;
            nextForm.Click += nextForm_Click;
            // 
            // back
            // 
            back.Location = new Point(132, 225);
            back.Name = "back";
            back.Size = new Size(94, 29);
            back.TabIndex = 4;
            back.Text = "回上一步";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // exit
            // 
            exit.Location = new Point(245, 225);
            exit.Name = "exit";
            exit.Size = new Size(94, 29);
            exit.TabIndex = 5;
            exit.Text = "結束";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // button4
            // 
            button4.Location = new Point(376, 145);
            button4.Name = "button4";
            button4.Size = new Size(8, 8);
            button4.TabIndex = 6;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 293);
            Controls.Add(button4);
            Controls.Add(exit);
            Controls.Add(back);
            Controls.Add(nextForm);
            Controls.Add(agree);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "程式語言理論與實務";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private CheckBox agree;
        private Button nextForm;
        private Button back;
        private Button exit;
        private Button button4;
    }
}