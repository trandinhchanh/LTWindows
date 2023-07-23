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
    public partial class Article14 : Form
    {
        public Article14()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg = null;
            int disc = 0;
            if (radioButton1.Checked == true)
                msg += "Ông\t";

            if (radioButton2.Checked == false)
                msg += "Bà\t";
            if (checkBox1.Checked == true)
                disc = int.Parse(textBox2.Text);
            textBox3.Text = msg + textBox1.Text + "\t được giảm " + disc.ToString() + "%" + "\r\n";
        }
        public bool checkBox2_Checked { get; set; }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2_Checked == true)
                checkBox2_Checked = true;
            else
                checkBox2_Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
