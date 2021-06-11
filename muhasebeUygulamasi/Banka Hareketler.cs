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
    public partial class Banka_Hareketleri : Form
    {
        public Banka_Hareketleri()
        {
            InitializeComponent();
        }

        public string a, b, c, d, g, f ,h;
        private void Banka_Hareketleri_Load(object sender, EventArgs e)
        {
            txtİd.Text = a;
            txtKod.Text = b;
            txtBanka.Text = c;
            txtHesap.Text =d;
            txtGiren.Text = f;
            txtCikan.Text = g;
            txtKalan.Text = h;
            
        }
    }
}
