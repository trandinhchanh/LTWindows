namespace Example
{
    partial class Article16
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
            tbName = new TextBox();
            dtNgaysinh = new DateTimePicker();
            groupBox1 = new GroupBox();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            label3 = new Label();
            cb_Faculty = new ComboBox();
            label4 = new Label();
            tbtrangthai = new TextBox();
            btthem = new Button();
            btthoat = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Họ và tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 80);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 0;
            label2.Text = "Ngày Sinh";
            // 
            // tbName
            // 
            tbName.Location = new Point(114, 22);
            tbName.Margin = new Padding(3, 4, 3, 4);
            tbName.Name = "tbName";
            tbName.Size = new Size(307, 27);
            tbName.TabIndex = 1;
            tbName.KeyPress += tbName_KeyPress;
            // 
            // dtNgaysinh
            // 
            dtNgaysinh.CustomFormat = "dd/MM/yyyy";
            dtNgaysinh.Format = DateTimePickerFormat.Custom;
            dtNgaysinh.Location = new Point(114, 74);
            dtNgaysinh.Margin = new Padding(3, 4, 3, 4);
            dtNgaysinh.Name = "dtNgaysinh";
            dtNgaysinh.Size = new Size(307, 27);
            dtNgaysinh.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbFemale);
            groupBox1.Controls.Add(rbMale);
            groupBox1.Location = new Point(113, 110);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(308, 130);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gioi Tính";
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(224, 52);
            rbFemale.Margin = new Padding(3, 4, 3, 4);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(50, 24);
            rbFemale.TabIndex = 0;
            rbFemale.TabStop = true;
            rbFemale.Text = "Nữ";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(68, 52);
            rbMale.Margin = new Padding(3, 4, 3, 4);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(62, 24);
            rbMale.TabIndex = 0;
            rbMale.TabStop = true;
            rbMale.Text = "Nam";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 276);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 0;
            label3.Text = "Khoa";
            // 
            // cb_Faculty
            // 
            cb_Faculty.FormattingEnabled = true;
            cb_Faculty.Items.AddRange(new object[] { "Công nghệ thông tin", "Kế Toán", "Ngân hàng", "Cơ khí", "Quản trị kinh doanh" });
            cb_Faculty.Location = new Point(113, 272);
            cb_Faculty.Margin = new Padding(3, 4, 3, 4);
            cb_Faculty.Name = "cb_Faculty";
            cb_Faculty.Size = new Size(308, 28);
            cb_Faculty.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 356);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 0;
            label4.Text = "Trạng thái";
            // 
            // tbtrangthai
            // 
            tbtrangthai.Location = new Point(111, 324);
            tbtrangthai.Margin = new Padding(3, 4, 3, 4);
            tbtrangthai.Multiline = true;
            tbtrangthai.Name = "tbtrangthai";
            tbtrangthai.Size = new Size(310, 189);
            tbtrangthai.TabIndex = 5;
            tbtrangthai.TextChanged += tbtrangthai_TextChanged;
            tbtrangthai.KeyPress += tbTrangthai_KeyPress;
            // 
            // btthem
            // 
            btthem.Location = new Point(191, 521);
            btthem.Margin = new Padding(3, 4, 3, 4);
            btthem.Name = "btthem";
            btthem.Size = new Size(100, 45);
            btthem.TabIndex = 6;
            btthem.Text = "Thêm";
            btthem.UseVisualStyleBackColor = true;
            btthem.Click += btthem_Click;
            // 
            // btthoat
            // 
            btthoat.Location = new Point(321, 521);
            btthoat.Margin = new Padding(3, 4, 3, 4);
            btthoat.Name = "btthoat";
            btthoat.Size = new Size(100, 45);
            btthoat.TabIndex = 6;
            btthoat.Text = "Thoát";
            btthoat.UseVisualStyleBackColor = true;
            btthoat.Click += btthoat_Click;
            // 
            // Article16
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 573);
            Controls.Add(btthoat);
            Controls.Add(btthem);
            Controls.Add(tbtrangthai);
            Controls.Add(cb_Faculty);
            Controls.Add(groupBox1);
            Controls.Add(dtNgaysinh);
            Controls.Add(tbName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Article16";
            Text = "Quản lý sinh viên";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbName;
        private DateTimePicker dtNgaysinh;
        private GroupBox groupBox1;
        private RadioButton rbFemale;
        private RadioButton rbMale;
        private Label label3;
        private ComboBox cb_Faculty;
        private Label label4;
        private TextBox tbtrangthai;
        private Button btthem;
        private Button btthoat;
    }
}

