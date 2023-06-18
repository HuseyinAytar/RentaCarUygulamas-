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
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace RentaCarUygulaması
{
    public partial class KullanıcıGiris : Form
    {
        string connectionString = "Server=localhost;Database=rentacar;Uid=root;Pwd=admin;";
        public KullanıcıGiris()
        {
            InitializeComponent();
        }

        private void Girisyap_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = kullaniciadi.Text;
            string sifre1 = sifre.Text;

            if (AuthenticateUser(kullaniciAdi, sifre1))
            {
                MessageBox.Show("Giriş başarılı!");
                AnaMenu ANAMENU = new AnaMenu();
                ANAMENU.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
            }

        }
        private bool AuthenticateUser(string kullaniciAdi, string sifre)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string sqlQuery = "SELECT COUNT(*) FROM admingiris WHERE BINARY kullanici_adı = @kullanici_adı AND Sifre = @sifre";
                MySqlCommand command = new MySqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@kullanici_adı", kullaniciAdi);
                command.Parameters.AddWithValue("@sifre", sifre);
                try
                {
                    connection.Open();
                    int kullaniciSayisi = Convert.ToInt32(command.ExecuteScalar());
                    return (kullaniciSayisi > 0);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bağlantı hatası: " + ex.Message);
                    return false;
                }
            }
        }

        private void KullanıcıGiris_Load(object sender, EventArgs e)
        {
            
            sifre.PasswordChar = '*';
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                //karakteri göster.
                sifre.PasswordChar = '\0';
            }
            //değilse karakterlerin yerine * koy.
            else
            {
                sifre.PasswordChar = '*';
            }
        }
    }
}
