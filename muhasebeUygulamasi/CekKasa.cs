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
    public partial class CekKasa : Form
    {
        public CekKasa()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Server=DESKTOP-SUDHIVL\SQLEXPRESS;Initial Catalog=MuhasebeUygulamasi;Integrated Security=True");

        private void btnKasadanTahsilat_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO CekSenetKasadann (tarih,portfoyNo,kasa,aciklama,islemTutari,islemNo) VALUES " +
                                    "(@tarih,@portfoyNo,@kasa,@aciklama,@islemTutari,@islemNo)", baglan);

            /*SqlParameter imageParameter = new SqlParameter("@resim", SqlDbType.Image);
            imageParameter.Value = DBNull.Value;
            cmd.Parameters.Add(imageParameter);*/

            cmd.Parameters.AddWithValue("@tarih", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@portfoyNo", txtPortfoyNo.Text);
            cmd.Parameters.AddWithValue("@kasa", txtKasa.Text);
            cmd.Parameters.AddWithValue("@aciklama", txtAciklama.Text);
            cmd.Parameters.AddWithValue("@islemTutari", txtİslemTutari.Text);
            cmd.Parameters.AddWithValue("@islemNo", comboBox1.Text);

            baglan.Open();
            cmd.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Kasadan Tahsilat Başarılı");
        }

        private void CekKasa_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader oku;
            comboBox1.Items.Clear();
            baglan.Open();
            cmd.Connection = baglan;
            cmd.CommandText = "select irsaliyeNo from İrsaliye_Ekle";
            oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                comboBox1.Items.Add(oku[0]);
            }
            baglan.Close();
        }
    }
}
