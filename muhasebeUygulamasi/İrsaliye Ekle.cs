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
    public partial class İrsaliye_Ekle : Form
    {
        public İrsaliye_Ekle()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Server=DESKTOP-SUDHIVL\SQLEXPRESS;Initial Catalog=MuhasebeUygulamasi;Integrated Security=True");
        private void faturaEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Insert Into İrsaliye_Ekle(tarih,saat,irsaliyeNo,islemTuru,unvan,tutar,durum) VALUES " +
                "(@tarih,@saat,@irsaliyeNo,@islemTuru,@unvan,@tutar,@durum)",baglan);

            cmd.Parameters.AddWithValue("@tarih", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@saat", dateTimePicker2.Value);
            cmd.Parameters.AddWithValue("@irsaliyeNo", irsaliyeNo.Text);
            cmd.Parameters.AddWithValue("@islemTuru", islemTuru.Text);
            cmd.Parameters.AddWithValue("@unvan", txtUnvan.Text);
            cmd.Parameters.AddWithValue("@tutar", txtTutar.Text);
            cmd.Parameters.AddWithValue("@durum", txtDurum.Text);

            baglan.Open();
            cmd.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("İrsaliye başarıyla kaydedildi.");

        }
    }
}
