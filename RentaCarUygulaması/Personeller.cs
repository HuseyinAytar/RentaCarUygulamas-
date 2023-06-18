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
    public partial class Personeller : Form
    {
        string connectionString = "Server=localhost;Database=rentacar;Uid=root;Pwd=admin;";
        public Personeller()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string telefon = txtTelefon.Text;
            string email = txtEmail.Text;
            string adres = txtAdres.Text;
            string tc = txtTC.Text;
            string maas = txtMaas.Text;

            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                string query = "INSERT INTO personeller (ad, soyad, telefon, email, adres, personelTC , maas) VALUES (@ad, @soyad, @telefon, @email, @adres, @tc , @maas)";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@ad", ad);
                command.Parameters.AddWithValue("@soyad", soyad);
                command.Parameters.AddWithValue("@telefon", telefon);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@adres", adres);
                command.Parameters.AddWithValue("@tc", tc);
                command.Parameters.AddWithValue("@maas", maas);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Personel başarıyla eklendi.");

                    txtAd.Clear();
                    txtSoyad.Clear();
                    txtTelefon.Clear();
                    txtEmail.Clear();
                    txtAdres.Clear();
                    txtTC.Clear();
                    txtMaas.Clear();


                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                }
                else
                {
                    MessageBox.Show("Ekleme işlemi başarısız oldu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void Personeller_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM personeller";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
            adapter.Dispose();
            command.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                string TC = txtTC.Text;
                string yeniad = txtAd.Text;
                string yenisoyad = txtSoyad.Text;
                string yenitelefon = txtTelefon.Text;
                string yeniemail = txtEmail.Text;
                string yeniadres = txtAdres.Text;
                string yenimaas = txtMaas.Text;


                string query = "UPDATE personeller SET ";
                bool isFirstCondition = true;

                if (!string.IsNullOrEmpty(yeniad))
                {
                    query += "ad = @yeniad";
                    isFirstCondition = false;
                }

                if (!string.IsNullOrEmpty(yenisoyad))
                {
                    if (!isFirstCondition)
                        query += ", ";

                    query += "soyad = @yenisoyad";
                    isFirstCondition = false;
                }

                if (!string.IsNullOrEmpty(yenitelefon))
                {
                    if (!isFirstCondition)
                        query += ", ";

                    query += "telefon = @yenitelefon";
                    isFirstCondition = false;
                }

                if (!string.IsNullOrEmpty(yeniemail))
                {
                    if (!isFirstCondition)
                        query += ", ";

                    query += "email = @yeniemail";
                    isFirstCondition = false;
                }

                if (!string.IsNullOrEmpty(yeniadres))
                {
                    if (!isFirstCondition)
                        query += ", ";

                    query += "adres = @yeniadres";
                    isFirstCondition = false;
                }
                if (!string.IsNullOrEmpty(yenimaas))
                {
                    if (!isFirstCondition)
                        query += ", ";

                    query += "maas = @yenimaas";
                    isFirstCondition = false;
                }



                query += " WHERE personelTC = @TC";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@yeniad", yeniad);
                command.Parameters.AddWithValue("@yenisoyad", yenisoyad);
                command.Parameters.AddWithValue("@yenitelefon", yenitelefon);
                command.Parameters.AddWithValue("@yeniemail", yeniemail);
                command.Parameters.AddWithValue("@yeniadres", yeniadres);
                command.Parameters.AddWithValue("@yenimaas", yenimaas);
                command.Parameters.AddWithValue("@TC", TC);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Personel bilgisi başarıyla güncellendi.");

                    string selectQuery = "SELECT * FROM personeller";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Güncelleme işlemi başarısız oldu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection connection;
            MySqlCommand command;
            connection = new MySqlConnection(connectionString);
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Seçili satırı silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {

                        int selectedIndex = dataGridView1.SelectedRows[0].Index;
                        int customerID = Convert.ToInt32(dataGridView1.Rows[selectedIndex].Cells["personelTC"].Value);


                        connection.Open();

                        string query = "DELETE FROM personeller WHERE personelTC = @customerID";
                        command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@customerID", customerID);
                        command.ExecuteNonQuery();

                        MessageBox.Show("Seçili satır başarıyla silindi.");

                        string selectQuery = "SELECT * FROM personeller";
                        MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Veritabanında bir hata oluştu: " + ex.Message);
                    }
                    finally
                    {
                        if (connection != null)
                        {
                            connection.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçin.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string telefon = txtTelefon.Text;
            string email = txtEmail.Text;
            string adres = txtAdres.Text;
            string tc = txtTC.Text;
            string maas = txtMaas.Text;


            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                string query = "SELECT * FROM personeller WHERE";

                List<string> filters = new List<string>();
                List<MySqlParameter> parameters = new List<MySqlParameter>();

                if (!string.IsNullOrWhiteSpace(ad))
                {
                    filters.Add("ad = @ad");
                    parameters.Add(new MySqlParameter("@ad", ad));
                }

                if (!string.IsNullOrWhiteSpace(soyad))
                {
                    filters.Add("soyad = @soyad");
                    parameters.Add(new MySqlParameter("@soyad", soyad));
                }

                if (!string.IsNullOrWhiteSpace(telefon))
                {
                    filters.Add("telefon = @telefon");
                    parameters.Add(new MySqlParameter("@telefon", telefon));
                }

                if (!string.IsNullOrWhiteSpace(email))
                {
                    filters.Add("email = @email");
                    parameters.Add(new MySqlParameter("@email", email));
                }

                if (!string.IsNullOrWhiteSpace(adres))
                {
                    filters.Add("adres = @adres");
                    parameters.Add(new MySqlParameter("@adres", adres));
                }
                if (!string.IsNullOrWhiteSpace(maas))
                {
                    filters.Add("maas = @maas");
                    parameters.Add(new MySqlParameter("@maas", maas));
                }
                if (!string.IsNullOrWhiteSpace(tc))
                {
                    filters.Add("personelTC = @tc");
                    parameters.Add(new MySqlParameter("@tc", tc));
                }

                string filterQuery = string.Join(" AND ", filters);
                query += " " + filterQuery;

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddRange(parameters.ToArray());

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
