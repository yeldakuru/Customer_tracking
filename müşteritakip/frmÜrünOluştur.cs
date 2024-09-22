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
    public partial class frmÜrünOluştur : Form
    {
        public frmÜrünOluştur()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmÜrünOluştur_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.KategorilerTableAdapter ta = new DataSet1TableAdapters.KategorilerTableAdapter();
            cbKategori.DisplayMember = "KategoriAdı";
            cbKategori.ValueMember = "KategoriNo";
            cbKategori.DataSource = ta.GetKategoriler();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.ÜrünlerTableAdapter ta = new DataSet1TableAdapters.ÜrünlerTableAdapter();
            ta.YeniÜrün(tbAdı.Text,Convert.ToDecimal(tbFiyat.Text),
               Convert.ToInt16(tbAdet.Text),Convert.ToInt16(cbKategori.SelectedValue.ToString()));
            this.Close();
        }
    }
}
