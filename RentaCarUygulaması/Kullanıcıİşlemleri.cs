using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RentaCarUygulaması
{
    public partial class Kullanıcıİşlemleri : Form
    {
        string connectionString = "Server=localhost;Database=rentacar;Uid=root;Pwd=admin;";
        public Kullanıcıİşlemleri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string username = kullaniciadi.Text;
            string password = sifre.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifre girin.");
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Kullanıcıyı kontrol et
                    MySqlCommand checkUserCommand = new MySqlCommand("SELECT COUNT(*) FROM admingiris WHERE kullanici_adı = @username", connection);
                    checkUserCommand.Parameters.AddWithValue("@username", username);
                    int userCount = Convert.ToInt32(checkUserCommand.ExecuteScalar());

                    if (userCount > 0)
                    {
                        // Kullanıcı zaten var, hata mesajını göster
                        MessageBox.Show("Hata: Bu kullanıcı adı zaten kayıtlı!");
                    }
                    else
                    {
                        // Kullanıcıyı kaydet
                        MySqlCommand insertUserCommand = new MySqlCommand("INSERT INTO admingiris (kullanici_adı, sifre) VALUES (@username, @password)", connection);
                        insertUserCommand.Parameters.AddWithValue("@username", username);
                        insertUserCommand.Parameters.AddWithValue("@password", password);
                        insertUserCommand.ExecuteNonQuery();
                        LoadUserData();
                        MessageBox.Show("Kullanıcı başarıyla kaydedildi.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = kullaniciadi.Text;
            string password = sifre.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Lütfen kullanıcı adı ve yeni şifre girin.");
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Kullanıcıyı kontrol et
                    MySqlCommand checkUserCommand = new MySqlCommand("SELECT COUNT(*) FROM admingiris WHERE kullanici_adı = @username", connection);
                    checkUserCommand.Parameters.AddWithValue("@username", username);
                    int userCount = Convert.ToInt32(checkUserCommand.ExecuteScalar());

                    if (userCount == 0)
                    {
                        // Kullanıcı bulunamadı, hata mesajını göster
                        MessageBox.Show("Hata: Bu kullanıcı adı kayıtlı değil!");
                    }
                    else
                    {
                        // Şifreyi güncelle
                        MySqlCommand updatePasswordCommand = new MySqlCommand("UPDATE admingiris SET sifre = @password WHERE kullanici_adı = @username", connection);
                        updatePasswordCommand.Parameters.AddWithValue("@password", password);
                        updatePasswordCommand.Parameters.AddWithValue("@username", username);
                        updatePasswordCommand.ExecuteNonQuery();
                        LoadUserData();
                        MessageBox.Show("Şifre başarıyla güncellendi.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Seçilen kullanıcının verisini sil
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                string username = dataGridView1.Rows[selectedIndex].Cells["kullanici_adı"].Value.ToString();

                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        // Kullanıcıyı sil
                        MySqlCommand deleteUserCommand = new MySqlCommand("DELETE FROM admingiris WHERE kullanici_adı = @username", connection);
                        deleteUserCommand.Parameters.AddWithValue("@username", username);
                        deleteUserCommand.ExecuteNonQuery();

                        MessageBox.Show("Kullanıcı başarıyla silindi.");

                        // DataGridView'i güncelle
                        LoadUserData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz bir kullanıcı seçin.");
            }

        }
        private void LoadUserData()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Kullanıcıları veritabanından al
                    MySqlCommand selectUsersCommand = new MySqlCommand("SELECT * FROM admingiris", connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(selectUsersCommand);
                    System.Data.DataTable dataTable = new System.Data.DataTable();
                    adapter.Fill(dataTable);

                    // DataGridView'e verileri ata
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void Kullanıcıİşlemleri_Load(object sender, EventArgs e)
        {
            LoadUserData();
        }
    }
      
    
}
