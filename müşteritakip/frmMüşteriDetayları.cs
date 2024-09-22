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
    public partial class frmMüşteriDetayları : Form
    {
        public frmMüşteriDetayları()
        {
            InitializeComponent();
        }

        private void frmMüşteriDetayları_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.MüşteriDetayTableAdapter taMüşteriDetay= new DataSet1TableAdapters.MüşteriDetayTableAdapter();
            dataGridView1.DataSource = taMüşteriDetay.GetMüşterilerinDetayları();

            DataSet1TableAdapters.MüşterilerTableAdapter taMüşteriler =new DataSet1TableAdapters.MüşterilerTableAdapter();
            cbMüşteriler.DataSource=taMüşteriler.GetMüşteriler();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.MüşteriDetayTableAdapter taMüşteriDetay = new DataSet1TableAdapters.MüşteriDetayTableAdapter();
            dataGridView1.DataSource = taMüşteriDetay.GetMüşterilerinDetayları();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.MüşteriDetayTableAdapter taMüşteriDetay = new DataSet1TableAdapters.MüşteriDetayTableAdapter();
            dataGridView1.DataSource = taMüşteriDetay.GetMüşterininDetayları(Convert.ToInt16(cbMüşteriler.SelectedValue.ToString()));
        }

        private void cbMüşteriler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
