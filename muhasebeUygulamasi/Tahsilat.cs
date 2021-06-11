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
    public partial class Tahsilat : Form
    {
        public Tahsilat()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Server=DESKTOP-SUDHIVL\SQLEXPRESS;Initial Catalog=MuhasebeUygulamasi;Integrated Security=True");

        private void btnNakitTahsil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Fatura_Nakit (tarih,saat,islemNo,kasa,aciklama,islemTutari,firma) VALUES " +
                                     "(@tarih,@saat,@islemNo,@kasa,@aciklama,@islemTutari,@firma)", baglan);

            /*SqlParameter imageParameter = new SqlParameter("@resim", SqlDbType.Image);
            imageParameter.Value = DBNull.Value;
            cmd.Parameters.Add(imageParameter);*/

            cmd.Parameters.AddWithValue("@tarih", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@saat", dateTimePicker2.Value);
            cmd.Parameters.AddWithValue("@islemNo", txtİslemNo.Text);
            cmd.Parameters.AddWithValue("@kasa", txtKasa.Text);
            cmd.Parameters.AddWithValue("@aciklama", txtAciklama.Text);
            cmd.Parameters.AddWithValue("@islemTutari", txtİslemTutari.Text);
            cmd.Parameters.AddWithValue("@firma", comboBox1.Text);

            baglan.Open();
            cmd.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Tahsilat Başarılı");
            //griddoldur();
        }

        private void Tahsilat_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Ada Triko");
            comboBox1.Items.Add("Flaş Tekstil");
            comboBox1.Items.Add("Ugur Balkuv");
            comboBox1.Items.Add("Mango");
            comboBox1.Items.Add("Zara");
            comboBox1.Items.Add("Güleks");
            comboBox1.Items.Add("Ugur Konfeksiyon");
            comboBox2.Items.Add("Ada Triko");
            comboBox2.Items.Add("Flaş Tekstil");
            comboBox2.Items.Add("Ugur Balkuv");
            comboBox2.Items.Add("Mango");
            comboBox2.Items.Add("Zara");
            comboBox2.Items.Add("Güleks");
            comboBox2.Items.Add("Ugur Konfeksiyon");
        }

        private void btnKrediTahsil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Fatura_Kredi (tarih,saat,islemNo,banka,aciklama,islemTuru,firma) VALUES " +
                                     "(@tarih,@saat,@islemNo,@banka,@aciklama,@islemTuru,@firma)", baglan);

            /*SqlParameter imageParameter = new SqlParameter("@resim", SqlDbType.Image);
            imageParameter.Value = DBNull.Value;
            cmd.Parameters.Add(imageParameter);*/

            cmd.Parameters.AddWithValue("@tarih", dateTimePicker4.Value);
            cmd.Parameters.AddWithValue("@saat", dateTimePicker3.Value);
            cmd.Parameters.AddWithValue("@islemNo",islemNo.Text);
            cmd.Parameters.AddWithValue("@banka", txtBanka.Text);
            cmd.Parameters.AddWithValue("@aciklama",aciklama.Text);
            cmd.Parameters.AddWithValue("@islemTuru",tutar.Text);
            cmd.Parameters.AddWithValue("@firma", comboBox2.Text);

            baglan.Open();
            cmd.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Tahsilat Başarılı");
        }
    }
}
