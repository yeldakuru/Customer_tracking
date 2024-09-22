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
    public partial class frmÜrünler : Form
    {
        public frmÜrünler()
        {
            InitializeComponent();
        }



        private void frmÜrünler_Load(object sender, EventArgs e)
        {
            ürünleriGrideGetir();
        }
        public void ürünleriGrideGetir()
        {
          DataSet1TableAdapters.ÜrünlerTableAdapter ta = new DataSet1TableAdapters.ÜrünlerTableAdapter();
          dataGridView1.DataSource = ta.GetÜrünler();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmÜrünOluştur f = new frmÜrünOluştur();
            f.ShowDialog();
            ürünleriGrideGetir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmÜrünAlış f = new frmÜrünAlış();
            DataGridViewRow seciliÜrün = dataGridView1.CurrentRow;

            f.lblÜrünAdı.Text = seciliÜrün.Cells["ÜrünAdı"].Value.ToString();
            f.lblÜrünNo.Text = seciliÜrün.Cells["ÜrünNo"].Value.ToString();
            f.ShowDialog();
            ürünleriGrideGetir();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmÜrünSatışları frm = new frmÜrünSatışları();
            frm.ShowDialog();
        }
    }
}
