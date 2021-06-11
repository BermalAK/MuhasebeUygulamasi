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
    public partial class Stok_Güncelleme : Form
    {
        public Stok_Güncelleme()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Server=DESKTOP-SUDHIVL\SQLEXPRESS;Initial Catalog=MuhasebeUygulamasi;Integrated Security=True");

        public void Listele()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * from Stok_Ekle";
            cmd.Connection = baglan;
            cmd.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglan.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["kod"]);
            }
            baglan.Close();
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            // string kayit = "update Fatura_Ekle set tarih=@tarih , saat=@saat , islemTuru=@islemTuru , unvan=@unvan , tutar=@tutar , durum=@durum where faturaNo="+comboBox1.Text;
            SqlCommand komut = new SqlCommand("update Stok_Ekle set stokAdi=@stokAdi , grup=@grup , kdv=@kdv ,birim=@birim , giren=@giren , cikan=@cikan , kalan=@kalan where kod=" + comboBox1.Text, baglan);
            komut.Parameters.AddWithValue("@stokAdi", txtstokAdi.Text);
            komut.Parameters.AddWithValue("@grup", txtGrup.Text);
            komut.Parameters.AddWithValue("@kdv", txtKdv.Text);
            komut.Parameters.AddWithValue("@birim", txtBirim.Text);
            komut.Parameters.AddWithValue("@giren", txtGiren.Text);
            komut.Parameters.AddWithValue("@cikan", txtCikan.Text);
            komut.Parameters.AddWithValue("@kalan", txtKalan.Text);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Kayıt başarıyla güncellendi.");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "") foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            baglan.Open();
            SqlCommand komut = new SqlCommand("select * from Stok_Ekle where kod like '" + comboBox1.Text + "'", baglan);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtstokAdi.Text = read["stokAdi"].ToString();
                txtGrup.Text = read["grup"].ToString();
                txtKdv.Text = read["kdv"].ToString();
                txtBirim.Text = read["birim"].ToString();
                txtGiren.Text = read["giren"].ToString();
                txtCikan.Text = read["cikan"].ToString();
                txtKalan.Text = read["kalan"].ToString();
            }
            baglan.Close();
        }

        private void Stok_Güncelleme_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
