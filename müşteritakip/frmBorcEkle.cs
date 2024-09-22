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
    public partial class frmBorcEkle : Form
    {
        public frmBorcEkle()
        {
            InitializeComponent();
        }

        private void tbTutar_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.MüşteriDetayTableAdapter taMüşteriDetayları = new DataSet1TableAdapters.MüşteriDetayTableAdapter();
            DataSet1TableAdapters.MüşterilerTableAdapter taMüşteriler = new DataSet1TableAdapters.MüşterilerTableAdapter();

            taMüşteriDetayları.DetayEkle(Convert.ToInt16(lblMüşteriNo.Text),
                Convert.ToDecimal(tbTutar.Text),0, dtpTarih.Value, tbAçıklama.Text);

            taMüşteriler.BorçArttır(Convert.ToDecimal(tbTutar.Text),Convert.ToInt16(lblMüşteriNo.Text));
            this.Close();
        }

    }
}
