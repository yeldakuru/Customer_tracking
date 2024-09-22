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
    public partial class frmMüşteriEkle : Form
    {
        public frmMüşteriEkle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.MüşterilerTableAdapter ta = new DataSet1TableAdapters.MüşterilerTableAdapter();
       
            ta.MüşteriEkle(textBox1.Text, textBox2.Text);
            this.Close();
        }
    }
}
