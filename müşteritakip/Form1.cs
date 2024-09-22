using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace müşteritakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kategorilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKategoriler f= new frmKategoriler();
            f.ShowDialog();
        }

        private void müşterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMüşteriler f = new frmMüşteriler();
            f.ShowDialog();
        }

        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
             frmÜrünler f = new frmÜrünler();
            f.ShowDialog();
        }

        private void satışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSatış f =new frmSatış();
            f.ShowDialog();
        }

        private void satışRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmÜrünSatışları f =new frmÜrünSatışları();
            f.ShowDialog();
        }

        private void müşteriDetayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMüşteriDetayları f =new frmMüşteriDetayları();
            f.ShowDialog();
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHakkında f = new frmHakkında();
            f.ShowDialog();
        }
    }
}
