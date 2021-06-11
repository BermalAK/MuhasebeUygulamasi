using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace muhasebeUygulamasi
{
    public partial class Grafik : Form
    {
        public Grafik()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Server=DESKTOP-SUDHIVL\SQLEXPRESS;Initial Catalog=MuhasebeUygulamasi;Integrated Security=True");

        private void btnFatura_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("select faturaNo,tutar from Fatura_Ekle", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                chart1.Series["Muhasebe"].Points.AddXY(oku[0], oku[1]);
            }
            baglan.Close();
        }

        private void btnBanka_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("select hesapAdi,bakiye from Banka_İslemleri", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                chart1.Series["Muhasebe"].Points.AddXY(oku[0], oku[1]);
            }
            baglan.Close();
        }

        private void btnKasa_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("select kasaAdi,bakiye from Kasa_İslemleri", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                chart1.Series["Muhasebe"].Points.AddXY(oku[0], oku[1]);
            }
            baglan.Close();
        }

        private void btnStok_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("select stokAdi,kalan from Stok_Ekle", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                chart1.Series["Muhasebe"].Points.AddXY(oku[0], oku[1]);
            }
            baglan.Close();
        }
    }
}
