namespace Example
{
    partial class Article18
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
            lbsong = new ListBox();
            btSelect = new Button();
            button2 = new Button();
            LbFavolite = new ListBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 0;
            label1.Text = "Danh sách bài hát";
            // 
            // lbsong
            // 
            lbsong.FormattingEnabled = true;
            lbsong.ItemHeight = 20;
            lbsong.Items.AddRange(new object[] { "Giấc mơ Chapi", "Đôi mắt Pleiku", "Em muốn sống bên anh trọn đời", "Còn thương nhau thì về Buôn Mê Thuộc", "Đi tìm lời ru mặt trời", "Ly Cà Phê Ban Mê" });
            lbsong.Location = new Point(8, 42);
            lbsong.Margin = new Padding(3, 4, 3, 4);
            lbsong.Name = "lbsong";
            lbsong.Size = new Size(290, 484);
            lbsong.TabIndex = 1;
            // 
            // btSelect
            // 
            btSelect.Location = new Point(323, 201);
            btSelect.Margin = new Padding(3, 4, 3, 4);
            btSelect.Name = "btSelect";
            btSelect.Size = new Size(69, 61);
            btSelect.TabIndex = 2;
            btSelect.Text = ">\r\n";
            btSelect.UseVisualStyleBackColor = true;
            btSelect.Click += btSelect_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDark;
            button2.Location = new Point(323, 312);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(69, 61);
            button2.TabIndex = 2;
            button2.Text = "<";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // LbFavolite
            // 
            LbFavolite.FormattingEnabled = true;
            LbFavolite.ItemHeight = 20;
            LbFavolite.Location = new Point(411, 42);
            LbFavolite.Margin = new Padding(3, 4, 3, 4);
            LbFavolite.Name = "LbFavolite";
            LbFavolite.Size = new Size(290, 484);
            LbFavolite.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(408, 11);
            label2.Name = "label2";
            label2.Size = new Size(184, 20);
            label2.TabIndex = 0;
            label2.Text = "Danh sách bài hát ưu thích";
            // 
            // Article18
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 562);
            Controls.Add(button2);
            Controls.Add(btSelect);
            Controls.Add(LbFavolite);
            Controls.Add(lbsong);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Article18";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lbsong;
        private Button btSelect;
        private Button button2;
        private ListBox LbFavolite;
        private Label label2;
    }
}

