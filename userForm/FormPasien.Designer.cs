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
            txtNama = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtUmur = new TextBox();
            txtAlamat = new TextBox();
            txtTelp = new TextBox();
            cbKelamin = new ComboBox();
            label6 = new Label();
            txtKeluhan = new TextBox();
            label7 = new Label();
            btnLogOutPasien = new Button();
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
            button1.Click += button1_Click;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(654, 180);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(414, 39);
            txtNama.TabIndex = 2;
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
            // txtUmur
            // 
            txtUmur.Location = new Point(654, 262);
            txtUmur.Name = "txtUmur";
            txtUmur.Size = new Size(414, 39);
            txtUmur.TabIndex = 8;
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(654, 347);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(414, 39);
            txtAlamat.TabIndex = 9;
            // 
            // txtTelp
            // 
            txtTelp.Location = new Point(654, 512);
            txtTelp.Name = "txtTelp";
            txtTelp.Size = new Size(414, 39);
            txtTelp.TabIndex = 10;
            // 
            // cbKelamin
            // 
            cbKelamin.FormattingEnabled = true;
            cbKelamin.Location = new Point(654, 428);
            cbKelamin.Name = "cbKelamin";
            cbKelamin.Size = new Size(414, 40);
            cbKelamin.TabIndex = 11;
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
            // txtKeluhan
            // 
            txtKeluhan.Location = new Point(654, 601);
            txtKeluhan.Multiline = true;
            txtKeluhan.Name = "txtKeluhan";
            txtKeluhan.ScrollBars = ScrollBars.Vertical;
            txtKeluhan.Size = new Size(414, 259);
            txtKeluhan.TabIndex = 13;
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
            // btnLogOutPasien
            // 
            btnLogOutPasien.Location = new Point(531, 1116);
            btnLogOutPasien.Name = "btnLogOutPasien";
            btnLogOutPasien.Size = new Size(310, 46);
            btnLogOutPasien.TabIndex = 15;
            btnLogOutPasien.Text = "Log Out";
            btnLogOutPasien.UseVisualStyleBackColor = true;
            btnLogOutPasien.Click += btnLogOutPasien_Click_1;
            // 
            // FormPasien
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1374, 1245);
            Controls.Add(btnLogOutPasien);
            Controls.Add(label7);
            Controls.Add(txtKeluhan);
            Controls.Add(label6);
            Controls.Add(cbKelamin);
            Controls.Add(txtTelp);
            Controls.Add(txtAlamat);
            Controls.Add(txtUmur);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNama);
            Controls.Add(button1);
            Name = "FormPasien";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtNama;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtUmur;
        private TextBox txtAlamat;
        private TextBox txtTelp;
        private ComboBox cbKelamin;
        private Label label6;
        private TextBox txtKeluhan;
        private Label label7;
        private Button btnLogOutPasien;
    }
}