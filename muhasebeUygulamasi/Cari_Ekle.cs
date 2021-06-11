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
    public partial class Cari_Ekle : Form
    {
        public Cari_Ekle()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Server=DESKTOP-SUDHIVL\SQLEXPRESS;Initial Catalog=MuhasebeUygulamasi;Integrated Security=True");

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Insert into Cari_Ekle (kod,unvan,grup,borc,alacak,bakiye) VALUES (@kod,@unvan,@grup,@borc,@alacak,@bakiye)", baglan);

            cmd.Parameters.AddWithValue("@kod",txtKod.Text);
            cmd.Parameters.AddWithValue("@unvan",txtUnvan.Text);
            cmd.Parameters.AddWithValue("@grup",txtGrup.Text);
            cmd.Parameters.AddWithValue("@borc",txtBorc.Text);
            cmd.Parameters.AddWithValue("alacak",txtAlacak.Text);
            cmd.Parameters.AddWithValue("bakiye",txtBakiye.Text);

            baglan.Open();
            cmd.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Bilgiler başarıyla kaydedildi.");
        }

        private void Cari_Ekle_Load(object sender, EventArgs e)
        {

        }
    }
}
