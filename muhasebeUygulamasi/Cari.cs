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
    public partial class Cari : Form
    {
        public Cari()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection(@"Server=DESKTOP-SUDHIVL\SQLEXPRESS;Initial Catalog=MuhasebeUygulamasi;Integrated Security=True");
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand cmd;
        void button6_Click(object sender, EventArgs e)
        {
            Cari_Ekle cari = new Cari_Ekle();
            cari.ShowDialog();
            Listele();
        }
        void KayitSil(int id)
        {
            string sql = "Delete from Cari_Ekle where id=@id";
            cmd =new SqlCommand(sql, baglan);
            cmd.Parameters.AddWithValue("@id",id);
            baglan.Open();
            cmd.ExecuteNonQuery();
            baglan.Close();
        }
        void Listele()
        {
            da = new SqlDataAdapter("select * from Cari_Ekle", baglan);
            ds = new DataSet();
            baglan.Open();
            da.Fill(ds, "Cari_Ekle");
            dataGridView1.DataSource = ds.Tables["Cari_Ekle"];
            baglan.Close();
        }
        private void Cari_Load(object sender, EventArgs e)
        {
            Listele();
            int kayitsayisi;
            kayitsayisi = dataGridView1.RowCount;
            label11.Text = kayitsayisi.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                KayitSil(id);
                
            }
            Listele();
            MessageBox.Show("Kayıt silinmiştir.");
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

        private void button7_Click(object sender, EventArgs e)
        {
            Cari_Guncelle cr = new Cari_Guncelle();
            cr.ShowDialog();
            Listele();
        }

        private void radioKod_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM Cari_Ekle";
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

        private void radioUnvan_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Yönetici");
            comboBox1.Items.Add("Muhasebeci");
            comboBox1.Items.Add("Yönetim");
            comboBox1.Items.Add("Muhasebe");
        }

        private void radioGrup_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Malzemeler");
            comboBox1.Items.Add("Muhasebe");
            comboBox1.Items.Add("Paket Malzemesi");
            comboBox1.Items.Add("Ütüler");
            comboBox1.Items.Add("İşkur Çalışanalrı");
            comboBox1.Items.Add("Denetleme İşlemleri");
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if(radioKod.Checked == true)
            {
                baglan.Open();
                SqlCommand cmd = new SqlCommand("select * from Cari_Ekle where kod like '%" + comboBox1.Text + "%'", baglan);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglan.Close();
            }
            else if(radioUnvan.Checked == true)
            {
                baglan.Open();
                SqlCommand cmd = new SqlCommand("select * from Cari_Ekle where unvan like '%" + comboBox1.Text + "%'", baglan);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglan.Close();
            }
            else
            {
                baglan.Open();
                SqlCommand cmd = new SqlCommand("select * from Cari_Ekle where grup like '%" + comboBox1.Text + "%'", baglan);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                baglan.Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CariHareketler cari = new CariHareketler();
            cari.a = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cari.b = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cari.c = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cari.d = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cari.f = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            cari.g = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            cari.h = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            cari.Show();
        }
    }
}
