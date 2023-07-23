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
    public partial class Article12 : Form
    {
        public Article12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string item = comboBox1.SelectedItem.ToString();
            textBox1.Text = "Bạn là sinh viên khoa  :" + item;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            textBox1.Text = "Bạn đã chọn thứ  :" + index.ToString();
        }
    }
}
