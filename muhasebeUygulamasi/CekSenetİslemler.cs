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
    public partial class CekSenetİslemler : Form
    {
        public CekSenetİslemler()
        {
            InitializeComponent();
        }

        private void btnKasa_Click(object sender, EventArgs e)
        {
            CekKasa cekKasa = new CekKasa();
            cekKasa.ShowDialog();
        }

        private void btnBanka_Click(object sender, EventArgs e)
        {
            CekSenetBankadan cekSenetBankadan = new CekSenetBankadan();
            cekSenetBankadan.ShowDialog();
        }
    }
}
