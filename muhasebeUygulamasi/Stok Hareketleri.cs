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
    public partial class Stok_Hareketleri : Form
    {
        public Stok_Hareketleri()
        {
            InitializeComponent();
        }
        public string a0, a1, a2, a3, a4, a5, a6, a7, a8;
        private void Stok_Hareketleri_Load(object sender, EventArgs e)
        {
            txtİd.Text = a0;
            txtKod.Text = a1;
            txtStok.Text = a2;
            txtGrup.Text = a3;
            txtKdv.Text = a4;
            txtBirim.Text = a5;
            txtGiren.Text = a6;
            txtCikan.Text = a7;
            txtKalan.Text = a8;
        }
    }
}
