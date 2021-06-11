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
    public partial class Firma_Hesapları : Form
    {
        public Firma_Hesapları()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Server=DESKTOP-SUDHIVL\SQLEXPRESS;Initial Catalog=MuhasebeUygulamasi;Integrated Security=True");
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand cmd;

        void KayitSil(int id)
        {
            string sql = "Delete from Firma_Hesaplari where id=@id";
            cmd = new SqlCommand(sql, baglan);
            cmd.Parameters.AddWithValue("@id", id);
            baglan.Open();
            cmd.ExecuteNonQuery();
            baglan.Close();
        }
        void Listele()
        {
            da = new SqlDataAdapter("select * from Firma_Hesaplari", baglan);
            ds = new DataSet();
            baglan.Open();
            da.Fill(ds, "Firma_Hesaplari");
            dataGridView1.DataSource = ds.Tables["Firma_Hesaplari"];
            baglan.Close();
        }
        private void Firma_Hesapları_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Firma_Ekle frm = new Firma_Ekle();
            frm.ShowDialog();
            Listele();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                KayitSil(id);
                MessageBox.Show("Kayıt Silindi.");
            }
            Listele();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Firma_Guncelle frm1 = new Firma_Guncelle();
            frm1.ShowDialog();
            Listele();
        }

        private void btnVarsayilan_Click(object sender, EventArgs e)
        {

        }
    }
}
