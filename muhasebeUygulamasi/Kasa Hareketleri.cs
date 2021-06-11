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
    public partial class Kasa_Hareketleri : Form
    {
        public Kasa_Hareketleri()
        {
            InitializeComponent();
        }
        public string a, b, c, d, f, g;
        private void Kasa_Hareketleri_Load(object sender, EventArgs e)
        {
            txtİd.Text = a;
            txtKod.Text = b;
            txtKasa.Text = c;
            txtGiren.Text = d;
            txtCikan.Text = f;
            txtKalan.Text = g;
        }
    }
}
