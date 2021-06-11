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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fatura fat = new Fatura();
            fat.ShowDialog();
        }

        private void siparişİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bankaİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void faturaİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fatura f1 = new Fatura();
            f1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            İrsaliye irs = new İrsaliye();
            irs.ShowDialog();
        }

        private void irsaliyeİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            İrsaliye irss = new İrsaliye();
            irss.ShowDialog();
        }

        private void çekSenetİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Teklif_İşlemleri tek = new Teklif_İşlemleri();
            tek.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Teklif_İşlemleri tek = new Teklif_İşlemleri();
            tek.ShowDialog();
                
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Çek çekk = new Çek();
            çekk.ShowDialog();
        }

        private void stokİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Çek çek = new Çek();
            çek.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Cari cari = new Cari();
            cari.ShowDialog();
        }

        private void kasaİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cari carii = new Cari();
            carii.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Stok stok = new Stok();
            stok.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Stok stokk = new Stok();
            stokk.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Banka banka = new Banka();
            banka.ShowDialog();
        }

        private void raporİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Banka bankaa = new Banka();
            bankaa.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Kasa kasa = new Kasa();
            kasa.ShowDialog();
        }

        private void istatistikİşlemlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kasa kasaa=new Kasa();
            kasaa.ShowDialog();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sipariş_İşlemleri sip = new Sipariş_İşlemleri();
            sip.ShowDialog();
        }

        private void ayarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void firmaBilgisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Firma_Hesapları frm = new Firma_Hesapları();
            frm.ShowDialog();
        }

        private void yardımToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hakkımızdaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Hakkımızda hk = new Hakkımızda();
            hk.ShowDialog();
        }

        private void kullanıcıHesaplarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciHesaplari klh = new KullaniciHesaplari();
            klh.ShowDialog();
        }

        private void şifremiDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SifreDeğistir sifre = new SifreDeğistir();
            sifre.ShowDialog();
        }

        private void yardımToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com.tr/");
        }

        private void yazıcıAyarlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Raporlama rpr = new Raporlama();
            rpr.ShowDialog();
        }

        private void faturaİşlemleriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FaturaBarcode ftrbar = new FaturaBarcode();
            ftrbar.ShowDialog();
        }

        private void irsaliyeİşlemleriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            İrsaliyebarcode irsbar = new İrsaliyebarcode();
            irsbar.ShowDialog();
        }

        private void siparişİşlemleriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SiparisBarcode siparisBarcode = new SiparisBarcode();
            siparisBarcode.ShowDialog();
        }

        private void faturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FaturaBarcode ftrbar1 = new FaturaBarcode();
            ftrbar1.ShowDialog();
        }

        private void irsaliyeİşlemleriToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            İrsaliyebarcode irsbar1 = new İrsaliyebarcode();
            irsbar1.ShowDialog();
        }

        private void siparişİşlemleriToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SiparisBarcode siparisBarcode1 = new SiparisBarcode();
            siparisBarcode1.ShowDialog();
        }

        private void teklifİşlemleriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TeklifBarcode teklifBarcode = new TeklifBarcode();
            teklifBarcode.ShowDialog();
        }

        private void teklifİşlemlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeklifBarcode teklifBarcode = new TeklifBarcode();
            teklifBarcode.ShowDialog();
        }

        private void cariİşlemlerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CariBarcode cariBarcode = new CariBarcode();
            cariBarcode.ShowDialog();
        }

        private void cariİşlemlerToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CariBarcode cariBarcode1 = new CariBarcode();
            cariBarcode1.ShowDialog();
        }

        private void çekSenetİşlemleriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CekSenetBarcode cekSenetBarcode = new CekSenetBarcode();
            cekSenetBarcode.ShowDialog();
        }

        private void çekSenetİşlemlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CekSenetBarcode cekSenetBarcode1 = new CekSenetBarcode();
            cekSenetBarcode1.ShowDialog();
        }

        private void stokİşlemleriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StokBarcode stokBarcode = new StokBarcode();
            stokBarcode.ShowDialog();
        }

        private void stokİşlemleriToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            StokBarcode stokBarcode1 = new StokBarcode();
            stokBarcode1.ShowDialog();
        }

        private void bankaİşlemleriToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            BankaBarcode bankaBarcode = new BankaBarcode();
            bankaBarcode.ShowDialog();
        }

        private void bankaİşlemleriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BankaBarcode bankaBarcode1 = new BankaBarcode();
            bankaBarcode1.ShowDialog();
        }

        private void kasaİşlemleriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            KasaBarcode kasaBarcode = new KasaBarcode();
            kasaBarcode.ShowDialog();
        }

        private void kasaİşlemleriToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            KasaBarcode kasaBarcode1 = new KasaBarcode();
            kasaBarcode1.ShowDialog();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Raporlama raporlama = new Raporlama();
            raporlama.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Grafik grafik = new Grafik();
            grafik.ShowDialog();
        }
    }
}
