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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Article10 objArticle10 = new Article10();
            objArticle10.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Article09 objArticle09 = new Article09();
            objArticle09.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Article11 objArticle11 = new Article11();
            objArticle11.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Article08 objArticle08 = new Article08();
            objArticle08.ShowDialog();
        }
    }
}
