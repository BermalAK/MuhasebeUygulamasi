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
    public partial class İrsaliyebarcode : Form
    {
        public İrsaliyebarcode()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Server=DESKTOP-SUDHIVL\SQLEXPRESS;Initial Catalog=MuhasebeUygulamasi;Integrated Security=True");

        private void İrsaliyebarcode_Load(object sender, EventArgs e)
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

        private void btnBarcode_Click(object sender, EventArgs e)
        {
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            pictureBox1.Image = barcode.Draw(comboBox1.Text, 50);
        }

        private void btnQrcode_Click(object sender, EventArgs e)
        {
            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pictureBox2.Image = qrcode.Draw(comboBox1.Text, 50);
        }
    }
}
