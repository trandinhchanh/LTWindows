namespace Example
{
    partial class Article17
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
            LbSong = new ListBox();
            btSelect = new Button();
            btDeselect = new Button();
            SelectAll = new Button();
            btDeselectAll = new Button();
            label2 = new Label();
            LbFavolite = new ListBox();
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
            // LbSong
            // 
            LbSong.FormattingEnabled = true;
            LbSong.ItemHeight = 20;
            LbSong.Items.AddRange(new object[] { "Giấc mơ Chapi", "Đôi mắt Pleiku", "Em muốn sống bên anh trọn đời", "Còn thương nhau thì về Buôn Mê Thuộc", "Đi tìm lời ru mặt trời", "Ly Cà Phê Ban Mê" });
            LbSong.Location = new Point(14, 50);
            LbSong.Margin = new Padding(3, 4, 3, 4);
            LbSong.Name = "LbSong";
            LbSong.Size = new Size(267, 504);
            LbSong.TabIndex = 3;
            LbSong.MouseClick += lbSong_MouseDoubleClick;
            // 
            // btSelect
            // 
            btSelect.Location = new Point(304, 110);
            btSelect.Margin = new Padding(3, 4, 3, 4);
            btSelect.Name = "btSelect";
            btSelect.Size = new Size(64, 64);
            btSelect.TabIndex = 2;
            btSelect.Text = ">";
            btSelect.UseVisualStyleBackColor = true;
            btSelect.Click += btSelect_Click;
            // 
            // btDeselect
            // 
            btDeselect.Location = new Point(304, 211);
            btDeselect.Margin = new Padding(3, 4, 3, 4);
            btDeselect.Name = "btDeselect";
            btDeselect.Size = new Size(64, 64);
            btDeselect.TabIndex = 2;
            btDeselect.Text = "<";
            btDeselect.UseVisualStyleBackColor = true;
            btDeselect.Click += btDeselect_Click;
            // 
            // SelectAll
            // 
            SelectAll.Location = new Point(304, 314);
            SelectAll.Margin = new Padding(3, 4, 3, 4);
            SelectAll.Name = "SelectAll";
            SelectAll.Size = new Size(64, 64);
            SelectAll.TabIndex = 2;
            SelectAll.Text = ">>";
            SelectAll.UseVisualStyleBackColor = true;
            SelectAll.Click += SelectAll_Click;
            // 
            // btDeselectAll
            // 
            btDeselectAll.Location = new Point(304, 419);
            btDeselectAll.Margin = new Padding(3, 4, 3, 4);
            btDeselectAll.Name = "btDeselectAll";
            btDeselectAll.Size = new Size(64, 64);
            btDeselectAll.TabIndex = 2;
            btDeselectAll.Text = "<<";
            btDeselectAll.UseVisualStyleBackColor = true;
            btDeselectAll.Click += btDeselectAll_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(392, 11);
            label2.Name = "label2";
            label2.Size = new Size(184, 20);
            label2.TabIndex = 0;
            label2.Text = "Danh sách bài hát ưu thích";
            // 
            // LbFavolite
            // 
            LbFavolite.FormattingEnabled = true;
            LbFavolite.ItemHeight = 20;
            LbFavolite.Location = new Point(395, 50);
            LbFavolite.Margin = new Padding(3, 4, 3, 4);
            LbFavolite.Name = "LbFavolite";
            LbFavolite.Size = new Size(267, 504);
            LbFavolite.TabIndex = 1;
            // 
            // Article17
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 580);
            Controls.Add(btDeselectAll);
            Controls.Add(SelectAll);
            Controls.Add(btDeselect);
            Controls.Add(btSelect);
            Controls.Add(LbFavolite);
            Controls.Add(LbSong);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Article17";
            Text = "Music";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox LbSong;
        private Button btSelect;
        private Button btDeselect;
        private Button SelectAll;
        private Button btDeselectAll;
        private Label label2;
        private ListBox LbFavolite;
    }
}

