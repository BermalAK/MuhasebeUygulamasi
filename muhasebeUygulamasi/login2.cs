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
    public partial class login2 : Form
    {
        public login2()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Server=DESKTOP-SUDHIVL\SQLEXPRESS;Initial Catalog=MuhasebeUygulamasi;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader read;
        public void hatırlama()
        {
            if (BeniHatirla.Checked)
            {
                Properties.Settings.Default["kuladi"] = txtKullanici.Text;
                Properties.Settings.Default["sifre"] = txtPassword.Text;
            }
            else
            {
                Properties.Settings.Default["kuladi"] = "";
                Properties.Settings.Default["sifre"] = "";
            }
            Properties.Settings.Default.Save();

        }
        private void login2_Load(object sender, EventArgs e)
        {
            txtKullanici.Text = Properties.Settings.Default["kuladi"].ToString();
            txtPassword.Text = Properties.Settings.Default["sifre"].ToString();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            hatırlama();
            string user = txtKullanici.Text;
            string pass = txtPassword.Text;
            //con = new SqlConnection("server=DESKTOP-JU1LJ2M\\SQLEXPRESS; Initial Catalog=dbLogin;Integrated Security=SSPI");
            cmd = new SqlCommand();
            baglan.Open();
            cmd.Connection = baglan;
            cmd.CommandText = "SELECT * FROM KullaniciGirisi where kuladi='" + txtKullanici.Text + "' AND sifre='" + txtPassword.Text + "'";
            read = cmd.ExecuteReader();
            if (read.Read())
            {
                MessageBox.Show("Giris başarılı.");
                Form1 ans = new Form1();
                ans.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
                txtPassword.Clear();
                txtKullanici.Clear();
            }
            baglan.Close();
        }
    }
}
