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
    public partial class Teklif_Guncelle : Form
    {
        public Teklif_Guncelle()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Server=DESKTOP-SUDHIVL\SQLEXPRESS;Initial Catalog=MuhasebeUygulamasi;Integrated Security=True");
        public void listele()
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM Teklif_İslemleri";
            komut.Connection = baglan;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglan.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["teklifNo"]);
            }
            baglan.Close();
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            // string kayit = "update Fatura_Ekle set tarih=@tarih , saat=@saat , islemTuru=@islemTuru , unvan=@unvan , tutar=@tutar , durum=@durum where faturaNo="+comboBox1.Text;
            SqlCommand komut = new SqlCommand("update Teklif_İslemleri set tarih=@tarih , saat=@saat , islemTuru=@islemTuru , unvan=@unvan , tutar=@tutar , durum=@durum where teklifNo=" + comboBox1.Text, baglan);
            komut.Parameters.AddWithValue("@tarih", dateTimePicker1.Value);
            komut.Parameters.AddWithValue("@saat", dateTimePicker2.Value);
            komut.Parameters.AddWithValue("@islemTuru", islemTuru.Text);
            komut.Parameters.AddWithValue("@unvan", txtUnvan.Text);
            komut.Parameters.AddWithValue("@tutar", txtTutar.Text);
            komut.Parameters.AddWithValue("@durum", txtDurum.Text);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Kayıt başarıyla güncellendi.");
        }

        private void Teklif_Guncelle_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "") foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            baglan.Open();
            SqlCommand komut = new SqlCommand("select * from Teklif_İslemleri where teklifNo like '" + comboBox1.Text + "'", baglan);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                dateTimePicker1.Text = read["tarih"].ToString();
                dateTimePicker2.Text = read["saat"].ToString();
                islemTuru.Text = read["islemTuru"].ToString();
                txtUnvan.Text = read["unvan"].ToString();
                txtTutar.Text = read["tutar"].ToString();
                txtDurum.Text = read["durum"].ToString();

            }
            baglan.Close();

        }
    }
}
