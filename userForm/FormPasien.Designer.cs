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
            label8 = new Label();
            pictureBox6 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            back = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Firebrick;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(917, 1193);
            button1.Margin = new Padding(4, 2, 4, 2);
            button1.Name = "button1";
            button1.Size = new Size(531, 68);
            button1.TabIndex = 0;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtNama
            // 
            txtNama.BackColor = SystemColors.Control;
            txtNama.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNama.Location = new Point(921, 250);
            txtNama.Margin = new Padding(4, 2, 4, 2);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(524, 50);
            txtNama.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(917, 198);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(105, 45);
            label1.TabIndex = 3;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(917, 329);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 45);
            label2.TabIndex = 4;
            label2.Text = "Age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(917, 474);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(135, 45);
            label3.TabIndex = 5;
            label3.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(917, 602);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(69, 45);
            label4.TabIndex = 6;
            label4.Text = "Sex";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(921, 732);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(236, 45);
            label5.TabIndex = 7;
            label5.Text = "Phone Number";
            // 
            // txtUmur
            // 
            txtUmur.BackColor = SystemColors.Control;
            txtUmur.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUmur.Location = new Point(917, 384);
            txtUmur.Margin = new Padding(4, 2, 4, 2);
            txtUmur.Name = "txtUmur";
            txtUmur.Size = new Size(528, 50);
            txtUmur.TabIndex = 8;
            // 
            // txtAlamat
            // 
            txtAlamat.BackColor = SystemColors.Control;
            txtAlamat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAlamat.Location = new Point(917, 523);
            txtAlamat.Margin = new Padding(4, 2, 4, 2);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(528, 50);
            txtAlamat.TabIndex = 9;
            // 
            // txtTelp
            // 
            txtTelp.BackColor = SystemColors.Control;
            txtTelp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelp.Location = new Point(917, 781);
            txtTelp.Margin = new Padding(4, 2, 4, 2);
            txtTelp.Name = "txtTelp";
            txtTelp.Size = new Size(528, 50);
            txtTelp.TabIndex = 10;
            // 
            // cbKelamin
            // 
            cbKelamin.BackColor = SystemColors.Control;
            cbKelamin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbKelamin.FormattingEnabled = true;
            cbKelamin.Items.AddRange(new object[] { "Male", "Female" });
            cbKelamin.Location = new Point(917, 649);
            cbKelamin.Margin = new Padding(4, 2, 4, 2);
            cbKelamin.Name = "cbKelamin";
            cbKelamin.Size = new Size(528, 53);
            cbKelamin.TabIndex = 11;
            cbKelamin.SelectedIndexChanged += cbKelamin_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(921, 862);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(170, 45);
            label6.TabIndex = 12;
            label6.Text = "Symptoms";
            label6.Click += label6_Click;
            // 
            // txtKeluhan
            // 
            txtKeluhan.BackColor = SystemColors.Control;
            txtKeluhan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtKeluhan.Location = new Point(921, 915);
            txtKeluhan.Margin = new Padding(4, 2, 4, 2);
            txtKeluhan.Multiline = true;
            txtKeluhan.Name = "txtKeluhan";
            txtKeluhan.ScrollBars = ScrollBars.Vertical;
            txtKeluhan.Size = new Size(524, 260);
            txtKeluhan.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(917, 102);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(340, 57);
            label7.TabIndex = 14;
            label7.Text = "Fill In This Form";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Black", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(137, 19);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(293, 59);
            label8.TabIndex = 16;
            label8.Text = "VirtualCheck";
            // 
            // pictureBox6
            // 
            pictureBox6.ErrorImage = null;
            pictureBox6.Image = Properties.Resources.VC2;
            pictureBox6.Location = new Point(11, 19);
            pictureBox6.Margin = new Padding(6, 6, 6, 6);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(117, 79);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 17;
            pictureBox6.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.appoiment_2;
            pictureBox1.Location = new Point(11, 111);
            pictureBox1.Margin = new Padding(6, 6, 6, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(836, 1150);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = Properties.Resources.Hiasan_4;
            pictureBox2.Image = Properties.Resources.Hiasan_4;
            pictureBox2.Location = new Point(1053, 862);
            pictureBox2.Margin = new Padding(6, 6, 6, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(585, 612);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Hiasan_3;
            pictureBox3.Location = new Point(-7, 1193);
            pictureBox3.Margin = new Padding(6, 6, 6, 6);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(492, 416);
            pictureBox3.TabIndex = 20;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Hiasan_1;
            pictureBox4.Location = new Point(1320, -21);
            pictureBox4.Margin = new Padding(6, 6, 6, 6);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(262, 247);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 21;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Hiasan_2;
            pictureBox5.Location = new Point(1382, 354);
            pictureBox5.Margin = new Padding(6, 6, 6, 6);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(282, 393);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 22;
            pictureBox5.TabStop = false;
            // 
            // back
            // 
            back.AutoSize = true;
            back.BackColor = Color.White;
            back.Cursor = Cursors.Hand;
            back.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            back.ForeColor = Color.Firebrick;
            back.Location = new Point(314, 1244);
            back.Margin = new Padding(6, 0, 6, 0);
            back.Name = "back";
            back.Size = new Size(88, 45);
            back.TabIndex = 23;
            back.Text = "Back";
            back.Click += back_Click;
            // 
            // FormPasien
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1571, 1363);
            Controls.Add(back);
            Controls.Add(pictureBox3);
            Controls.Add(label8);
            Controls.Add(pictureBox6);
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
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox5);
            Margin = new Padding(4, 2, 4, 2);
            Name = "FormPasien";
            Text = "Form1";
            Load += FormPasien_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
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
        private Label label8;
        private PictureBox pictureBox6;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label back;
    }
}