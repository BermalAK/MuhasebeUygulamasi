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
    public partial class Firma_Ekle : Form
    {
        public Firma_Ekle()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Server=DESKTOP-SUDHIVL\SQLEXPRESS;Initial Catalog=MuhasebeUygulamasi;Integrated Security=True");
       

        private void btnFirmaEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Firma_Hesaplari (Kod,Unvan,Varsayilan,Donem) VALUES " +
                         "(@Kod,@Unvan,@Varsayilan,@Donem)", baglan);

            /*SqlParameter imageParameter = new SqlParameter("@resim", SqlDbType.Image);
            imageParameter.Value = DBNull.Value;
            cmd.Parameters.Add(imageParameter);*/

            cmd.Parameters.AddWithValue("@Kod", txtKod.Text);
            cmd.Parameters.AddWithValue("@Unvan", txtUnvan.Text);
            cmd.Parameters.AddWithValue("@Varsayilan", txtVarsayilan.Text);
            cmd.Parameters.AddWithValue("@Donem", txtDonem.Text);

            baglan.Open();
            cmd.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Veri başarıyla kaydedildi...");
        }
    }
}
