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
    public partial class frmKategoriler : Form
    {
        public frmKategoriler()
        {
            InitializeComponent();
        }

        private void frmKategoriler_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.KategorilerTableAdapter ta = new DataSet1TableAdapters.KategorilerTableAdapter();
            dataGridView1.DataSource = ta.GetKategoriler();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            if(tbYeniKategoriAdi.Text.Length==0)
            {
                MessageBox.Show("Boş bırakma","Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            { 
                DataSet1TableAdapters.KategorilerTableAdapter ta = new DataSet1TableAdapters.KategorilerTableAdapter();
                ta.KategoriEkle(tbYeniKategoriAdi.Text);
                dataGridView1.DataSource = ta.GetKategoriler();
                tbYeniKategoriAdi.Text =  "";

            }

           
        }

        private void tbYeniKategoriAdi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
