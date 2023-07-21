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
    public partial class Article10 : Form
    {
        decimal workingMemory = 0;
        string opr = "";
        public Article10()
        {
            InitializeComponent();
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            bt.Text += "0";
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            bt.Text += "1";
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            bt.Text += "2";
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            bt.Text += "3";
        }

        private void cong_Click(object sender, EventArgs e)
        {
            opr = cong.Text;
            workingMemory = decimal.Parse(bt.Text);
            bt.Clear();
        }

        private void nhan_Click(object sender, EventArgs e)
        {
            opr = nhan.Text;
            workingMemory = decimal.Parse(bt.Text);
            bt.Clear();
        }

        private void bang_Click(object sender, EventArgs e)
        {
            decimal secondValue = decimal.Parse(bt.Text);
            if (opr == "+")
                bt.Text = (workingMemory + secondValue).ToString();
            if (opr == "*")
                bt.Text = (workingMemory * secondValue).ToString();
        }
    }
}
