namespace Example
{
    partial class DangNhap
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
            label1 = new Label();
            tuser = new TextBox();
            blogin = new Button();
            tpass = new TextBox();
            label2 = new Label();
            bexit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 56);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // tuser
            // 
            tuser.Location = new Point(143, 49);
            tuser.Name = "tuser";
            tuser.Size = new Size(125, 27);
            tuser.TabIndex = 1;
            // 
            // blogin
            // 
            blogin.Location = new Point(93, 187);
            blogin.Name = "blogin";
            blogin.Size = new Size(94, 29);
            blogin.TabIndex = 2;
            blogin.Text = "Login";
            blogin.UseVisualStyleBackColor = true;
            blogin.Click += blogin_Click;
            // 
            // tpass
            // 
            tpass.Location = new Point(143, 101);
            tpass.Name = "tpass";
            tpass.Size = new Size(125, 27);
            tpass.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 108);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // bexit
            // 
            bexit.Location = new Point(204, 187);
            bexit.Name = "bexit";
            bexit.Size = new Size(94, 29);
            bexit.TabIndex = 5;
            bexit.Text = "Exit";
            bexit.UseVisualStyleBackColor = true;
            bexit.Click += bexit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 254);
            Controls.Add(bexit);
            Controls.Add(label2);
            Controls.Add(tpass);
            Controls.Add(blogin);
            Controls.Add(tuser);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tuser;
        private Button blogin;
        private TextBox tpass;
        private Label label2;
        private Button bexit;
    }
}