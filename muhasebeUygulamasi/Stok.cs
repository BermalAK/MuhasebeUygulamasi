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
    public partial class Stok : Form
    {
        public Stok()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Server=DESKTOP-SUDHIVL\SQLEXPRESS;Initial Catalog=MuhasebeUygulamasi;Integrated Security=True");
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand cmd;
        private void button6_Click(object sender, EventArgs e)
        {
            Stok_Ekle stok = new Stok_Ekle();
            stok.ShowDialog();
            Listele();
        }
        void Listele()
        {
            da = new SqlDataAdapter("select * from Stok_Ekle",baglan);
            ds = new DataSet();
            baglan.Open();
            da.Fill(ds, "Stok_Ekle");
            dataGridView1.DataSource = ds.Tables["Stok_Ekle"];
            baglan.Close();
        }
        /*DataTable yenile()
        {
            baglan.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select id as ID , kod as Kod , stokAdi as StokAdi , grup as Grup , kdv as KDV , birim as Birim , giren as Giren , cikan as Cikan , kalan as Kalan from Stok_Ekle", baglan);
            DataTable tablo = new DataTable();
            adtr.Fill(tablo);
            baglan.Close();
            return tablo;
        }*/
        private void Stok_Load(object sender, EventArgs e)
        {
            Listele();
            int kayitSayisi;
            kayitSayisi = dataGridView1.RowCount;
            label11.Text = kayitSayisi.ToString();
        }
        void KayitSil(int id)
        {
            string sql = "Delete from Stok_Ekle where id=@id";
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
            MessageBox.Show("Kayıt silindi.");
            Listele();

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

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Stok_Güncelleme stk = new Stok_Güncelleme();
            stk.ShowDialog();
            Listele();
        }

        private void radioStokKod_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM Stok_Ekle";
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

        private void radioStokAdi_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM Stok_Ekle";
            komut.Connection = baglan;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglan.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["stokAdi"]);
            }
            baglan.Close();
        }

        private void radioGrup_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Ütü Malzemesi");
            comboBox1.Items.Add("Kontrol Malzemesi");
            comboBox1.Items.Add("Paket Malzemesi");
        }

        private void radioKdv_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("%0.1");
            comboBox1.Items.Add("%0.2");
            comboBox1.Items.Add("%0.3");
            comboBox1.Items.Add("%0.4");
            comboBox1.Items.Add("%0.5");
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if(radioStokKod.Checked==true)
            {
                baglan.Open();
                SqlCommand cmd = new SqlCommand("select * from Stok_Ekle where kod like '%" + comboBox1.Text + "%'", baglan);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglan.Close();
            }
            else if(radioStokAdi.Checked==true)
            {
                baglan.Open();
                SqlCommand cmd = new SqlCommand("select * from Stok_Ekle where stokAdi like '%" + comboBox1.Text + "%'", baglan);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglan.Close();
            }
            else if(radioKdv.Checked==true)
            {
                baglan.Open();
                SqlCommand cmd = new SqlCommand("select * from Stok_Ekle where kdv like '%" + comboBox1.Text + "%'", baglan);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglan.Close();
            }
            else
            {
                baglan.Open();
                SqlCommand cmd = new SqlCommand("select * from Stok_Ekle where grup like '%" + comboBox1.Text + "%'", baglan);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglan.Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Stok_Hareketleri stk = new Stok_Hareketleri();
            stk.a0 = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            stk.a1 = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            stk.a2 = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            stk.a3 = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            stk.a4 = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            stk.a5 = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            stk.a6 = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            stk.a7 = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            stk.a8 = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            stk.Show();
        }
    }
}
