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
    public partial class Banka_Guncelle : Form
    {
        public Banka_Guncelle()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Server=DESKTOP-SUDHIVL\SQLEXPRESS;Initial Catalog=MuhasebeUygulamasi;Integrated Security=True");
        public void listele()
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM Banka_İslemleri";
            komut.Connection = baglan;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglan.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["kod"]);
            }
            baglan.Close();
        }
        private void Banka_Guncelle_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            // string kayit = "update Fatura_Ekle set tarih=@tarih , saat=@saat , islemTuru=@islemTuru , unvan=@unvan , tutar=@tutar , durum=@durum where faturaNo="+comboBox1.Text;
            SqlCommand komut = new SqlCommand("update Banka_İslemleri set bankaAdi=@bankaAdi , hesapAdi=@hesapAdi , giren=@giren , cikan=@cikan , bakiye=@bakiye where kod=" + comboBox1.Text, baglan);
            komut.Parameters.AddWithValue("@bankaAdi", txtBankaAdi.Text);
            komut.Parameters.AddWithValue("@hesapAdi", txtHesapAdi.Text);
            komut.Parameters.AddWithValue("@giren", txtGiren.Text);
            komut.Parameters.AddWithValue("@cikan", txtCikan.Text);
            komut.Parameters.AddWithValue("@bakiye", txtBakiye.Text);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Kayıt başarıyla güncellendi.");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "") foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            baglan.Open();
            SqlCommand komut = new SqlCommand("select * from Banka_İslemleri where kod like '" + comboBox1.Text + "'", baglan);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtBankaAdi.Text = read["bankaAdi"].ToString();
                txtHesapAdi.Text = read["hesapAdi"].ToString();
                txtGiren.Text = read["giren"].ToString();
                txtCikan.Text = read["cikan"].ToString();
                txtBakiye.Text = read["bakiye"].ToString();

            }
            baglan.Close();
        }
    }
}
