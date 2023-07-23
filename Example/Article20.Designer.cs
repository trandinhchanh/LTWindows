namespace Example
{
    partial class Article20
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
            dgvEmployee = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewCheckBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbId = new TextBox();
            tbName = new TextBox();
            tbAge = new TextBox();
            ckGender = new CheckBox();
            btAddNew = new Button();
            btDelete = new Button();
            btClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            SuspendLayout();
            // 
            // dgvEmployee
            // 
            dgvEmployee.AllowUserToAddRows = false;
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvEmployee.Location = new Point(10, 10);
            dgvEmployee.Margin = new Padding(2);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.RowHeadersWidth = 62;
            dgvEmployee.RowTemplate.Height = 33;
            dgvEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployee.Size = new Size(609, 173);
            dgvEmployee.TabIndex = 0;
            dgvEmployee.CellContentClick += dgvEmployee_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 247;
            // 
            // Column3
            // 
            Column3.HeaderText = "Tuổi";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "Giới tính (Nam)";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 190);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(30, 20);
            label1.TabIndex = 1;
            label1.Text = "Mã";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 219);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 249);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 3;
            label3.Text = "Tuổi";
            // 
            // tbId
            // 
            tbId.Location = new Point(52, 187);
            tbId.Margin = new Padding(2);
            tbId.Name = "tbId";
            tbId.Size = new Size(130, 27);
            tbId.TabIndex = 4;
            // 
            // tbName
            // 
            tbName.Location = new Point(52, 217);
            tbName.Margin = new Padding(2);
            tbName.Name = "tbName";
            tbName.Size = new Size(307, 27);
            tbName.TabIndex = 5;
            // 
            // tbAge
            // 
            tbAge.Location = new Point(52, 246);
            tbAge.Margin = new Padding(2);
            tbAge.Name = "tbAge";
            tbAge.Size = new Size(134, 27);
            tbAge.TabIndex = 6;
            // 
            // ckGender
            // 
            ckGender.AutoSize = true;
            ckGender.Location = new Point(52, 276);
            ckGender.Margin = new Padding(2);
            ckGender.Name = "ckGender";
            ckGender.Size = new Size(63, 24);
            ckGender.TabIndex = 7;
            ckGender.Text = "Nam";
            ckGender.UseVisualStyleBackColor = true;
            // 
            // btAddNew
            // 
            btAddNew.Location = new Point(345, 306);
            btAddNew.Margin = new Padding(2);
            btAddNew.Name = "btAddNew";
            btAddNew.Size = new Size(88, 32);
            btAddNew.TabIndex = 8;
            btAddNew.Text = "Thêm";
            btAddNew.UseVisualStyleBackColor = true;
            btAddNew.Click += btAddNew_Click;
            // 
            // btDelete
            // 
            btDelete.Location = new Point(438, 306);
            btDelete.Margin = new Padding(2);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(88, 32);
            btDelete.TabIndex = 9;
            btDelete.Text = "Xóa ";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // btClose
            // 
            btClose.Location = new Point(530, 306);
            btClose.Margin = new Padding(2);
            btClose.Name = "btClose";
            btClose.Size = new Size(88, 30);
            btClose.TabIndex = 10;
            btClose.Text = "Thoát";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // Article20
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 346);
            Controls.Add(btClose);
            Controls.Add(btDelete);
            Controls.Add(btAddNew);
            Controls.Add(ckGender);
            Controls.Add(tbAge);
            Controls.Add(tbName);
            Controls.Add(tbId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvEmployee);
            Margin = new Padding(2);
            Name = "Article20";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEmployee;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbId;
        private TextBox tbName;
        private TextBox tbAge;
        private CheckBox ckGender;
        private Button btAddNew;
        private Button btDelete;
        private Button btClose;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewCheckBoxColumn Column4;
    }
}

