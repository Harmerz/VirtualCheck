namespace userForm
{
    partial class FormDokter
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
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            btnLogOutDokter = new Button();
            pictureBox5 = new PictureBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(288, 205);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(233, 45);
            label2.TabIndex = 1;
            label2.Text = "Keluhan Pasien";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.Location = new Point(563, 205);
            textBox1.Margin = new Padding(4, 2, 4, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(800, 435);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(288, 704);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(184, 45);
            label3.TabIndex = 3;
            label3.Text = "Data Pasien";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Control;
            textBox2.Location = new Point(563, 698);
            textBox2.Margin = new Padding(4, 2, 4, 2);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(800, 200);
            textBox2.TabIndex = 4;
            // 
            // btnLogOutDokter
            // 
            btnLogOutDokter.BackColor = Color.Firebrick;
            btnLogOutDokter.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogOutDokter.ForeColor = Color.White;
            btnLogOutDokter.Location = new Point(1074, 962);
            btnLogOutDokter.Margin = new Padding(4, 2, 4, 2);
            btnLogOutDokter.Name = "btnLogOutDokter";
            btnLogOutDokter.Size = new Size(289, 138);
            btnLogOutDokter.TabIndex = 6;
            btnLogOutDokter.Text = "Log Out";
            btnLogOutDokter.UseVisualStyleBackColor = false;
            btnLogOutDokter.Click += btnLogOutDokter_Click_1;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Hiasan_1;
            pictureBox5.Location = new Point(1122, -23);
            pictureBox5.Margin = new Padding(6);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(499, 356);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 13;
            pictureBox5.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(141, 15);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(293, 59);
            label4.TabIndex = 14;
            label4.Text = "VirtualCheck";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.VC2;
            pictureBox1.Location = new Point(15, 15);
            pictureBox1.Margin = new Padding(6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(288, 107);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(365, 57);
            label7.TabIndex = 28;
            label7.Text = "Konsultasi Pasien";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Hiasan_3;
            pictureBox4.Location = new Point(-45, 645);
            pictureBox4.Margin = new Padding(6);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(548, 590);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 29;
            pictureBox4.TabStop = false;
            // 
            // FormDokter
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1582, 1175);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(pictureBox5);
            Controls.Add(btnLogOutDokter);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox4);
            Margin = new Padding(4, 2, 4, 2);
            Name = "FormDokter";
            Text = "FormDokter";
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Button btnLogOutDokter;
        private PictureBox pictureBox5;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label7;
        private PictureBox pictureBox4;
    }
}