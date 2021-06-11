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
    public partial class Kasa : Form
    {
        public Kasa()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Server=DESKTOP-SUDHIVL\SQLEXPRESS;Initial Catalog=MuhasebeUygulamasi;Integrated Security=True");
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand komut;

        void listele()
        {
            da = new SqlDataAdapter("Select *From Kasa_İslemleri", baglan);
            ds = new DataSet();
            baglan.Open();
            da.Fill(ds, "Kasa_İslemleri");
            dataGridView1.DataSource = ds.Tables["Kasa_İslemleri"];
            baglan.Close();
        }
        private void Kasa_Load(object sender, EventArgs e)
        {
            listele();
            int kayitsayisi;
            kayitsayisi = dataGridView1.RowCount;
            label11.Text = kayitsayisi.ToString();
        }
        void KayitSil(int id)
        {
            string sql = "Delete from Kasa_İslemleri where id=@id";
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
            }
            MessageBox.Show("Kayıt silindi.");
            listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult yazdirma;
            yazdirma = printDialog1.ShowDialog();
            if (yazdirma == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kasa_Ekle kasa = new Kasa_Ekle();
            kasa.ShowDialog();
            listele();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Kasa_Guncelle kasaa = new Kasa_Guncelle();
            kasaa.ShowDialog();
            listele();
        }

        private void radioKasaKod_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM Kasa_İslemleri";
            komut.Connection = baglan;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglan.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["kod"]);
            }
            baglan.Close();
        }

        private void radioKasaAdi_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Banka Kasası :)");
            comboBox1.Items.Add("İşyeri Kasası");
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if(radioKasaKod.Checked==true)
            {
                baglan.Open();
                SqlCommand cmd = new SqlCommand("select * from Kasa_İslemleri where kod like '%" + comboBox1.Text + "%'", baglan);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglan.Close();
            }
            else
            {
                baglan.Open();
                SqlCommand cmd = new SqlCommand("select * from Kasa_İslemleri where kasaAdi like '%" + comboBox1.Text + "%'", baglan);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglan.Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Kasa_Hareketleri kasa = new Kasa_Hareketleri();
            kasa.a = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            kasa.b = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            kasa.c = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            kasa.d = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            kasa.f = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            kasa.g = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            kasa.Show();
        }
    }
}
