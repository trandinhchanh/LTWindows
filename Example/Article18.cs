using System;
using System.Collections;
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

    public partial class Article18 : Form
    {
        public Article18()
        {
            InitializeComponent();
        }
        public ArrayList GetData()
        {
            ArrayList lst = new ArrayList();

            Song s = new Song();
            s.Id = 53418;
            s.Name = "Giấc mơ cha pi";
            s.Author = "Trần Tiến";
            lst.Add(s);

            s = new Song();
            s.Id = 52616;
            s.Name = "Đôi mắt pleiku";
            s.Author = "Nguyễn Cường";
            lst.Add(s);

            s = new Song();
            s.Id = 51172;
            s.Name = "Em muốn sống bên anh chọn đời";
            s.Author = "Nguyễn Cường";
            lst.Add(s);
            return lst;
        }

        private void btSelect_Click(object sender, EventArgs e)
        {
            Song song = (Song)lbsong.SelectedItem;
            string id = song.Id.ToString();
            string name = song.Name;
            string author = song.Author;
            LbFavolite.Items.Add(id + "_" + name + "_" + author);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArrayList lst = GetData();
            lbsong.DataSource = lst;
            lbsong.DisplayMember = "Name";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
