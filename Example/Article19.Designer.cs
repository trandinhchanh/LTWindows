namespace Example
{
    partial class Article19
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
            label3 = new Label();
            label4 = new Label();
            btFile = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            pbImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã nhân viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 90);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 0;
            label2.Text = "Tên nhân viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 91);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 0;
            label3.Text = "Tên nhân viên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 164);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 0;
            label4.Text = "Anh 3 x 4";
            // 
            // btFile
            // 
            btFile.Location = new Point(328, 186);
            btFile.Margin = new Padding(3, 4, 3, 4);
            btFile.Name = "btFile";
            btFile.Size = new Size(123, 45);
            btFile.TabIndex = 1;
            btFile.Text = "Chọn ảnh....";
            btFile.UseVisualStyleBackColor = true;
            btFile.Click += btFile_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(125, 25);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(326, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(125, 91);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(326, 27);
            textBox2.TabIndex = 2;
            // 
            // pbImage
            // 
            pbImage.Location = new Point(122, 148);
            pbImage.Margin = new Padding(3, 4, 3, 4);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(195, 236);
            pbImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbImage.TabIndex = 3;
            pbImage.TabStop = false;
            // 
            // Article19
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 420);
            Controls.Add(pbImage);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btFile);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Article19";
            Text = "Quản lý nhân sự";
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btFile;
        private TextBox textBox1;
        private TextBox textBox2;
        private PictureBox pbImage;
    }
}

