using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTP
{
    public partial class menuForm : Form
    {
        public menuForm()
        {
            InitializeComponent();
        }

        private void phòngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            phongForm ph = new phongForm();
            ph.Show();
        }

        private void kháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            khachhangForm ph = new khachhangForm();
            ph.Show();
        }

        private void đăngKíToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dangkiForm ph = new dangkiForm();
            ph.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            khachhangForm ph = new khachhangForm();
            ph.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
