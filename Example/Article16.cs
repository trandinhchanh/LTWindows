using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example
{
    public partial class Article16 : Form
    {
        public Article16()
        {
            InitializeComponent();
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            i++;
            string msg = null;
            string khoa = cb_Faculty.SelectedItem.ToString();
            string date = dtNgaysinh.Value.ToShortDateString();
            if (rbMale.Checked == true) msg += "Nam";
            if (rbFemale.Checked == true) msg += "Nữ";
            tbtrangthai.Text += i + ". " + tbName.Text + "\r\n" + "-Giới tính: " + msg + "\r\n" + "-Ngày sinh: " + date + "\r\n" + "-Khoa: " + khoa + "\r\n";
        }
        int i = 0;
        private void btthoat_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn đóng chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbtrangthai_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbTrangthai_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
