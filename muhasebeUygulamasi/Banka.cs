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
    public partial class Banka : Form
    {
        public Banka()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Server=DESKTOP-SUDHIVL\SQLEXPRESS;Initial Catalog=MuhasebeUygulamasi;Integrated Security=True");
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand cmd;
        void Listele()
        {
            da = new SqlDataAdapter("select * from Banka_İslemleri", baglan);
            ds = new DataSet();
            baglan.Open();
            da.Fill(ds, "Banka_İslemleri");
            dataGridView1.DataSource = ds.Tables["Banka_İslemleri"];
            baglan.Close();
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
            Banka_Ekle banka = new Banka_Ekle();
            banka.ShowDialog();
            Listele();
        }

        private void Banka_Load(object sender, EventArgs e)
        {
            Listele();
            int kayitsayisi;
            kayitsayisi = dataGridView1.RowCount;
            label11.Text = kayitsayisi.ToString();
        }
        void KayitSil(int id)
        {
            string sql = "Delete from Banka_İslemleri where id=@id";
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
            }
            MessageBox.Show("Kayıt silindi.");
            Listele();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Banka_Guncelle bankaa = new Banka_Guncelle();
            bankaa.ShowDialog();
            Listele();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioBankaKod_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM Banka_İslemleri";
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

        private void radioBAnkaAdi_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("T.C. Ziraat Bankası");
            comboBox1.Items.Add("ING Bank");
            comboBox1.Items.Add("Halk Bankası");
            comboBox1.Items.Add("Garanti Bankası");
        }

        private void radioHesapAdi_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM Banka_İslemleri";
            komut.Connection = baglan;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglan.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["hesapAdi"]);
            }
            baglan.Close();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if(radioBankaKod.Checked==true)
            {
                baglan.Open();
                SqlCommand cmd = new SqlCommand("select * from Banka_İslemleri where kod like '%" + comboBox1.Text + "%'", baglan);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglan.Close();
            }
            else if(radioBAnkaAdi.Checked==true)
            {
                baglan.Open();
                SqlCommand cmd = new SqlCommand("select * from Banka_İslemleri where bankaAdi like '%" + comboBox1.Text + "%'", baglan);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglan.Close();
            }
            else
            {
                baglan.Open();
                SqlCommand cmd = new SqlCommand("select * from Banka_İslemleri where hesapAdi like '%" + comboBox1.Text + "%'", baglan);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglan.Close();
            }
        }

        private void btnBankaAc_Click(object sender, EventArgs e)
        {
            Banka_Hareketleri bnk = new Banka_Hareketleri();
            bnk.a = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            bnk.b = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            bnk.c = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            bnk.d = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            bnk.f = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            bnk.g = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            bnk.h = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            bnk.Show();
        }
    }
}
