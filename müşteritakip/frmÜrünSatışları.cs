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
    public partial class frmÜrünSatışları : Form
    {
        public frmÜrünSatışları()
        {
            InitializeComponent();
        }

        private void frmÜrünSatışları_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.SatışlarTableAdapter taSatışlar = new DataSet1TableAdapters.SatışlarTableAdapter();
            dataGridView1.DataSource = taSatışlar.GetSatışlar();


            cbÜrünler.DisplayMember = "ÜrünAdı";
            cbÜrünler.ValueMember = "ÜrünNo";
            DataSet1TableAdapters.ÜrünlerTableAdapter taÜrünler = new DataSet1TableAdapters.ÜrünlerTableAdapter();
            cbÜrünler.DataSource =taÜrünler.GetÜrünler();
            DataSet1TableAdapters.MüşterilerTableAdapter taMüşteriler = new DataSet1TableAdapters.MüşterilerTableAdapter();
            cbMüşteriler.DataSource =taMüşteriler.GetMüşteriler();
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.SatışlarTableAdapter taSatışlar = new DataSet1TableAdapters.SatışlarTableAdapter();
            dataGridView1.DataSource = taSatışlar.GetÜrününSatışları(Convert.ToInt16(cbÜrünler.SelectedValue.ToString()));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.SatışlarTableAdapter taSatışlar = new DataSet1TableAdapters.SatışlarTableAdapter();
            dataGridView1.DataSource = taSatışlar.GetSatışlar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.SatışlarTableAdapter taSatışlar = new DataSet1TableAdapters.SatışlarTableAdapter();
            dataGridView1.DataSource = taSatışlar.GetMüşteriyeGöreSatışlar(Convert.ToInt16(cbMüşteriler.SelectedValue.ToString()));
        }
    }
}
