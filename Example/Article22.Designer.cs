namespace Example
{
    partial class Article22
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
            dgvEmployee = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewCheckBoxColumn();
            tbId = new TextBox();
            tbName = new TextBox();
            tbAge = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ckGender = new CheckBox();
            btAddNew = new Button();
            btDelete = new Button();
            button3 = new Button();
            btEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            SuspendLayout();
            // 
            // dgvEmployee
            // 
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvEmployee.Location = new Point(26, 31);
            dgvEmployee.Margin = new Padding(3, 4, 3, 4);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.RowHeadersWidth = 51;
            dgvEmployee.RowTemplate.Height = 24;
            dgvEmployee.Size = new Size(555, 259);
            dgvEmployee.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Id";
            Column1.HeaderText = "Mã nhân viên";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Name";
            Column2.HeaderText = "Tên nhân viên";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Age";
            Column3.HeaderText = "Tuổi";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Gender";
            Column4.HeaderText = "Giới tính(Nam)";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Resizable = DataGridViewTriState.True;
            Column4.SortMode = DataGridViewColumnSortMode.Automatic;
            Column4.Width = 125;
            // 
            // tbId
            // 
            tbId.Location = new Point(123, 329);
            tbId.Margin = new Padding(3, 4, 3, 4);
            tbId.Name = "tbId";
            tbId.Size = new Size(150, 27);
            tbId.TabIndex = 1;
            // 
            // tbName
            // 
            tbName.Location = new Point(123, 379);
            tbName.Margin = new Padding(3, 4, 3, 4);
            tbName.Name = "tbName";
            tbName.Size = new Size(306, 27);
            tbName.TabIndex = 2;
            // 
            // tbAge
            // 
            tbAge.Location = new Point(123, 431);
            tbAge.Margin = new Padding(3, 4, 3, 4);
            tbAge.Name = "tbAge";
            tbAge.Size = new Size(150, 27);
            tbAge.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 329);
            label1.Name = "label1";
            label1.Size = new Size(30, 20);
            label1.TabIndex = 4;
            label1.Text = "Mã";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 379);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 5;
            label2.Text = "Tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 431);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 6;
            label3.Text = "Tuổi";
            // 
            // ckGender
            // 
            ckGender.AutoSize = true;
            ckGender.Location = new Point(123, 478);
            ckGender.Margin = new Padding(3, 4, 3, 4);
            ckGender.Name = "ckGender";
            ckGender.Size = new Size(63, 24);
            ckGender.TabIndex = 8;
            ckGender.Text = "Nam";
            ckGender.UseVisualStyleBackColor = true;
            // 
            // btAddNew
            // 
            btAddNew.Location = new Point(187, 540);
            btAddNew.Margin = new Padding(3, 4, 3, 4);
            btAddNew.Name = "btAddNew";
            btAddNew.Size = new Size(86, 45);
            btAddNew.TabIndex = 9;
            btAddNew.Text = "Thêm";
            btAddNew.UseVisualStyleBackColor = true;
            btAddNew.Click += btAddNew_Click;
            // 
            // btDelete
            // 
            btDelete.Location = new Point(392, 540);
            btDelete.Margin = new Padding(3, 4, 3, 4);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(86, 45);
            btDelete.TabIndex = 10;
            btDelete.Text = "Xóa";
            btDelete.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(495, 540);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(86, 45);
            button3.TabIndex = 11;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = true;
            // 
            // btEdit
            // 
            btEdit.Location = new Point(291, 540);
            btEdit.Margin = new Padding(3, 4, 3, 4);
            btEdit.Name = "btEdit";
            btEdit.Size = new Size(86, 45);
            btEdit.TabIndex = 12;
            btEdit.Text = "Sữa";
            btEdit.UseVisualStyleBackColor = true;
            // 
            // Article22
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 616);
            Controls.Add(btEdit);
            Controls.Add(button3);
            Controls.Add(btDelete);
            Controls.Add(btAddNew);
            Controls.Add(ckGender);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbAge);
            Controls.Add(tbName);
            Controls.Add(tbId);
            Controls.Add(dgvEmployee);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Article22";
            Text = "Form7";
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEmployee;
        private TextBox tbId;
        private TextBox tbName;
        private TextBox tbAge;
        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox ckGender;
        private Button btAddNew;
        private Button btDelete;
        private Button button3;
        private Button btEdit;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewCheckBoxColumn Column4;
    }
}