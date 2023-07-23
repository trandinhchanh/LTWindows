using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example
{
    public partial class Article21 : Form
    {

        public Article21()
        {
            InitializeComponent();
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

        private void btAddNew_Click(object sender, EventArgs e)
        {
            Employee em = new Employee();
            em.Id = tbId.Text;
            em.Name = tbName.Text;
            em.Age = tbAge.TextLength;
            em.Gender = ckGender.Checked;
            lst.Add(em);
            dgvEmployee.Rows.Add(tbId.Text, tbName.Text, tbAge.Text, ckGender.Checked);
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn đóng chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            Employee em = new Employee();
            em.Id = tbId.Text;
            em.Name = tbName.Text;
            em.Age = tbAge.TextLength;
            em.Gender = ckGender.Checked;
            lst.Add(em);
            dgvEmployee.Rows.Add(tbId.Text, tbName.Text, tbAge.Text, ckGender.Checked);
        }
        List<Employee> lst;
        private void Article21_Load(object sender, EventArgs e)
        {
            lst = GetData();
            foreach (Employee em in lst)
            {
                dgvEmployee.Rows.Add(em.Id, em.Name, em.Age);
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            int idx = dgvEmployee.CurrentCell.RowIndex;
            lst.RemoveAt(idx);
            dgvEmployee.Rows.RemoveAt(idx);
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvEmployee.SelectedRows[0].Index;
                Employee em = lst[selectedRowIndex];
                //string oldId = dgvEmployee.Rows[selectedRowIndex].Cells["id"].Value.ToString();
                em.Name = tbName.Text;
                if (int.TryParse(tbAge.Text, out int age))
                {
                    em.Age = age;
                }
                em.Gender = ckGender.Checked;
                dgvEmployee.Rows[selectedRowIndex].SetValues(tbId.Text, tbName.Text, tbAge.Text, ckGender.Checked);
            }

        }

        private void tbId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
