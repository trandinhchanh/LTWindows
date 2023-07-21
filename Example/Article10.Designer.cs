namespace Example
{
    partial class Article10
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
            bt = new TextBox();
            bt0 = new Button();
            bt1 = new Button();
            bt2 = new Button();
            bt3 = new Button();
            cong = new Button();
            nhan = new Button();
            cham = new Button();
            bang = new Button();
            SuspendLayout();
            // 
            // bt
            // 
            bt.Location = new Point(12, 12);
            bt.Name = "bt";
            bt.Size = new Size(336, 27);
            bt.TabIndex = 0;
            // 
            // bt0
            // 
            bt0.Location = new Point(12, 54);
            bt0.Name = "bt0";
            bt0.Size = new Size(75, 44);
            bt0.TabIndex = 1;
            bt0.Text = "0";
            bt0.UseVisualStyleBackColor = true;
            bt0.Click += bt0_Click;
            // 
            // bt1
            // 
            bt1.Location = new Point(93, 54);
            bt1.Name = "bt1";
            bt1.Size = new Size(75, 44);
            bt1.TabIndex = 2;
            bt1.Text = "1";
            bt1.UseVisualStyleBackColor = true;
            bt1.Click += bt1_Click;
            // 
            // bt2
            // 
            bt2.Location = new Point(174, 54);
            bt2.Name = "bt2";
            bt2.Size = new Size(75, 44);
            bt2.TabIndex = 3;
            bt2.Text = "2";
            bt2.UseVisualStyleBackColor = true;
            bt2.Click += bt2_Click;
            // 
            // bt3
            // 
            bt3.Location = new Point(255, 54);
            bt3.Name = "bt3";
            bt3.Size = new Size(75, 44);
            bt3.TabIndex = 4;
            bt3.Text = "3";
            bt3.UseVisualStyleBackColor = true;
            bt3.Click += bt3_Click;
            // 
            // cong
            // 
            cong.Location = new Point(12, 103);
            cong.Name = "cong";
            cong.Size = new Size(75, 44);
            cong.TabIndex = 5;
            cong.Text = "+";
            cong.UseVisualStyleBackColor = true;
            cong.Click += cong_Click;
            // 
            // nhan
            // 
            nhan.Location = new Point(93, 103);
            nhan.Name = "nhan";
            nhan.Size = new Size(75, 44);
            nhan.TabIndex = 6;
            nhan.Text = "*";
            nhan.UseVisualStyleBackColor = true;
            nhan.Click += nhan_Click;
            // 
            // cham
            // 
            cham.Location = new Point(174, 103);
            cham.Name = "cham";
            cham.Size = new Size(75, 44);
            cham.TabIndex = 7;
            cham.Text = ".";
            cham.UseVisualStyleBackColor = true;
            // 
            // bang
            // 
            bang.Location = new Point(255, 103);
            bang.Name = "bang";
            bang.Size = new Size(75, 44);
            bang.TabIndex = 8;
            bang.Text = "=";
            bang.UseVisualStyleBackColor = true;
            bang.Click += bang_Click;
            // 
            // Article10
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 159);
            Controls.Add(bang);
            Controls.Add(cham);
            Controls.Add(nhan);
            Controls.Add(cong);
            Controls.Add(bt3);
            Controls.Add(bt2);
            Controls.Add(bt1);
            Controls.Add(bt0);
            Controls.Add(bt);
            Name = "Article10";
            Text = "Article10";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox bt;
        private Button bt0;
        private Button bt1;
        private Button bt2;
        private Button bt3;
        private Button cong;
        private Button nhan;
        private Button cham;
        private Button bang;
    }
}