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
    public partial class Siparis_Ekle : Form
    {
        public Siparis_Ekle()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Server=DESKTOP-SUDHIVL\SQLEXPRESS;Initial Catalog=MuhasebeUygulamasi;Integrated Security=True");

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Insert Into Siparis_Ekle(tarih,saat,siparisNo,islemTuru,unvan,tutar,durum) VALUES " +
                           "(@tarih,@saat,@siparisNo,@islemTuru,@unvan,@tutar,@durum)", baglan);

            cmd.Parameters.AddWithValue("@tarih", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@saat", dateTimePicker2.Value);
            cmd.Parameters.AddWithValue("@siparisNo", faturaNo.Text);
            cmd.Parameters.AddWithValue("@islemTuru", islemTuru.Text);
            cmd.Parameters.AddWithValue("@unvan", txtUnvan.Text);
            cmd.Parameters.AddWithValue("@tutar", txtTutar.Text);
            cmd.Parameters.AddWithValue("@durum", txtDurum.Text);

            baglan.Open();
            cmd.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Sipariş başarıyla kaydedildi.");
        }
    }
}
