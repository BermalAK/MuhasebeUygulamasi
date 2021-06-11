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
    public partial class KullaniciHesaplari : Form
    {
        public KullaniciHesaplari()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Server=DESKTOP-SUDHIVL\SQLEXPRESS;Initial Catalog=MuhasebeUygulamasi;Integrated Security=True");
        private void KullaniciHesaplari_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM Firma_Hesaplari";
            komut.Connection = baglan;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglan.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["id"]);
            }
            baglan.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "") foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            baglan.Open();
            SqlCommand komut = new SqlCommand("select * from Firma_Hesaplari where id like '" + comboBox1.Text + "'", baglan);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtKod.Text = read["Kod"].ToString();
                txtUnvan.Text = read["Unvan"].ToString();
                txtVarsayilan.Text = read["Varsayilan"].ToString();
                txtDonem.Text = read["Donem"].ToString();

            }
            baglan.Close();
        }
    }
}
