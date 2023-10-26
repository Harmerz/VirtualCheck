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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(563, 98);
            label1.Name = "label1";
            label1.Size = new Size(183, 32);
            label1.TabIndex = 0;
            label1.Text = "Form Konsultasi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(288, 204);
            label2.Name = "label2";
            label2.Size = new Size(175, 32);
            label2.TabIndex = 1;
            label2.Text = "Keluhan Pasien";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(563, 204);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(484, 434);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(288, 703);
            label3.Name = "label3";
            label3.Size = new Size(137, 32);
            label3.TabIndex = 3;
            label3.Text = "Data Pasien";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(563, 698);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(484, 200);
            textBox2.TabIndex = 4;
            // 
            // FormDokter
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1349, 990);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormDokter";
            Text = "FormDokter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
    }
}