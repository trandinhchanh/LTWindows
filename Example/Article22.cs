using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Example
{
    public partial class Article22 : Form
    {
        public Article22()
        {
            InitializeComponent();
            dgvEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployee.Columns["Column1"].ReadOnly = true;
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void Form7_Load(object sender, EventArgs e)
        {
            lst = GetData();
            foreach (Employee em in lst)
            {
                dgvEmployee.Rows.Add(em.Id, em.Name, em.Age, em.Gender);
            }
            btEdit.Click += btEdit_Click;

        }
        private void btAddNew_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbId.Text))
            {
                MessageBox.Show("Không được để trống Id.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(tbId.Text, out int id))
            {
                MessageBox.Show("Không được nhập kí tự.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Employee em = new Employee();
            em.Id = tbId.Text;
            em.Name = tbName.Text;
            em.Age = tbAge.TextLength;
            em.Gender = ckGender.Checked;
            lst.Add(em);
            dgvEmployee.Rows.Add(tbId.Text, tbName.Text, tbAge.Text, ckGender.Checked);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            int idx = dgvEmployee.CurrentCell.RowIndex;

            if (dgvEmployee.CurrentRow != null && !dgvEmployee.CurrentRow.IsNewRow)
            {
                // Xóa dòng hiện tại khỏi DataGridView
                dgvEmployee.Rows.Remove(dgvEmployee.CurrentRow);
            }
            else
            {

            }
        }

        private void dgvEmployee_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (dgvEmployee.Rows.Count > 0 && idx >= 0)
            {

                if (dgvEmployee.Rows[idx].Cells[0].Value != null)
                {
                    tbId.Text = dgvEmployee.Rows[idx].Cells[0].Value.ToString();
                }
                else
                {
                    tbId.Text = "";
                }


                if (dgvEmployee.Rows[idx].Cells[1].Value != null)
                {
                    tbName.Text = dgvEmployee.Rows[idx].Cells[1].Value.ToString();
                }
                else
                {
                    tbName.Text = "";
                }


                if (dgvEmployee.Rows[idx].Cells[2].Value != null)
                {
                    tbAge.Text = dgvEmployee.Rows[idx].Cells[2].Value.ToString();
                }
                else
                {
                    tbAge.Text = "";
                }


                if (dgvEmployee.Rows[idx].Cells[3].Value != null)
                {
                    bool gender;
                    if (bool.TryParse(dgvEmployee.Rows[idx].Cells[3].Value.ToString(), out gender))
                    {
                        ckGender.Checked = gender;
                    }
                    else
                    {

                    }
                }
                else
                {

                }
            }
            else
            {

                tbId.Text = "";
                tbName.Text = "";
                tbAge.Text = "";
                ckGender.Checked = false;
            }
        }
        public class Employee
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public bool Gender { get; set; }

        }
        public List<Employee> GetData()
        {
            List<Employee> lst = new List<Employee>();
            Employee em = new Employee();
            em.Id = "53418";
            em.Name = "Trần A";
            em.Age = 20;
            lst.Add(em);

            em = new Employee();
            em.Id = "53416";
            em.Name = "Nguyễn C";
            em.Age = 25;
            lst.Add(em);

            em = new Employee();
            em.Id = "53417";
            em.Name = "Lê B";
            em.Age = 23;
            lst.Add(em);
            return lst;
        }
        List<Employee> lst;

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvEmployee.SelectedRows[0].Index;
                Employee em = lst[selectedRowIndex];

                string oldId = dgvEmployee.Rows[selectedRowIndex].Cells["Column1"].Value.ToString();
                em.Name = tbName.Text;



                if (int.TryParse(tbAge.Text, out int age))
                {
                    em.Age = age;
                }
                em.Gender = ckGender.Checked;

                dgvEmployee.Rows[selectedRowIndex].SetValues(oldId, tbName.Text, tbAge.Text, ckGender.Checked);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát khỏi ứng dụng?", "Xác nhận", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {

                this.Close();
            }
            else
            {

            }

        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
