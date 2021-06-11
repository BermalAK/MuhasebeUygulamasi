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
    public partial class Cek_Guncelle : Form
    {
        public Cek_Guncelle()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Server=DESKTOP-SUDHIVL\SQLEXPRESS;Initial Catalog=MuhasebeUygulamasi;Integrated Security=True");
        public void listele()
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM Cek_Senet";
            komut.Connection = baglan;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglan.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["portfoyNo"]);
            }
            baglan.Close();
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            // string kayit = "update Fatura_Ekle set tarih=@tarih , saat=@saat , islemTuru=@islemTuru , unvan=@unvan , tutar=@tutar , durum=@durum where faturaNo="+comboBox1.Text;
            SqlCommand komut = new SqlCommand("update Cek_Senet set tarih=@tarih , vade=@vade , islemTuru=@islemTuru , unvan=@unvan , tutar=@tutar ,gun=@gun, durum=@durum where portfoyNo=" + comboBox1.Text, baglan);
            komut.Parameters.AddWithValue("@tarih", dateTimePicker1.Value);
            komut.Parameters.AddWithValue("@vade", txtVade.Text);
            komut.Parameters.AddWithValue("@islemTuru", islemTuru.Text);
            komut.Parameters.AddWithValue("@unvan", txtUnvan.Text);
            komut.Parameters.AddWithValue("@tutar", txtTutar.Text);
            komut.Parameters.AddWithValue("@gun", txtGun.Text);
            komut.Parameters.AddWithValue("@durum", txtDurum.Text);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Kayıt başarıyla güncellendi.");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "") foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            baglan.Open();
            SqlCommand komut = new SqlCommand("select * from Cek_Senet where portfoyNo like '" + comboBox1.Text + "'", baglan);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                dateTimePicker1.Text = read["tarih"].ToString();
                txtVade.Text = read["vade"].ToString();
                islemTuru.Text = read["islemTuru"].ToString();
                txtUnvan.Text = read["unvan"].ToString();
                txtTutar.Text = read["tutar"].ToString();
                txtGun.Text = read["gun"].ToString();
                txtDurum.Text = read["durum"].ToString();

            }
            baglan.Close();
        }

        private void Cek_Guncelle_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}
