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
    public partial class frmSatış : Form
    {
        DataSet1TableAdapters.MüşterilerTableAdapter taMüşteriler = new DataSet1TableAdapters.MüşterilerTableAdapter();
        DataSet1TableAdapters.ÜrünlerTableAdapter taÜrünler = new DataSet1TableAdapters.ÜrünlerTableAdapter();
        DataSet1TableAdapters.MüşteriDetayTableAdapter taMüşteriDetay = new DataSet1TableAdapters.MüşteriDetayTableAdapter();
        DataSet1TableAdapters.SatışlarTableAdapter taSatışlar = new DataSet1TableAdapters.SatışlarTableAdapter();
        public frmSatış()
        {
            InitializeComponent();
        }

        private void frmSatış_Load(object sender, EventArgs e)
        {
            grdMüşteriler.DataSource = taMüşteriler.GetMüşteriler();
            grdÜrünler.DataSource = taÜrünler.GetÜrünler();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataGridViewRow seçiliÜrün = grdÜrünler.CurrentRow;
            decimal fiyat = Convert.ToDecimal(seçiliÜrün.Cells["Fiyat"].Value.ToString());
            tbTutar.Text = (fiyat*Convert.ToInt16(tbAdet.Text)).ToString();
        }

        private void tbAdet_TextChanged(object sender, EventArgs e)
        {
            //DataGridViewRow seçiliÜrün = grdÜrünler.CurrentRow;
            //decimal fiyat = Convert.ToDecimal(seçiliÜrün.Cells["Fiyat"].Value.ToString());
            //tbTutar.Text = (fiyat * Convert.ToInt16(tbAdet.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow seçiliÜrün = grdÜrünler.CurrentRow;
            DataGridViewRow seçiliMüşteri = grdMüşteriler.CurrentRow;

            taSatışlar.SatışEkle(Convert.ToInt16(seçiliÜrün.Cells["ÜrünNo"].Value.ToString()),
                Convert.ToInt16(seçiliMüşteri.Cells["MüşteriNo"].Value.ToString()),
                dtpTarih.Value, Convert.ToInt16(tbAdet.Text),
                Convert.ToDecimal(seçiliÜrün.Cells["Fiyat"].Value.ToString()));

            taÜrünler.AdetAzalt(Convert.ToInt16(tbAdet.Text), Convert.ToInt16(seçiliÜrün.Cells["ÜrünNo"].Value.ToString()));

            taMüşteriler.BorçArttır(Convert.ToDecimal(tbTutar.Text),
                Convert.ToInt16(seçiliMüşteri.Cells["MüşteriNo"].Value.ToString()));

            taMüşteriDetay.DetayEkle(Convert.ToInt16(seçiliMüşteri.Cells["MüşteriNo"].Value.ToString()),
                Convert.ToDecimal(tbTutar.Text),0,dtpTarih.Value,tbAçıklama.Text);
            this.Close();
                


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
