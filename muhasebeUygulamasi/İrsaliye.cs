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
    public partial class İrsaliye : Form
    {
        public İrsaliye()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Server=DESKTOP-SUDHIVL\SQLEXPRESS;Initial Catalog=MuhasebeUygulamasi;Integrated Security=True");
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand komut;

        void griddoldur()
        {
            da = new SqlDataAdapter("Select *From İrsaliye_Ekle", baglan);
            ds = new DataSet();
            baglan.Open();
            da.Fill(ds, "İrsaliye_Ekle");
            dataGridView1.DataSource = ds.Tables["İrsaliye_Ekle"];
            baglan.Close();
        }
        DataTable yenile()
        {
            baglan.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select id as ID , tarih as Tarih , saat as Saat , irsaliyeNo as İrsaliyeNo , islemTuru as İşlemTürü , unvan as Unvan , tutar as Tutar , durum as Durum from İrsaliye_Ekle", baglan);
            DataTable tablo = new DataTable();
            adtr.Fill(tablo);
            baglan.Close();
            return tablo;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            İrsaliye_Ekle irs = new İrsaliye_Ekle();
            irs.ShowDialog();
            griddoldur();
        }

        private void İrsaliye_Load(object sender, EventArgs e)
        {
            griddoldur();
            int kayitsayisi;
            kayitsayisi = dataGridView1.RowCount;
            label11.Text = kayitsayisi.ToString();
        }
        void KayitSil(int id)
        {
            string sql = "Delete from İrsaliye_Ekle where id=@id";
            komut = new SqlCommand(sql, baglan);
            komut.Parameters.AddWithValue("@id", id);
            baglan.Open();
            komut.ExecuteNonQuery();
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
            yazdirma =printDialog1.ShowDialog();
            if(yazdirma==DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            İrsaliye_Güncelle irs = new İrsaliye_Güncelle();
            irs.ShowDialog();
            griddoldur();
        }

        private void radioİrsaliye_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM İrsaliye_Ekle";
            komut.Connection = baglan;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglan.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["irsaliyeNo"]);
            }
            baglan.Close();
            /*  if (radioİrsaliye.Checked == true)
              {
                  SqlCommand komut = new SqlCommand();
                  komut.CommandText = "SELECT *FROM Fatura_Ekle";
                  komut.Connection = baglan;
                  komut.CommandType = CommandType.Text;

                  SqlDataReader dr;
                  baglan.Open();
                  dr = komut.ExecuteReader();
                  while (dr.Read())
                  {
                      comboBox1.Items.Add(dr["irsaliyeNo"]);
                  }
                  baglan.Close();
              }*/
        }

        private void radioUnvan_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Mal Alış");
            comboBox1.Items.Add("Mal Satış");
            comboBox1.Items.Add("Toptan Alış");
            comboBox1.Items.Add("Toptan Satış");
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (radioİrsaliye.Checked == true)
            {
                baglan.Open();
                SqlCommand cmd = new SqlCommand("select * from İrsaliye_Ekle where irsaliyeNo like '%" + comboBox1.Text + "%'", baglan);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglan.Close();
            }
            else if(radioDurum.Checked==true)
            {
                baglan.Open();
                SqlCommand cmd = new SqlCommand("select * from İrsaliye_Ekle where durum like '%" + comboBox1.Text + "%'", baglan);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglan.Close();
            }
            else if(radioTutar.Checked==true)
            {
                baglan.Open();
                SqlCommand cmd = new SqlCommand("select * from İrsaliye_Ekle where tutar like '%" + comboBox1.Text + "%'", baglan);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglan.Close();
            }
            else if(radioUnvan.Checked==true)
            {
                baglan.Open();
                SqlCommand cmd = new SqlCommand("select * from İrsaliye_Ekle where unvan like '%" + comboBox1.Text + "%'", baglan);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglan.Close();
            }
            else
            {
                baglan.Open();
                SqlCommand cmd = new SqlCommand("select * from İrsaliye_Ekle where islemTuru like '%" + comboBox1.Text + "%'", baglan);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglan.Close();
            }
        }

        private void radioİslemTuru_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Ada Triko");
            comboBox1.Items.Add("Flaş Tekstil");
            comboBox1.Items.Add("Nehir Grup");
            comboBox1.Items.Add("Mango");
            comboBox1.Items.Add("Zara");
            comboBox1.Items.Add("LCWaikiki");
            comboBox1.Items.Add("Güleks");
            comboBox1.Items.Add("Triko Tek");
            comboBox1.Items.Add("Ugur Balkuv");
        }

        private void radioTutar_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("20.000");
            comboBox1.Items.Add("25.000");
            comboBox1.Items.Add("50.000");
            comboBox1.Items.Add("100.000");
            comboBox1.Items.Add("190.000");
            comboBox1.Items.Add("300.000");
            comboBox1.Items.Add("500.000");
            comboBox1.Items.Add("250.000");
            comboBox1.Items.Add("130.000");
        }

        private void radioDurum_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Aktif");
            comboBox1.Items.Add("Bekliyor");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            İrsaliyeAktar irsaliyeAktar = new İrsaliyeAktar();
            irsaliyeAktar.a = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            irsaliyeAktar.b = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            irsaliyeAktar.c = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            irsaliyeAktar.d = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            irsaliyeAktar.f = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            irsaliyeAktar.g = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            irsaliyeAktar.h = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            irsaliyeAktar.k = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            irsaliyeAktar.Show();
        }
    }
}
