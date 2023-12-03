namespace userForm
{
    partial class FormAdmin
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            btnLogOutAdmin = new Button();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(474, 297);
            button1.Name = "button1";
            button1.Size = new Size(299, 82);
            button1.TabIndex = 1;
            button1.Text = "Data Pasien";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(474, 426);
            button2.Name = "button2";
            button2.Size = new Size(299, 82);
            button2.TabIndex = 2;
            button2.Text = "Data Dokter";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(474, 556);
            button3.Name = "button3";
            button3.Size = new Size(299, 82);
            button3.TabIndex = 3;
            button3.Text = "Data Klinik";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(474, 680);
            button4.Name = "button4";
            button4.Size = new Size(299, 82);
            button4.TabIndex = 4;
            button4.Text = "Data Booking";
            button4.UseVisualStyleBackColor = true;
            // 
            // btnLogOutAdmin
            // 
            btnLogOutAdmin.BackColor = Color.Firebrick;
            btnLogOutAdmin.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogOutAdmin.ForeColor = Color.White;
            btnLogOutAdmin.Location = new Point(474, 811);
            btnLogOutAdmin.Name = "btnLogOutAdmin";
            btnLogOutAdmin.Size = new Size(299, 135);
            btnLogOutAdmin.TabIndex = 5;
            btnLogOutAdmin.Text = "Log Out";
            btnLogOutAdmin.UseVisualStyleBackColor = false;
            btnLogOutAdmin.Click += btnLogOutAdmin_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(141, 15);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(293, 59);
            label4.TabIndex = 16;
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
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(493, 163);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(265, 57);
            label7.TabIndex = 29;
            label7.Text = "Admin Page";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1260, 1065);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(btnLogOutAdmin);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FormAdmin";
            Text = "FormAdmin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button btnLogOutAdmin;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label7;
    }
}