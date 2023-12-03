namespace userForm
{
    partial class FormAwal
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
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(154, 19);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(293, 59);
            label1.TabIndex = 0;
            label1.Text = "VirtualCheck";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Firebrick;
            button1.Cursor = Cursors.Hand;
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(626, 367);
            button1.Margin = new Padding(4, 2, 4, 2);
            button1.Name = "button1";
            button1.Size = new Size(334, 96);
            button1.TabIndex = 1;
            button1.Text = "Doctor";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.IndianRed;
            button2.Cursor = Cursors.Hand;
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(626, 499);
            button2.Margin = new Padding(4, 2, 4, 2);
            button2.Name = "button2";
            button2.Size = new Size(334, 96);
            button2.TabIndex = 2;
            button2.Text = "Patient";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(748, 299);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(276, 45);
            label2.TabIndex = 3;
            label2.Text = "Please Select One";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.VC2;
            pictureBox1.Location = new Point(28, 19);
            pictureBox1.Margin = new Padding(6, 6, 6, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._10130;
            pictureBox2.Location = new Point(-15, 164);
            pictureBox2.Margin = new Padding(6, 6, 6, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(659, 499);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.doctor;
            pictureBox3.Location = new Point(969, 367);
            pictureBox3.Margin = new Padding(6, 6, 6, 6);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(89, 92);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources.medical;
            pictureBox4.Location = new Point(969, 503);
            pictureBox4.Margin = new Padding(6, 6, 6, 6);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(89, 92);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(693, 209);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(373, 65);
            label3.TabIndex = 9;
            label3.Text = "Welcome Back!";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 693);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(142, 32);
            label4.TabIndex = 10;
            label4.Text = "Haikal Hilmi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 725);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(352, 32);
            label5.TabIndex = 11;
            label5.Text = "Johanes de Britto Krisna Arianta";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Hiasan_1;
            pictureBox5.Location = new Point(845, 0);
            pictureBox5.Margin = new Padding(6, 6, 6, 6);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(305, 252);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 12;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.ErrorImage = Properties.Resources.Hiasan_2;
            pictureBox6.Image = Properties.Resources.Hiasan_2;
            pictureBox6.Location = new Point(890, 503);
            pictureBox6.Margin = new Padding(6, 6, 6, 6);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(334, 326);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 13;
            pictureBox6.TabStop = false;
            // 
            // FormAwal
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1146, 777);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox6);
            Margin = new Padding(4, 2, 4, 2);
            Name = "FormAwal";
            Text = "FormAwal";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
    }
}