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
    public partial class SifreDeğistir : Form
    {
        public SifreDeğistir()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Server=DESKTOP-SUDHIVL\SQLEXPRESS;Initial Catalog=MuhasebeUygulamasi;Integrated Security=True");
        public void SifreDeğiştir()
        {
            try
            {
                baglan.Open();
                string kayit = "update KullaniciGirisi set sifre=@sifre where kuladi='" + lblkullaniciad.Text + "'";
                SqlCommand guncelle = new SqlCommand(kayit, baglan);
                guncelle.Parameters.AddWithValue("@sifre", txtsifre.Text);
                guncelle.ExecuteNonQuery();
                baglan.Close();
                lblHata.Visible = true;
                lblHata.ForeColor = Color.Green;
                lblHata.Text = "Şifre Başarıyla Değiştirildi";
            }
            catch (Exception)
            {
                lblHata.Visible = true;
                lblHata.ForeColor = Color.Red;
                lblHata.Text = "Şifre Değiştirme Hatası";
            }

        }
       
        private void SifreDeğistir_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = false;

            try
            {
                SqlCommand mevcutsifre = new SqlCommand();
                baglan.Open();
                mevcutsifre.Connection = baglan;
                mevcutsifre.CommandText = "select * from KullaniciGirisi where kuladi='" + lblkullaniciad.Text + "'";
                SqlDataReader dr = mevcutsifre.ExecuteReader();
                if (dr.Read())
                {
                    mevcutSifre1.Text = dr["sifre"].ToString();
                }
                baglan.Close();
            }
            catch (Exception)
            {
                lblHata.Visible = true;
                lblHata.ForeColor = Color.Red;
                lblHata.Text = "Mevcut Şifre Getirilemiyor";
            }
        }

        private void btnSifreGuncelle_Click(object sender, EventArgs e)
        {
            if (txtsifre.Text == txtsifretekrar.Text)
            {
                if (txtsifre.Text != "" && txtsifretekrar.Text != "" && mevcutSifre1.Text != "")
                {
                    SifreDeğiştir();
                }
                else
                {
                    lblHata.Visible = true;
                    lblHata.ForeColor = Color.Red;
                    lblHata.Text = "Alanları Boş Bırakmayınız";
                }
            }
            else
            {
                lblHata.Visible = true;
                lblHata.ForeColor = Color.Red;
                lblHata.Text = "Şifreler Eşleşmiyor";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                mevcutSifre1.UseSystemPasswordChar = true;
                txtsifre.UseSystemPasswordChar = true;
                txtsifretekrar.UseSystemPasswordChar = true;
            }
            else
            {
                mevcutSifre1.UseSystemPasswordChar = false;
                txtsifre.UseSystemPasswordChar = false;
                txtsifretekrar.UseSystemPasswordChar = false;
            }
        }
    }
}
