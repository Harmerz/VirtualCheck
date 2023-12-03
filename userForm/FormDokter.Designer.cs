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
            btnLogOutDokter = new Button();
            pictureBox5 = new PictureBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            pictureBox4 = new PictureBox();
            dgvData = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // btnLogOutDokter
            // 
            btnLogOutDokter.BackColor = Color.Firebrick;
            btnLogOutDokter.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogOutDokter.ForeColor = Color.White;
            btnLogOutDokter.Location = new Point(621, 437);
            btnLogOutDokter.Margin = new Padding(2, 1, 2, 1);
            btnLogOutDokter.Name = "btnLogOutDokter";
            btnLogOutDokter.Size = new Size(156, 65);
            btnLogOutDokter.TabIndex = 6;
            btnLogOutDokter.Text = "Log Out";
            btnLogOutDokter.UseVisualStyleBackColor = false;
            btnLogOutDokter.Click += btnLogOutDokter_Click_1;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Hiasan_1;
            pictureBox5.Location = new Point(639, -11);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(234, 141);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 13;
            pictureBox5.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(76, 7);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(151, 30);
            label4.TabIndex = 14;
            label4.Text = "VirtualCheck";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.VC2;
            pictureBox1.Location = new Point(8, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(76, 180);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(146, 30);
            label7.TabIndex = 28;
            label7.Text = "Patients' Lists";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            label7.Click += label7_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Hiasan_3;
            pictureBox4.Location = new Point(-24, 302);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(295, 277);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 29;
            pictureBox4.TabStop = false;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(76, 220);
            dgvData.Margin = new Padding(2, 1, 2, 1);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 82;
            dgvData.RowTemplate.Height = 41;
            dgvData.Size = new Size(701, 201);
            dgvData.TabIndex = 30;
            dgvData.CellClick += dgvData_CellClick;
            // 
            // button1
            // 
            button1.BackColor = Color.Firebrick;
            button1.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(621, 142);
            button1.Margin = new Padding(2, 1, 2, 1);
            button1.Name = "button1";
            button1.Size = new Size(156, 65);
            button1.TabIndex = 31;
            button1.Text = "Done";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Firebrick;
            button2.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(453, 142);
            button2.Margin = new Padding(2, 1, 2, 1);
            button2.Name = "button2";
            button2.Size = new Size(156, 65);
            button2.TabIndex = 32;
            button2.Text = "Load Data";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // FormDokter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(852, 525);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgvData);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox5);
            Controls.Add(btnLogOutDokter);
            Controls.Add(pictureBox4);
            Margin = new Padding(2, 1, 2, 1);
            Name = "FormDokter";
            Text = "FormDokter";
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLogOutDokter;
        private PictureBox pictureBox5;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label7;
        private PictureBox pictureBox4;
        private DataGridView dgvData;
        private Button button1;
        private Button button2;
    }
}