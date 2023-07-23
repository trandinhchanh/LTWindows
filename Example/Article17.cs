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
    public partial class Article17 : Form
    {
        public Article17()
        {
            InitializeComponent();
        }

        private void btSelect_Click(object sender, EventArgs e)
        {
            string song = LbSong.SelectedItem.ToString();
            LbFavolite.Items.Add(song);
            LbSong.Items.Remove(LbSong.SelectedIndex);
        }

        private void btDeselect_Click(object sender, EventArgs e)
        {
            string song = LbFavolite.SelectedItem.ToString();
            LbSong.Items.Add(song);
            LbFavolite.Items.RemoveAt(LbFavolite.SelectedIndex);
        }

        private void SelectAll_Click(object sender, EventArgs e)
        {
            while (LbSong.Items.Count > 0)
            {
                string song = LbSong.Items[0].ToString();
                LbFavolite.Items.Add(song);
                LbSong.Items.RemoveAt(0);
            }
        }

        private void btDeselectAll_Click(object sender, EventArgs e)
        {
            while (LbSong.Items.Count > 0)
            {
                string song = LbSong.Items[0].ToString();
                LbFavolite.Items.Add(song);
                LbSong.Items.RemoveAt(0);
            }
        }

        private void lbSong_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string song = LbSong.SelectedItem.ToString();
            LbFavolite.Items.Add(song);
            LbSong.Items.RemoveAt(LbSong.SelectedIndex);
        }
    }
}
