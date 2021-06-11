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
    public partial class Cari_Guncelle : Form
    {
        public Cari_Guncelle()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Server=DESKTOP-SUDHIVL\SQLEXPRESS;Initial Catalog=MuhasebeUygulamasi;Integrated Security=True");

        public void listele()
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM Cari_Ekle";
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
        private void Cari_Guncelle_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "") foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            baglan.Open();
            SqlCommand komut = new SqlCommand("select * from Cari_Ekle where kod like '" + comboBox1.Text + "'", baglan);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtUnvan.Text = read["unvan"].ToString();
                txtGrup.Text = read["grup"].ToString();
                txtBorc.Text = read["borc"].ToString();
                txtBakiye.Text = read["bakiye"].ToString();
                txtAlacak.Text = read["alacak"].ToString();

            }
            baglan.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            // string kayit = "update Fatura_Ekle set tarih=@tarih , saat=@saat , islemTuru=@islemTuru , unvan=@unvan , tutar=@tutar , durum=@durum where faturaNo="+comboBox1.Text;
            SqlCommand komut = new SqlCommand("update Cari_Ekle set unvan=@unvan , grup=@grup , borc=@borc , bakiye=@bakiye , alacak=@alacak where kod=" + comboBox1.Text, baglan);
            komut.Parameters.AddWithValue("@unvan", txtUnvan.Text);
            komut.Parameters.AddWithValue("@grup", txtGrup.Text);
            komut.Parameters.AddWithValue("@borc", txtBorc.Text);
            komut.Parameters.AddWithValue("@bakiye", txtBakiye.Text);
            komut.Parameters.AddWithValue("@alacak", txtAlacak.Text);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Kayıt başarıyla güncellendi.");
        }
    }
}
