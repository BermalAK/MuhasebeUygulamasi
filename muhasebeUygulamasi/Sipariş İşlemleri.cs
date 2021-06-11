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
    public partial class Sipariş_İşlemleri : Form
    {
        public Sipariş_İşlemleri()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Server=DESKTOP-SUDHIVL\SQLEXPRESS;Initial Catalog=MuhasebeUygulamasi;Integrated Security=True");
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand cmd;

        void griddoldur()
        {
            da = new SqlDataAdapter("select * from Siparis_Ekle",baglan);
            ds = new DataSet();
            baglan.Open();
            da.Fill(ds, "Siparis_Ekle");
            dataGridView1.DataSource = ds.Tables["Siparis_Ekle"];
            baglan.Close();
        }
        DataTable yenile()
        {
            baglan.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select id as ID , tarih as Tarih , saat as Saat , siparisNo as SiparisNo , islemTuru as İşlemTürü , unvan as Unvan , tutar as Tutar , durum as Durum from Siparis_Ekle", baglan);
            DataTable tablo = new DataTable();
            adtr.Fill(tablo);
            baglan.Close();
            return tablo;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Siparis_Ekle sip = new Siparis_Ekle();
            sip.ShowDialog();
            griddoldur();
        }

        private void Sipariş_İşlemleri_Load(object sender, EventArgs e)
        {
            griddoldur();
            int kayitsayisi;
            kayitsayisi = dataGridView1.RowCount;
            label11.Text = kayitsayisi.ToString();
        }
        void KayitSil(int id)
        {
            string sql = "Delete from Siparis_Ekle where id=@id";
            cmd = new SqlCommand(sql, baglan);
            cmd.Parameters.AddWithValue("@id", id);
            baglan.Open();
            cmd.ExecuteNonQuery();
            baglan.Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                KayitSil(id);
                MessageBox.Show("Kayıt silindi.");
            }
            griddoldur();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult yazdirma;
            yazdirma = printDialog1.ShowDialog();
            if(yazdirma==DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Siparis_Guncelle sip = new Siparis_Guncelle();
            sip.ShowDialog();
            griddoldur();
        }

        private void radioSiparis_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM Siparis_Ekle";
            komut.Connection = baglan;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglan.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["siparisNo"]);
            }
            baglan.Close();
        }

        private void radioUnvan_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Nehir Tekstil");
            comboBox1.Items.Add("Ada Triko");
            comboBox1.Items.Add("Sebastian Tekstil");
            comboBox1.Items.Add("Anadolu Tekstil");
        }

        private void radioİslemTuru_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Yeni Sipariş");
            comboBox1.Items.Add("Eski Sipariş");
        }

        private void radioTutar_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Add("15.000");
            comboBox1.Items.Add("100.000");
            comboBox1.Items.Add("200.000");
            comboBox1.Items.Add("300.000");
            comboBox1.Items.Add("20.000");
            comboBox1.Items.Add("30.000");
            comboBox1.Items.Add("150.000");
            comboBox1.Items.Add("260.000");
            comboBox1.Items.Add("130.000");
            comboBox1.Items.Add("220.000");
            comboBox1.Items.Add("50.000");
            comboBox1.Items.Add("60.000");
            comboBox1.Items.Add("70.000");
            comboBox1.Items.Add("80.000");
            comboBox1.Items.Add("90.000");
        }

        private void radioDurum_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Sipariş Alındı.");
            comboBox1.Items.Add("Ön Kayıt Alındı.");
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if(radioSiparis.Checked==true)
            {
                baglan.Open();
                SqlCommand cmd = new SqlCommand("select * from Siparis_Ekle where siparisNo like '%" + comboBox1.Text + "%'", baglan);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglan.Close();
            }
            else if(radioDurum.Checked == true)
            {
                baglan.Open();
                SqlCommand cmd = new SqlCommand("select * from Siparis_Ekle where durum like '%" + comboBox1.Text + "%'", baglan);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglan.Close();
            }
            else if(radioTutar.Checked == true)
            {
                baglan.Open();
                SqlCommand cmd = new SqlCommand("select * from Siparis_Ekle where tutar like '%" + comboBox1.Text + "%'", baglan);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglan.Close();
            }
            else if(radioUnvan.Checked == true)
            {
                baglan.Open();
                SqlCommand cmd = new SqlCommand("select * from Siparis_Ekle where unvan like '%" + comboBox1.Text + "%'", baglan);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglan.Close();
            }
            else
            {
                baglan.Open();
                SqlCommand cmd = new SqlCommand("select * from Siparis_Ekle where islemTuru like '%" + comboBox1.Text + "%'", baglan);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglan.Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SiparisiAktar siparisiAktar = new SiparisiAktar();
            siparisiAktar.a = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            siparisiAktar.b = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            siparisiAktar.c = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            siparisiAktar.d = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            siparisiAktar.f = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            siparisiAktar.g = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            siparisiAktar.h = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            siparisiAktar.k = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            siparisiAktar.Show();
        }
    }
}
