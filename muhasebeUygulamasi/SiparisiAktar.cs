using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace muhasebeUygulamasi
{
    public partial class SiparisiAktar : Form
    {
        public SiparisiAktar()
        {
            InitializeComponent();
        }
        public string a, b, c, d, g, f, h, k;

        private void btnAktar_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog onizleme1 = new PrintPreviewDialog();
            onizleme1.Document = printDocument1;
            onizleme1.ShowDialog();
        }

        private void SiparisiAktar_Load(object sender, EventArgs e)
        {
            txtİd.Text = a;
            txtTarih.Text = b;
            txtSaat.Text = c;
            txtSiparisNo.Text = d;
            txtİslemTuru.Text = f;
            txtUnvan.Text = g;
            txtTutar.Text = h;
            txtDurum.Text = k;
        }
    }
}
