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
    public partial class Stok_Ekle : Form
    {
        public Stok_Ekle()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Server=DESKTOP-SUDHIVL\SQLEXPRESS;Initial Catalog=MuhasebeUygulamasi;Integrated Security=True");

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Insert Into Stok_Ekle(kod,stokAdi,grup,kdv,birim,giren,cikan,kalan) VALUES (@kod,@stokAdi,@grup,@kdv,@birim,@giren,@cikan,@kalan)", baglan);

            cmd.Parameters.AddWithValue("@kod", txtKod.Text);
            cmd.Parameters.AddWithValue("@stokAdi", txtstokAdi.Text);
            cmd.Parameters.AddWithValue("@grup", txtGrup.Text);
            cmd.Parameters.AddWithValue("@kdv", txtKdv.Text);
            cmd.Parameters.AddWithValue("@birim", txtBirim.Text);
            cmd.Parameters.AddWithValue("@giren", txtGiren.Text);
            cmd.Parameters.AddWithValue("@cikan", txtCikan.Text);
            cmd.Parameters.AddWithValue("@kalan", txtKalan.Text);

            baglan.Open();
            cmd.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Kayit başariyla eklendi.");
        }
    }
}
