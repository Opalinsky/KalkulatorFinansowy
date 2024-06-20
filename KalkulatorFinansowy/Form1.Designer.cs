namespace KalkulatorFinansowy
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox5 = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            textBox4 = new TextBox();
            label7 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            imageList1 = new ImageList(components);
            label12 = new Label();
            label13 = new Label();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(288, 334);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "Przycisk 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(327, 75);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 233);
            label1.Name = "label1";
            label1.Size = new Size(151, 25);
            label1.TabIndex = 3;
            label1.Text = "Wysokość wpłaty";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 75);
            label2.Name = "label2";
            label2.Size = new Size(263, 25);
            label2.TabIndex = 4;
            label2.Text = "Jak długo będziesz oszczędzać?";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 183);
            label3.Name = "label3";
            label3.Size = new Size(177, 25);
            label3.TabIndex = 5;
            label3.Text = "Roczna stopa zwrotu";
            label3.Click += label3_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(532, 233);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(190, 33);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(272, 9);
            label4.Name = "label4";
            label4.Size = new Size(218, 25);
            label4.TabIndex = 7;
            label4.Text = "Podaj szczegóły inwestycji";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(483, 75);
            label5.Name = "label5";
            label5.Size = new Size(31, 25);
            label5.TabIndex = 8;
            label5.Text = "lat";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(58, 131);
            label6.Name = "label6";
            label6.Size = new Size(137, 25);
            label6.TabIndex = 9;
            label6.Text = "Pierwsza wpłata";
            label6.Click += label6_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(247, 131);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(204, 31);
            textBox2.TabIndex = 10;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(247, 183);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(204, 31);
            textBox3.TabIndex = 11;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(247, 233);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(204, 31);
            textBox5.TabIndex = 13;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // textBox4
            // 
            textBox4.Location = new Point(344, 386);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(161, 31);
            textBox4.TabIndex = 16;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(188, 386);
            label7.Name = "label7";
            label7.Size = new Size(150, 25);
            label7.TabIndex = 17;
            label7.Text = "Wynik inwestycji: ";
            label7.Click += label7_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(0, 0);
            label9.Name = "label9";
            label9.Size = new Size(0, 25);
            label9.TabIndex = 19;
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(457, 131);
            label10.Name = "label10";
            label10.Size = new Size(69, 25);
            label10.TabIndex = 20;
            label10.Text = "złotych";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(457, 189);
            label11.Name = "label11";
            label11.Size = new Size(27, 25);
            label11.TabIndex = 21;
            label11.Text = "%";
            label11.Click += label11_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(457, 236);
            label12.Name = "label12";
            label12.Size = new Size(69, 25);
            label12.TabIndex = 22;
            label12.Text = "złotych";
            label12.Click += label12_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(518, 391);
            label13.Name = "label13";
            label13.Size = new Size(69, 25);
            label13.TabIndex = 24;
            label13.Text = "złotych";
            label13.Click += label13_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(58, 294);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(207, 29);
            checkBox1.TabIndex = 26;
            checkBox1.Text = "Uwzględnić podatek?";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox1);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(textBox4);
            Controls.Add(textBox5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox5;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox textBox4;
        private Label label7;
        private Label label9;
        private Label label10;
        private Label label11;
        private ImageList imageList1;
        private Label label12;
        private Label label13;
        private CheckBox checkBox1;
    }
}
