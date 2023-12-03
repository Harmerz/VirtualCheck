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
            btnLogOutAdmin = new Button();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            dgvDataPasien = new DataGridView();
            dgvDataDokter = new DataGridView();
            btnPasien = new Button();
            btnDokter = new Button();
            label1 = new Label();
            label2 = new Label();
            btnDeletePasien = new Button();
            btnDeleteDokter = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDataPasien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDataDokter).BeginInit();
            SuspendLayout();
            // 
            // btnLogOutAdmin
            // 
            btnLogOutAdmin.BackColor = Color.Firebrick;
            btnLogOutAdmin.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogOutAdmin.ForeColor = Color.White;
            btnLogOutAdmin.Location = new Point(1393, 990);
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
            label7.Location = new Point(1427, 17);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(265, 57);
            label7.TabIndex = 29;
            label7.Text = "Admin Page";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // dgvDataPasien
            // 
            dgvDataPasien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDataPasien.Location = new Point(362, 211);
            dgvDataPasien.Name = "dgvDataPasien";
            dgvDataPasien.RowHeadersWidth = 82;
            dgvDataPasien.RowTemplate.Height = 41;
            dgvDataPasien.Size = new Size(1330, 300);
            dgvDataPasien.TabIndex = 30;
            dgvDataPasien.CellClick += dgvDataPasien_CellClick;
            // 
            // dgvDataDokter
            // 
            dgvDataDokter.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDataDokter.Location = new Point(362, 621);
            dgvDataDokter.Name = "dgvDataDokter";
            dgvDataDokter.RowHeadersWidth = 82;
            dgvDataDokter.RowTemplate.Height = 41;
            dgvDataDokter.Size = new Size(1330, 300);
            dgvDataDokter.TabIndex = 31;
            dgvDataDokter.CellClick += dgvDataDokter_CellClick;
            // 
            // btnPasien
            // 
            btnPasien.BackColor = Color.Firebrick;
            btnPasien.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnPasien.ForeColor = Color.White;
            btnPasien.Location = new Point(28, 434);
            btnPasien.Name = "btnPasien";
            btnPasien.Size = new Size(299, 77);
            btnPasien.TabIndex = 32;
            btnPasien.Text = "Load Data";
            btnPasien.UseVisualStyleBackColor = false;
            btnPasien.Click += btnPasien_Click;
            // 
            // btnDokter
            // 
            btnDokter.BackColor = Color.Firebrick;
            btnDokter.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnDokter.ForeColor = Color.White;
            btnDokter.Location = new Point(28, 844);
            btnDokter.Name = "btnDokter";
            btnDokter.Size = new Size(299, 77);
            btnDokter.TabIndex = 33;
            btnDokter.Text = "Load Data";
            btnDokter.UseVisualStyleBackColor = false;
            btnDokter.Click += btnDokter_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(28, 211);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(256, 57);
            label1.TabIndex = 34;
            label1.Text = "Data Pasien";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(28, 621);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(266, 57);
            label2.TabIndex = 35;
            label2.Text = "Data Dokter";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnDeletePasien
            // 
            btnDeletePasien.BackColor = Color.Firebrick;
            btnDeletePasien.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeletePasien.ForeColor = Color.White;
            btnDeletePasien.Location = new Point(28, 351);
            btnDeletePasien.Name = "btnDeletePasien";
            btnDeletePasien.Size = new Size(299, 77);
            btnDeletePasien.TabIndex = 36;
            btnDeletePasien.Text = "Delete";
            btnDeletePasien.UseVisualStyleBackColor = false;
            btnDeletePasien.Click += btnDeletePasien_Click;
            // 
            // btnDeleteDokter
            // 
            btnDeleteDokter.BackColor = Color.Firebrick;
            btnDeleteDokter.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteDokter.ForeColor = Color.White;
            btnDeleteDokter.Location = new Point(28, 761);
            btnDeleteDokter.Name = "btnDeleteDokter";
            btnDeleteDokter.Size = new Size(299, 77);
            btnDeleteDokter.TabIndex = 37;
            btnDeleteDokter.Text = "Delete";
            btnDeleteDokter.UseVisualStyleBackColor = false;
            btnDeleteDokter.Click += btnDeleteDokter_Click;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1725, 1158);
            Controls.Add(btnDeleteDokter);
            Controls.Add(btnDeletePasien);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDokter);
            Controls.Add(btnPasien);
            Controls.Add(dgvDataDokter);
            Controls.Add(dgvDataPasien);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(btnLogOutAdmin);
            Name = "FormAdmin";
            Text = "FormAdmin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDataPasien).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDataDokter).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLogOutAdmin;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label7;
        private DataGridView dgvDataPasien;
        private DataGridView dgvDataDokter;
        private Button btnPasien;
        private Button btnDokter;
        private Label label1;
        private Label label2;
        private Button btnDeletePasien;
        private Button btnDeleteDokter;
    }
}