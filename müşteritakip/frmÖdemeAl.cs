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
    public partial class frmÖdemeAl : Form
    {
        public frmÖdemeAl()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.MüşterilerTableAdapter taMüşteriler = new DataSet1TableAdapters.MüşterilerTableAdapter();
            DataSet1TableAdapters.MüşteriDetayTableAdapter taMüşteriDetay = new DataSet1TableAdapters.MüşteriDetayTableAdapter();
            taMüşteriler.BorçAzalt(Convert.ToDecimal(tbTutar.Text), Convert.ToInt16(lblMüşteriNo.Text));
            taMüşteriDetay.DetayEkle(Convert.ToInt16(lblMüşteriNo.Text), 0, Convert.ToDecimal(tbTutar.Text),dtpTarih.Value,tbAçıklama.Text);
              
            this.Close();
        }

        private void tbAçıklama_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tbTutar_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblMüşteriAdı_Click(object sender, EventArgs e)
        {

        }

        private void lblMüşteriNo_Click(object sender, EventArgs e)
        {

        }
    }
}
