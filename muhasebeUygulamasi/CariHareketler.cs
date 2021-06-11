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
    public partial class CariHareketler : Form
    {
        public CariHareketler()
        {
            InitializeComponent();
        }
        public string a, b, c, d, f, g , h;

        private void CariHareketler_Load(object sender, EventArgs e)
        {
            txtİd.Text = a;
            txtKod.Text = b;
            txtUnvan.Text = c;
            txtGrup.Text = d;
            txtBorc.Text = f;
            txtAlacak.Text = g;
            txtBakiye.Text = h;
        }
    }
}
