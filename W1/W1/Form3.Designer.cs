namespace W1
{
    partial class Form3
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            main3 = new CheckBox();
            main4 = new CheckBox();
            main2 = new CheckBox();
            main1 = new CheckBox();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            totalPrice = new TextBox();
            groupBox2 = new GroupBox();
            smallFries = new RadioButton();
            bigFries = new RadioButton();
            chFries = new CheckBox();
            groupBox3 = new GroupBox();
            coffee = new RadioButton();
            blacktea = new RadioButton();
            cola = new RadioButton();
            chDrink = new CheckBox();
            back = new Button();
            exit = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(main3);
            groupBox1.Controls.Add(main4);
            groupBox1.Controls.Add(main2);
            groupBox1.Controls.Add(main1);
            groupBox1.Location = new Point(42, 34);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(176, 218);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "主餐";
            // 
            // main3
            // 
            main3.AutoSize = true;
            main3.Location = new Point(29, 116);
            main3.Margin = new Padding(2);
            main3.Name = "main3";
            main3.Size = new Size(107, 24);
            main3.TabIndex = 3;
            main3.Tag = "59";
            main3.Text = "麥香雞 $59";
            main3.UseVisualStyleBackColor = true;
            main3.CheckedChanged += UpdateTotal;
            // 
            // main4
            // 
            main4.AutoSize = true;
            main4.Location = new Point(29, 154);
            main4.Margin = new Padding(2);
            main4.Name = "main4";
            main4.Size = new Size(91, 24);
            main4.TabIndex = 2;
            main4.Tag = "79";
            main4.Text = "炸雞 $79";
            main4.UseVisualStyleBackColor = true;
            main4.CheckedChanged += UpdateTotal;
            // 
            // main2
            // 
            main2.AutoSize = true;
            main2.Location = new Point(29, 79);
            main2.Margin = new Padding(2);
            main2.Name = "main2";
            main2.Size = new Size(107, 24);
            main2.TabIndex = 1;
            main2.Tag = "49";
            main2.Text = "麥香雞 $49";
            main2.UseVisualStyleBackColor = true;
            main2.CheckedChanged += UpdateTotal;
            // 
            // main1
            // 
            main1.AutoSize = true;
            main1.Location = new Point(29, 43);
            main1.Margin = new Padding(2);
            main1.Name = "main1";
            main1.Size = new Size(139, 24);
            main1.TabIndex = 0;
            main1.Tag = "69";
            main1.Text = "雙層吉士堡 $69";
            main1.UseVisualStyleBackColor = true;
            main1.CheckedChanged += UpdateTotal;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 270);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 1;
            label1.Text = "總價";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // totalPrice
            // 
            totalPrice.Location = new Point(95, 267);
            totalPrice.Margin = new Padding(2);
            totalPrice.Name = "totalPrice";
            totalPrice.ReadOnly = true;
            totalPrice.Size = new Size(124, 27);
            totalPrice.TabIndex = 3;
            totalPrice.Text = "0";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(smallFries);
            groupBox2.Controls.Add(bigFries);
            groupBox2.Controls.Add(chFries);
            groupBox2.Location = new Point(250, 34);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(175, 102);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "薯條";
            // 
            // smallFries
            // 
            smallFries.AutoSize = true;
            smallFries.Enabled = false;
            smallFries.Location = new Point(34, 63);
            smallFries.Margin = new Padding(2);
            smallFries.Name = "smallFries";
            smallFries.Size = new Size(90, 24);
            smallFries.TabIndex = 6;
            smallFries.TabStop = true;
            smallFries.Tag = "25";
            smallFries.Text = "小薯 $25";
            smallFries.UseVisualStyleBackColor = true;
            smallFries.CheckedChanged += UpdateTotal;
            // 
            // bigFries
            // 
            bigFries.AutoSize = true;
            bigFries.Enabled = false;
            bigFries.Location = new Point(34, 28);
            bigFries.Margin = new Padding(2);
            bigFries.Name = "bigFries";
            bigFries.Size = new Size(90, 24);
            bigFries.TabIndex = 5;
            bigFries.TabStop = true;
            bigFries.Tag = "35";
            bigFries.Text = "大薯 $35";
            bigFries.UseVisualStyleBackColor = true;
            bigFries.CheckedChanged += UpdateTotal;
            // 
            // chFries
            // 
            chFries.AutoSize = true;
            chFries.Location = new Point(5, 0);
            chFries.Margin = new Padding(2);
            chFries.Name = "chFries";
            chFries.Size = new Size(63, 24);
            chFries.TabIndex = 4;
            chFries.Text = "薯條";
            chFries.UseVisualStyleBackColor = true;
            chFries.CheckedChanged += chFries_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(coffee);
            groupBox3.Controls.Add(blacktea);
            groupBox3.Controls.Add(cola);
            groupBox3.Controls.Add(chDrink);
            groupBox3.Location = new Point(250, 157);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(175, 135);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "飲料";
            // 
            // coffee
            // 
            coffee.AutoSize = true;
            coffee.Enabled = false;
            coffee.Location = new Point(34, 86);
            coffee.Margin = new Padding(2);
            coffee.Name = "coffee";
            coffee.Size = new Size(90, 24);
            coffee.TabIndex = 9;
            coffee.TabStop = true;
            coffee.Tag = "45";
            coffee.Text = "咖啡 $45";
            coffee.UseVisualStyleBackColor = true;
            coffee.CheckedChanged += UpdateTotal;
            // 
            // blacktea
            // 
            blacktea.AutoSize = true;
            blacktea.Enabled = false;
            blacktea.Location = new Point(34, 58);
            blacktea.Margin = new Padding(2);
            blacktea.Name = "blacktea";
            blacktea.Size = new Size(90, 24);
            blacktea.TabIndex = 8;
            blacktea.TabStop = true;
            blacktea.Tag = "25";
            blacktea.Text = "紅茶 $25";
            blacktea.UseVisualStyleBackColor = true;
            blacktea.CheckedChanged += UpdateTotal;
            // 
            // cola
            // 
            cola.AutoSize = true;
            cola.Enabled = false;
            cola.Location = new Point(34, 30);
            cola.Margin = new Padding(2);
            cola.Name = "cola";
            cola.Size = new Size(90, 24);
            cola.TabIndex = 7;
            cola.TabStop = true;
            cola.Tag = "35";
            cola.Text = "可樂 $35";
            cola.UseVisualStyleBackColor = true;
            cola.CheckedChanged += UpdateTotal;
            // 
            // chDrink
            // 
            chDrink.AutoSize = true;
            chDrink.Location = new Point(0, 0);
            chDrink.Margin = new Padding(2);
            chDrink.Name = "chDrink";
            chDrink.Size = new Size(63, 24);
            chDrink.TabIndex = 3;
            chDrink.Text = "飲料";
            chDrink.UseVisualStyleBackColor = true;
            chDrink.CheckedChanged += chDrink_CheckedChanged;
            // 
            // back
            // 
            back.Location = new Point(54, 325);
            back.Margin = new Padding(2);
            back.Name = "back";
            back.Size = new Size(165, 27);
            back.TabIndex = 5;
            back.Text = "回上一步";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // exit
            // 
            exit.Location = new Point(231, 325);
            exit.Margin = new Padding(2);
            exit.Name = "exit";
            exit.Size = new Size(165, 27);
            exit.TabIndex = 6;
            exit.Text = "結束";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 396);
            Controls.Add(exit);
            Controls.Add(back);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(totalPrice);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Form3";
            Text = "點餐系統";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox totalPrice;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private CheckBox main4;
        private CheckBox main2;
        private CheckBox main1;
        private CheckBox chFries;
        private CheckBox chDrink;
        private Button back;
        private Button exit;
        private CheckBox main3;
        private RadioButton smallFries;
        private RadioButton bigFries;
        private RadioButton coffee;
        private RadioButton blacktea;
        private RadioButton cola;
    }
}