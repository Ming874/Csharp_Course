namespace W1
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
            exit = new Button();
            label1 = new Label();
            label2 = new Label();
            nextForm = new Button();
            label3 = new Label();
            account = new TextBox();
            password = new TextBox();
            passwordCheck = new TextBox();
            SuspendLayout();
            // 
            // exit
            // 
            exit.Location = new Point(145, 164);
            exit.Name = "exit";
            exit.Size = new Size(94, 29);
            exit.TabIndex = 0;
            exit.Text = "結束";
            exit.UseVisualStyleBackColor = true;
            exit.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 52);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 1;
            label1.Text = "輸入帳號";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 85);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 2;
            label2.Text = "輸入密碼";
            // 
            // nextForm
            // 
            nextForm.Enabled = false;
            nextForm.Location = new Point(23, 164);
            nextForm.Name = "nextForm";
            nextForm.Size = new Size(94, 29);
            nextForm.TabIndex = 3;
            nextForm.Text = "下一步";
            nextForm.UseVisualStyleBackColor = true;
            nextForm.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 117);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 4;
            label3.Text = "密碼確認";
            label3.Visible = false;
            label3.Click += label3_Click;
            // 
            // account
            // 
            account.Location = new Point(102, 49);
            account.Name = "account";
            account.Size = new Size(125, 27);
            account.TabIndex = 5;
            account.TextChanged += account_TextChanged;
            // 
            // password
            // 
            password.Location = new Point(102, 82);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(125, 27);
            password.TabIndex = 6;
            password.TextChanged += password_status;
            // 
            // passwordCheck
            // 
            passwordCheck.Location = new Point(102, 114);
            passwordCheck.Name = "passwordCheck";
            passwordCheck.PasswordChar = '*';
            passwordCheck.Size = new Size(125, 27);
            passwordCheck.TabIndex = 7;
            passwordCheck.Visible = false;
            passwordCheck.TextChanged += password_status;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 241);
            Controls.Add(passwordCheck);
            Controls.Add(password);
            Controls.Add(account);
            Controls.Add(label3);
            Controls.Add(nextForm);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(exit);
            Name = "Form1";
            Text = "註冊帳號和密碼";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button exit;
        private Label label1;
        private Label label2;
        private Button nextForm;
        private Label label3;
        private TextBox account;
        private TextBox password;
        private TextBox passwordCheck;
    }
}
