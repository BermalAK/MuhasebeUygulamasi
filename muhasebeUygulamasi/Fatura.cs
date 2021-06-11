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
    public partial class Fatura : Form
    {
        //private object baglan;

        public Fatura()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Server=DESKTOP-SUDHIVL\SQLEXPRESS;Initial Catalog=MuhasebeUygulamasi;Integrated Security=True");
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand komut;

        void griddoldur()
        {
            da = new SqlDataAdapter("Select *From Fatura_Ekle", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "Fatura_Ekle");
            dataGridView1.DataSource = ds.Tables["Fatura_Ekle"];
            baglanti.Close();
        }
        void KayıtSil(int id)
        {
            string sql = "DELETE FROM Fatura_Ekle WHERE id=@id";
            komut = new SqlCommand(sql, baglanti);
            komut.Parameters.AddWithValue("@id", id);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Fatura_Ekle fatura = new Fatura_Ekle();
            fatura.ShowDialog();
        }
        DataTable yenile()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select id as ID , tarih as Tarih , saat as Saat , faturaNo as FaturaNo , islemTuru as İşlemTürü , unvan as Unvan , tutar as Tutar , durum as Durum from Fatura_Ekle", baglanti);
            DataTable tablo = new DataTable();
            adtr.Fill(tablo);
            baglanti.Close();
            return tablo;
        }
        private void Fatura_Load(object sender, EventArgs e)
        {
            griddoldur();
            int kayitsayisi;
            kayitsayisi = dataGridView1.RowCount;
            label11.Text = kayitsayisi.ToString();

           /* if(radioFatura.Checked==true)
            {
                SqlCommand komut = new SqlCommand();
                komut.CommandText = "SELECT *FROM Fatura_Ekle";
                komut.Connection = baglanti;
                komut.CommandType = CommandType.Text;

                SqlDataReader dr;
                baglanti.Open();
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    comboBox1.Items.Add(dr["faturaNo"]);
                }
                baglanti.Close();
            }
            else if(radioDurum.Checked==true)
            {
                SqlCommand komut1 = new SqlCommand();
                komut1.CommandText = "SELECT *FROM Fatura_Ekle";
                komut1.Connection = baglanti;
                komut1.CommandType = CommandType.Text;

                SqlDataReader dr;
                baglanti.Open();
                dr = komut1 .ExecuteReader();
                while (dr.Read())
                {
                    comboBox1.Items.Add(dr["durum"]);
                }
                baglanti.Close();
            }*/

        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                KayıtSil(id);
            }
            griddoldur();
            MessageBox.Show("Kayıt silindi.");
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Fatura_Guncelle guncel = new Fatura_Guncelle();
            guncel.ShowDialog();
            griddoldur();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult yazdirmaIslemi;
            yazdirmaIslemi = printDialog1.ShowDialog();
            if (yazdirmaIslemi == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tablo = comboBox1.Text;
            string sorgu = "SELECT *FROM " + tablo;
            da = new SqlDataAdapter(sorgu, baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, tablo);
            dataGridView1.DataSource = ds.Tables[tablo];
            baglanti.Close();
        }
        public void TutarListele()
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM Fatura_Ekle";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["tutar"]);
            }
            baglanti.Close();
        }

        private void radioFatura_CheckedChanged(object sender, EventArgs e)
        {
           /* if (radioFatura.Checked == true)
            {
                SqlCommand komut = new SqlCommand();
                komut.CommandText = "SELECT *FROM Fatura_Ekle";
                komut.Connection = baglanti;
                komut.CommandType = CommandType.Text;

                SqlDataReader dr;
                baglanti.Open();
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    comboBox1.Items.Add(dr["faturaNo"]);
                }
                baglanti.Close();
            }*/
        }

        private void radioFatura_Click(object sender, EventArgs e)
        {
            if (radioFatura.Checked == true)
            {
                SqlCommand komut = new SqlCommand();
                komut.CommandText = "SELECT *FROM Fatura_Ekle";
                komut.Connection = baglanti;
                komut.CommandType = CommandType.Text;

                SqlDataReader dr;
                baglanti.Open();
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    comboBox1.Items.Add(dr["faturaNo"]);
                }
                baglanti.Close();
            }
        }

        private void radioUnvan_Click(object sender, EventArgs e)
        {
            if (radioUnvan.Checked == true)
            {
                comboBox1.Items.Add("Yönetici");
                comboBox1.Items.Add("Muhasebeci");
                comboBox1.Items.Add("Ustabaşı");
                comboBox1.Items.Add("Yönetim");
            }
        }

        private void radioİslemTuru_Click(object sender, EventArgs e)
        {
            if (radioİslemTuru.Checked == true)
            {
                comboBox1.Items.Add("Alış");
                comboBox1.Items.Add("Satış");
            }
        }

        private void radioTutar_Click(object sender, EventArgs e)
        {
            if (radioTutar.Checked == true)
            {
                comboBox1.Items.Add("12.000");
                comboBox1.Items.Add("20.000");
                comboBox1.Items.Add("100.000");
                comboBox1.Items.Add("50.000");
                comboBox1.Items.Add("250.000");
                comboBox1.Items.Add("25.000");
                comboBox1.Items.Add("125.000");
                comboBox1.Items.Add("30.000");
                comboBox1.Items.Add("160.000");
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if(radioFatura.Checked==true)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("select * from Fatura_Ekle where faturaNo like '%" + comboBox1.Text + "%'", baglanti);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglanti.Close();
            }
            else if(radioTutar.Checked==true)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("select * from Fatura_Ekle where tutar like '%" + comboBox1.Text + "%'", baglanti);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglanti.Close();
            }
            else if(radioUnvan.Checked==true)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("select * from Fatura_Ekle where unvan like '%" + comboBox1.Text + "%'", baglanti);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglanti.Close();
            }
            else if(radioDurum.Checked==true)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("select * from Fatura_Ekle where durum like '%" + comboBox1.Text + "%'", baglanti);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglanti.Close();
            }
            else
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("select * from Fatura_Ekle where islemTuru like '%" + comboBox1.Text + "%'", baglanti);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglanti.Close();
            }
        }

        private void radioDurum_Click(object sender, EventArgs e)
        {
            if (radioDurum.Checked == true)
            {
                comboBox1.Items.Add("Bekliyor.");
                comboBox1.Items.Add("Satış yapıldı.");
                comboBox1.Items.Add("Alış yapıldı.");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Tahsilat tahsilat = new Tahsilat();
            tahsilat.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
