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
    public partial class Teklif_İşlemleri : Form
    {
        public Teklif_İşlemleri()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Server=DESKTOP-SUDHIVL\SQLEXPRESS;Initial Catalog=MuhasebeUygulamasi;Integrated Security=True");
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand cmd;
        void Listele()
        {
            da = new SqlDataAdapter("select * from Teklif_İslemleri", baglan);
            ds = new DataSet();
            baglan.Open();
            da.Fill(ds, "Teklif_İslemleri");
            dataGridView1.DataSource = ds.Tables["Teklif_İslemleri"];
            baglan.Close();
        }
        private void Teklif_İşlemleri_Load(object sender, EventArgs e)
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
            if(yazdirma==DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Teklif_Ekle tek = new Teklif_Ekle();
            tek.ShowDialog();
            Listele();
        }
        void KayitSil(int id)
        {
            string sql = "Delete from Teklif_İslemleri where id=@id";
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
                MessageBox.Show("Kayıt silindi.");
            }
            Listele();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Teklif_Guncelle tek = new Teklif_Guncelle();
            tek.ShowDialog();
            Listele();
        }

        private void radioTeklif_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM Teklif_İslemleri";
            komut.Connection = baglan;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglan.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["teklifNo"]);
            }
            baglan.Close();
        }

        private void radioUnvan_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Yönetim");
            comboBox1.Items.Add("Muhasebe");
        }

        private void radioİslemTuru_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Acik");
            comboBox1.Items.Add("Kapalı");
        }

        private void radioTutar_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("25.000");
            comboBox1.Items.Add("50.000");
            comboBox1.Items.Add("100.000");
        }

        private void radioDurum_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Aktif");
            comboBox1.Items.Add("Bekliyor");
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if(radioTeklif.Checked == true)
            {
                baglan.Open();
                SqlCommand cmd = new SqlCommand("select * from Teklif_İslemleri where teklifNo like '%" + comboBox1.Text + "%'", baglan);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglan.Close();
            }
            else if(radioİslemTuru.Checked == true)
            {
                baglan.Open();
                SqlCommand cmd = new SqlCommand("select * from Teklif_İslemleri where islemTuru like '%" + comboBox1.Text + "%'", baglan);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglan.Close();
            }
            else if(radioUnvan.Checked == true)
            {
                baglan.Open();
                SqlCommand cmd = new SqlCommand("select * from Teklif_İslemleri where unvan like '%" + comboBox1.Text + "%'", baglan);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglan.Close();
            }
            else if(radioTutar.Checked == true)
            {
                baglan.Open();
                SqlCommand cmd = new SqlCommand("select * from Teklif_İslemleri where tutar like '%" + comboBox1.Text + "%'", baglan);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglan.Close();
            }
            else
            {
                baglan.Open();
                SqlCommand cmd = new SqlCommand("select * from Teklif_İslemleri where durum like '%" + comboBox1.Text + "%'", baglan);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglan.Close();
            }
        }
    }
}
