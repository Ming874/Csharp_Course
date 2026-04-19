namespace W6
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
            genBtn = new Button();
            inputTb = new TextBox();
            countTb = new TextBox();
            resultTb = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 53);
            label1.Name = "label1";
            label1.Size = new Size(88, 25);
            label1.TabIndex = 0;
            label1.Text = "輸入字串";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 140);
            label2.Name = "label2";
            label2.Size = new Size(126, 25);
            label2.TabIndex = 1;
            label2.Text = "排列組合數量";
            // 
            // genBtn
            // 
            genBtn.Location = new Point(67, 92);
            genBtn.Name = "genBtn";
            genBtn.Size = new Size(345, 34);
            genBtn.TabIndex = 2;
            genBtn.Text = "產生排列組合";
            genBtn.UseVisualStyleBackColor = true;
            genBtn.Click += genBtn_Click;
            // 
            // inputTb
            // 
            inputTb.Location = new Point(161, 50);
            inputTb.Name = "inputTb";
            inputTb.Size = new Size(251, 31);
            inputTb.TabIndex = 3;
            // 
            // countTb
            // 
            countTb.Location = new Point(199, 140);
            countTb.Name = "countTb";
            countTb.ReadOnly = true;
            countTb.Size = new Size(213, 31);
            countTb.TabIndex = 4;
            // 
            // resultTb
            // 
            resultTb.Location = new Point(67, 194);
            resultTb.Multiline = true;
            resultTb.Name = "resultTb";
            resultTb.ReadOnly = true;
            resultTb.ScrollBars = ScrollBars.Vertical;
            resultTb.Size = new Size(345, 452);
            resultTb.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 696);
            Controls.Add(resultTb);
            Controls.Add(countTb);
            Controls.Add(inputTb);
            Controls.Add(genBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "排列組合";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button genBtn;
        private TextBox inputTb;
        private TextBox countTb;
        private TextBox resultTb;
    }
}
