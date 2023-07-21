namespace Example
{
    partial class Article08
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
            cong = new Button();
            x = new Label();
            textBox1 = new TextBox();
            y = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            tkq = new TextBox();
            nhan = new Button();
            thoat = new Button();
            SuspendLayout();
            // 
            // cong
            // 
            cong.Location = new Point(12, 146);
            cong.Name = "cong";
            cong.Size = new Size(94, 29);
            cong.TabIndex = 0;
            cong.Text = "cong";
            cong.UseVisualStyleBackColor = true;
            cong.Click += cong_Click;
            // 
            // x
            // 
            x.AutoSize = true;
            x.Location = new Point(12, 30);
            x.Name = "x";
            x.Size = new Size(35, 20);
            x.TabIndex = 1;
            x.Text = "so x";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(68, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(176, 27);
            textBox1.TabIndex = 2;
            // 
            // y
            // 
            y.AutoSize = true;
            y.Location = new Point(12, 64);
            y.Name = "y";
            y.Size = new Size(35, 20);
            y.TabIndex = 3;
            y.Text = "so y";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(68, 57);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(176, 27);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 104);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 5;
            label3.Text = "ket qua";
            // 
            // tkq
            // 
            tkq.Location = new Point(68, 97);
            tkq.Name = "tkq";
            tkq.Size = new Size(176, 27);
            tkq.TabIndex = 6;
            // 
            // nhan
            // 
            nhan.Location = new Point(112, 146);
            nhan.Name = "nhan";
            nhan.Size = new Size(94, 29);
            nhan.TabIndex = 7;
            nhan.Text = "nhan";
            nhan.UseVisualStyleBackColor = true;
            nhan.Click += nhan_Click;
            // 
            // thoat
            // 
            thoat.Location = new Point(251, 146);
            thoat.Name = "thoat";
            thoat.Size = new Size(94, 29);
            thoat.TabIndex = 8;
            thoat.Text = "thoat";
            thoat.UseVisualStyleBackColor = true;
            thoat.Click += thoat_Click;
            // 
            // Article08
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 186);
            Controls.Add(thoat);
            Controls.Add(nhan);
            Controls.Add(tkq);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(y);
            Controls.Add(textBox1);
            Controls.Add(x);
            Controls.Add(cong);
            Name = "Article08";
            Text = "Article08";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cong;
        private Label x;
        private TextBox textBox1;
        private Label y;
        private TextBox textBox2;
        private Label label3;
        private TextBox tkq;
        private Button nhan;
        private Button thoat;
    }
}