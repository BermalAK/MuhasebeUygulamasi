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
    public partial class Cek_Ekle : Form
    {
        public Cek_Ekle()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Server=DESKTOP-SUDHIVL\SQLEXPRESS;Initial Catalog=MuhasebeUygulamasi;Integrated Security=True");

        private void btnTeklifEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Insert Into Cek_Senet(tarih,vade,portfoyNo,islemTuru,unvan,tutar,gun,durum) VALUES " +
                          "(@tarih,@vade,@portfoyNo,@islemTuru,@unvan,@tutar,@gun,@durum)", baglan);
            cmd.Parameters.AddWithValue("@tarih", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@vade", txtVade.Text);
            cmd.Parameters.AddWithValue("@portfoyNo", txtPortfoy.Text);
            cmd.Parameters.AddWithValue("@islemTuru", islemTuru.Text);
            cmd.Parameters.AddWithValue("@unvan", txtUnvan.Text);
            cmd.Parameters.AddWithValue("@tutar", txtTutar.Text);
            cmd.Parameters.AddWithValue("@gun", txtGun.Text);
            cmd.Parameters.AddWithValue("@durum", txtDurum.Text);
            baglan.Open();
            cmd.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Kayıt başarıyla eklenmiştir.");
        }
    }
}
