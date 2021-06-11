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
    public partial class Fatura_Ekle : Form
    {
        public Fatura_Ekle()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Server=DESKTOP-SUDHIVL\SQLEXPRESS;Initial Catalog=MuhasebeUygulamasi;Integrated Security=True");

       /* void griddoldur()
        {
            da = new SqlDataAdapter("Select *From Fatura_Ekle", baglan);
            ds = new DataSet();
            baglan.Open();
            da.Fill(ds, "Fatura_Ekle");
            dataGridView1.DataSource = ds.Tables["Fatura_Ekle"];
            baglan.Close();
        }*/
        private void faturaEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Fatura_Ekle (tarih,saat,faturaNo,islemTuru,unvan,tutar,durum) VALUES " +
                         "(@tarih,@saat,@faturaNo,@islemTuru,@unvan,@tutar,@durum)", baglan);

            /*SqlParameter imageParameter = new SqlParameter("@resim", SqlDbType.Image);
            imageParameter.Value = DBNull.Value;
            cmd.Parameters.Add(imageParameter);*/

            cmd.Parameters.AddWithValue("@tarih", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@saat", dateTimePicker2.Value);
            cmd.Parameters.AddWithValue("@faturaNo", faturaNo.Text);
            cmd.Parameters.AddWithValue("@islemTuru", islemTuru.Text);
            cmd.Parameters.AddWithValue("@unvan", txtUnvan.Text);
            cmd.Parameters.AddWithValue("@tutar", txtTutar.Text);
            cmd.Parameters.AddWithValue("@durum", txtDurum.Text);
            
            baglan.Open();
            cmd.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Veri başarıyla kaydedildi...");
            //griddoldur();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Fatura_Ekle_Load(object sender, EventArgs e)
        {

        }
    }
}
