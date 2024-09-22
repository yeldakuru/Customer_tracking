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
    public partial class frmMüşteriler : Form
    {
        public frmMüşteriler()
        {
            InitializeComponent();
        }

        private void frmMüşteriler_Load(object sender, EventArgs e)
        {
            MüşterileriGrideGetir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMüşteriEkle f = new frmMüşteriEkle();
            f.ShowDialog();

            MüşterileriGrideGetir();
        }
        public void MüşterileriGrideGetir()
            {
            DataSet1TableAdapters.MüşterilerTableAdapter taMüşteri =
                new DataSet1TableAdapters.MüşterilerTableAdapter();

            dataGridView1.DataSource = taMüşteri.GetMüşteriler();


            }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow secilisatir = dataGridView1.CurrentRow;
            frmMüşteriDüzenle f =new frmMüşteriDüzenle();

            
            f.textBox1.Text = secilisatir.Cells["Adı"].Value.ToString();
            f.textBox1.Text = secilisatir.Cells["Soyadı"].Value.ToString();
            f.label3.Text = secilisatir.Cells["MüşteriNo"].Value.ToString();
            f.ShowDialog();
            MüşterileriGrideGetir();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           if (MessageBox.Show("Müşteri silinecek emin misin?", "Sil Onayı",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
           {
               DataGridViewRow seciliSatir = dataGridView1.CurrentRow;
                int mNo = Convert.ToInt16(seciliSatir.Cells["MüşteriNo"].Value.ToString());
                DataSet1TableAdapters.MüşterilerTableAdapter ta = new DataSet1TableAdapters.MüşterilerTableAdapter();
                ta.MüşteriSil(mNo);
                MüşterileriGrideGetir();
           }
           else
            {
               MessageBox.Show("Silme işlemini iptal ettik");
           }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            DataGridViewRow secilisatir = dataGridView1.CurrentRow;
            frmBorcEkle f = new frmBorcEkle();


            f.lblMüşteriAdı.Text = secilisatir.Cells["Adı"].Value.ToString() +""+secilisatir.Cells["Soyadı"].Value.ToString();
          
            f.lblMüşteriNo.Text = secilisatir.Cells["MüşteriNo"].Value.ToString();
            f.ShowDialog();
            MüşterileriGrideGetir();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataGridViewRow secilisatir = dataGridView1.CurrentRow;
            frmÖdemeAl f = new frmÖdemeAl();


            f.lblMüşteriAdı.Text = secilisatir.Cells["Adı"].Value.ToString() + "" + secilisatir.Cells["Soyadı"].Value.ToString();

            f.lblMüşteriNo.Text = secilisatir.Cells["MüşteriNo"].Value.ToString();
            f.ShowDialog();
            MüşterileriGrideGetir();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmMüşteriDetayları f =new frmMüşteriDetayları();
            f.ShowDialog();
        }
    }
}
