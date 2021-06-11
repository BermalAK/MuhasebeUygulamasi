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
    public partial class Firma_Guncelle : Form
    {
        public Firma_Guncelle()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Server=DESKTOP-SUDHIVL\SQLEXPRESS;Initial Catalog=MuhasebeUygulamasi;Integrated Security=True");

        public void listele()
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM Firma_Hesaplari";
            komut.Connection = baglan;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglan.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["Kod"]);
            }
            baglan.Close();
        }
        private void Firma_Guncelle_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "") foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            baglan.Open();
            SqlCommand komut = new SqlCommand("select * from Firma_Hesaplari where Kod like '" + comboBox1.Text + "'", baglan);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtUnvan.Text = read["Unvan"].ToString();
                txtVarsayilan.Text = read["Varsayilan"].ToString();
                txtDonem.Text = read["Donem"].ToString();

            }
            baglan.Close();
        }

        private void btnFirmaGuncelle_Click(object sender, EventArgs e)
        {
          /*  baglan.Open();
            // string kayit = "update Fatura_Ekle set tarih=@tarih , saat=@saat , islemTuru=@islemTuru , unvan=@unvan , tutar=@tutar , durum=@durum where faturaNo="+comboBox1.Text;
            SqlCommand komut = new SqlCommand("update Firma_Hesaplari set Unvan=@Unvan , Varsayilan=@Varsayilan , Donem=@Donem where Kod=" + comboBox1.Text, baglan);
            komut.Parameters.AddWithValue("@Unvan", txtUnvan.Text);
            komut.Parameters.AddWithValue("@Varsayilan", txtVarsayilan.Text);
            komut.Parameters.AddWithValue("@Donem", txtDonem.Text);

            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Kayıt başarıyla güncellendi.");*/


            baglan.Open();
            SqlCommand komut = new SqlCommand("update Firma_Hesaplari set Unvan=@Unvan , Varsayilan=@Varsayilan , Donem=@Donem where Kod=" + comboBox1.Text, baglan);
            komut.Parameters.AddWithValue("@Unvan", txtUnvan.Text);
            komut.Parameters.AddWithValue("@Varsayilan", txtVarsayilan.Text);
            komut.Parameters.AddWithValue("@Donem", txtDonem.Text);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Kayıt başarıyla güncellendi.");

        }
    }
}
