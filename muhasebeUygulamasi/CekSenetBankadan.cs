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
    public partial class CekSenetBankadan : Form
    {
        public CekSenetBankadan()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Server=DESKTOP-SUDHIVL\SQLEXPRESS;Initial Catalog=MuhasebeUygulamasi;Integrated Security=True");

        private void CekSenetBankadan_Load(object sender, EventArgs e)
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

        private void btnBankadanTahsilat_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO CekSenetBankadan (tarih,portfoyNo,banka,aciklama,islemTutari,islemNo) VALUES " +
                                   "(@tarih,@portfoyNo,@banka,@aciklama,@islemTutari,@islemNo)", baglan);

            /*SqlParameter imageParameter = new SqlParameter("@resim", SqlDbType.Image);
            imageParameter.Value = DBNull.Value;
            cmd.Parameters.Add(imageParameter);*/

            cmd.Parameters.AddWithValue("@tarih", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@portfoyNo", txtPortfoyNo.Text);
            cmd.Parameters.AddWithValue("@banka", txtBanka.Text);
            cmd.Parameters.AddWithValue("@aciklama", txtAciklama.Text);
            cmd.Parameters.AddWithValue("@islemTutari", txtİslemTutari.Text);
            cmd.Parameters.AddWithValue("@islemNo", comboBox1.Text);

            baglan.Open();
            cmd.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Bankadan Tahsilat Başarılı");
        }
    }
}
