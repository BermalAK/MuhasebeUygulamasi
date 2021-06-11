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
    public partial class Çek : Form
    {
        public Çek()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Server=DESKTOP-SUDHIVL\SQLEXPRESS;Initial Catalog=MuhasebeUygulamasi;Integrated Security=True");
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand cmd;
        void Listele()
        {
            da = new SqlDataAdapter("select * from Cek_Senet", baglan);
            ds = new DataSet();
            baglan.Open();
            da.Fill(ds, "Cek_Senet");
            dataGridView1.DataSource = ds.Tables["Cek_Senet"];
            baglan.Close();
        }
        private void Çek_Load(object sender, EventArgs e)
        {
            Listele();
            int kayitsayisi;
            kayitsayisi = dataGridView1.RowCount;
            label11.Text = kayitsayisi.ToString();
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            DialogResult yazdirma;
            yazdirma = printDialog1.ShowDialog();
            if (yazdirma == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Cek_Ekle cek = new Cek_Ekle();
            cek.ShowDialog();
            Listele();
        }
        void KayitSil(int id)
        {
            string sql = "Delete from Cek_Senet where id=@id";
            cmd = new SqlCommand(sql, baglan);
            cmd.Parameters.AddWithValue("@id", id);
            baglan.Open();
            cmd.ExecuteNonQuery();
            baglan.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                KayitSil(id);
            }
            Listele();
            MessageBox.Show("Kayıt silinmiştir.");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Cek_Guncelle cekk = new Cek_Guncelle();
            cekk.ShowDialog();
            Listele();
        }

        private void radioPortfoy_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM Cek_Senet";
            komut.Connection = baglan;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglan.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["portfoyNo"]);
            }
            baglan.Close();
        }

        private void radioUnvan_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Yönetim");
            comboBox1.Items.Add("Muhasebe");
            comboBox1.Items.Add("Çalışan");
        }

        private void radioVade_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand();
            komut1.CommandText = "SELECT *FROM Cek_Senet";
            komut1.Connection = baglan;
            komut1.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglan.Open();
            dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["vade"]);
            }
            baglan.Close();
        }

        private void radioİslemTuru_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Açık");
            comboBox1.Items.Add("Bilinmiyor");
        }

        private void radioDurum_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Bekliyor.");
            comboBox1.Items.Add("İşlem yapıldı.");
            comboBox1.Items.Add("Aktif");
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if(radioPortfoy.Checked==true)
            {
                baglan.Open();
                SqlCommand cmd = new SqlCommand("select * from Cek_Senet where portfoyNo like '%" + comboBox1.Text + "%'", baglan);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglan.Close();
            }
            else if(radioDurum.Checked==true)
            {
                baglan.Open();
                SqlCommand cmd = new SqlCommand("select * from Cek_Senet where durum like '%" + comboBox1.Text + "%'", baglan);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglan.Close();
            }
            else if(radioUnvan.Checked==true)
            {
                baglan.Open();
                SqlCommand cmd = new SqlCommand("select * from Cek_Senet where unvan like '%" + comboBox1.Text + "%'", baglan);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglan.Close();
            }
            else if(radioVade.Checked==true)
            {
                baglan.Open();
                SqlCommand cmd = new SqlCommand("select * from Cek_Senet where vade like '%" + comboBox1.Text + "%'", baglan);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglan.Close();
            }
            else
            {
                baglan.Open();
                SqlCommand cmd = new SqlCommand("select * from Cek_Senet where islemTuru like '%" + comboBox1.Text + "%'", baglan);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglan.Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CekSenetİslemler cekSenetİslemler = new CekSenetİslemler();
            cekSenetİslemler.ShowDialog();
        }
    }
}
