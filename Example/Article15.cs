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
    public partial class Article15 : Form
    {
        public Article15()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = dateTimePicker1.Value.ToLongDateString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.Text = dateTimePicker1.Value.ToLongDateString();
        }
    }
}
