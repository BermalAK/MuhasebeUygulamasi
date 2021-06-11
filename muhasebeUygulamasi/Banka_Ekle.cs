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
    public partial class Banka_Ekle : Form
    {
        public Banka_Ekle()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Server=DESKTOP-SUDHIVL\SQLEXPRESS;Initial Catalog=MuhasebeUygulamasi;Integrated Security=True");

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Insert Into Banka_İslemleri(kod,bankaAdi,hesapAdi,giren,cikan,bakiye) VALUES " +
                          "(@kod,@bankaAdi,@hesapAdi,@giren,@cikan,@bakiye)", baglan);
            cmd.Parameters.AddWithValue("@kod",txtKod.Text);
            cmd.Parameters.AddWithValue("@bankaAdi", txtBankaAdi.Text);
            cmd.Parameters.AddWithValue("@hesapAdi", txtHesapAdi.Text);
            cmd.Parameters.AddWithValue("@giren", txtGiren.Text);
            cmd.Parameters.AddWithValue("@cikan", txtCikan.Text);
            cmd.Parameters.AddWithValue("@bakiye", txtBakiye.Text);
            baglan.Open();
            cmd.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Kayıt başarıyla eklenmiştir.");
        }
    }
}
