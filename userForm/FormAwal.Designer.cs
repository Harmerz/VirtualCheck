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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(299, 90);
            label1.Name = "label1";
            label1.Size = new Size(573, 59);
            label1.TabIndex = 0;
            label1.Text = "Welcome to VirtualCheck!";
            // 
            // button1
            // 
            button1.Location = new Point(222, 344);
            button1.Name = "button1";
            button1.Size = new Size(334, 247);
            button1.TabIndex = 1;
            button1.Text = "Admin or Doctor";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(595, 344);
            button2.Name = "button2";
            button2.Size = new Size(334, 247);
            button2.TabIndex = 2;
            button2.Text = "Patient";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(222, 271);
            label2.Name = "label2";
            label2.Size = new Size(441, 32);
            label2.TabIndex = 3;
            label2.Text = "Please select one of the options below...";
            // 
            // FormAwal
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1176, 768);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "FormAwal";
            Text = "FormAwal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Label label2;
    }
}