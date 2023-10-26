namespace userForm
{
    partial class FormPasien
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
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            comboBox1 = new ComboBox();
            label6 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(531, 1022);
            button1.Name = "button1";
            button1.Size = new Size(310, 46);
            button1.TabIndex = 0;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(654, 180);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(414, 39);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(350, 180);
            label1.Name = "label1";
            label1.Size = new Size(77, 32);
            label1.TabIndex = 3;
            label1.Text = "Nama";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(350, 262);
            label2.Name = "label2";
            label2.Size = new Size(73, 32);
            label2.TabIndex = 4;
            label2.Text = "Umur";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(350, 347);
            label3.Name = "label3";
            label3.Size = new Size(88, 32);
            label3.TabIndex = 5;
            label3.Text = "Alamat";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(350, 431);
            label4.Name = "label4";
            label4.Size = new Size(159, 32);
            label4.TabIndex = 6;
            label4.Text = "Jenis Kelamin";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(350, 512);
            label5.Name = "label5";
            label5.Size = new Size(58, 32);
            label5.TabIndex = 7;
            label5.Text = "Telp";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(654, 262);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(414, 39);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(654, 347);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(414, 39);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(654, 512);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(414, 39);
            textBox4.TabIndex = 10;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(654, 428);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(414, 40);
            comboBox1.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(350, 601);
            label6.Name = "label6";
            label6.Size = new Size(101, 32);
            label6.TabIndex = 12;
            label6.Text = "Keluhan";
            label6.Click += label6_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(654, 601);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.ScrollBars = ScrollBars.Vertical;
            textBox5.Size = new Size(414, 259);
            textBox5.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(531, 58);
            label7.Name = "label7";
            label7.Size = new Size(310, 32);
            label7.TabIndex = 14;
            label7.Text = "Form Data Diri dan Keluhan";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // FormPasien
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1374, 1146);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "FormPasien";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private ComboBox comboBox1;
        private Label label6;
        private TextBox textBox5;
        private Label label7;
    }
}