using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using MySql.Data;


namespace RentaCarUygulaması
{
    public partial class Kiralamalar : Form
    {
        string connectionString = "Server=localhost;Database=rentacar;Uid=root;Pwd=admin;";
        private MySqlConnection connection;
        public Kiralamalar()
        {
            InitializeComponent();
           
        }






        private void button1_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection(connectionString);
            connection.Open();
            DateTime baslangicTarihi = kiralanmatarihi.Value;
            DateTime bitisTarihi = teslimtarihi.Value;
            //
            
            TimeSpan fark = bitisTarihi.Subtract(baslangicTarihi);
            int gunSayisi = fark.Days + 1;
          
            //
         
            DataRowView selectedCar = (DataRowView)araclarcmb.SelectedItem;
            int gunlukfiyat = Convert.ToInt32(selectedCar["fiyat"]);
            
            int toplamfiyat = gunSayisi * gunlukfiyat;

            int arabaId = 0;
            if (araclarcmb.SelectedItem != null)
            {
                DataRowView selectedRow = (DataRowView)araclarcmb.SelectedItem;
                arabaId = Convert.ToInt32(selectedRow["araba_id"]);
            }
            int musteriId = Convert.ToInt32(musterilercmb.SelectedValue);
            int personelId = Convert.ToInt32(personellercmb.SelectedValue);




            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Kiralama tablosuna veri ekleme sorgusu
                    string insertQuery = "INSERT INTO kiralamalar (araba_id, musteri_TC, personel_id, kiralama_tarihi, teslim_tarihi , ucret ) VALUES (@arabaId, @musteriId, @personelId, @baslangicTarihi, @bitisTarihi , @toplamfiyat)";

                    using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@arabaId", arabaId);
                        command.Parameters.AddWithValue("@musteriId", musteriId);
                        command.Parameters.AddWithValue("@personelId", personelId);
                        command.Parameters.AddWithValue("@baslangicTarihi", baslangicTarihi);
                        command.Parameters.AddWithValue("@bitisTarihi", bitisTarihi);
                        command.Parameters.AddWithValue("@toplamfiyat", toplamfiyat);

                        command.ExecuteNonQuery();
                    }
                    BindKiralamaTableToDataGridView();
                    MessageBox.Show("Kiralama işlemi başarıyla gerçekleştirildi.");
                    //KiralamaGeçmişine ekleme 
                    string insertQuery2 = "INSERT INTO kiralamagecmisi (araba_plaka, musteri_TC, personel_TC, kiralama_tarihi, teslim_tarihi , ucret ) VALUES (@arabaId, @musteriId, @personelId, @baslangicTarihi, @bitisTarihi , @toplamfiyat)";

                    using (MySqlCommand command = new MySqlCommand(insertQuery2, connection))
                    {
                        command.Parameters.AddWithValue("@arabaId", arabaId);
                        command.Parameters.AddWithValue("@musteriId", musteriId);
                        command.Parameters.AddWithValue("@personelId", personelId);
                        command.Parameters.AddWithValue("@baslangicTarihi", baslangicTarihi);
                        command.Parameters.AddWithValue("@bitisTarihi", bitisTarihi);
                        command.Parameters.AddWithValue("@toplamfiyat", toplamfiyat);

                        command.ExecuteNonQuery();
                    }
                    ///////

                    arabalarıgösterencombo();
                   

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kiralama işlemi sırasında bir hata oluştu: " + ex.Message);
                }
            }
            

        }
        private void Kiralamalar_Load(object sender, EventArgs e)
        {

            kiralanmatarihi.MinDate = DateTime.Today;
            teslimtarihi.MinDate = DateTime.Today.AddDays(1);


            try
            {
                
                arabalarıgösterencombo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanına bağlanırken bir hata oluştu: " + ex.Message);
            }

            try
            {

                musterilerigösterencombo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanına bağlanırken bir hata oluştu: " + ex.Message);
            }

            try
            {

                personeligösterencombo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanına bağlanırken bir hata oluştu: " + ex.Message);
            }
            BindKiralamaTableToDataGridView();

        }
        private void arabalarıgösterencombo()
        {
            connection = new MySqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM arabalar WHERE araba_id NOT IN (SELECT araba_id FROM kiralamalar)";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            araclarcmb.DisplayMember = "plaka"; // ComboBox'ta görünen değeri marka sütunu olarak ayarla
            araclarcmb.ValueMember = "id"; // ComboBox'tan seçilen değeri id sütunu olarak ayarla
                   
            araclarcmb.DataSource = dt;
            
            
            connection.Close();
        }
        private void musterilerigösterencombo()
        {
            connection = new MySqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM musteriler";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            musterilercmb.DisplayMember = "musteriTC"; // ComboBox'ta görünen değeri marka sütunu olarak ayarla
            musterilercmb.ValueMember = "musteri_id"; // ComboBox'tan seçilen değeri id sütunu olarak ayarla
            musterilercmb.DataSource = dt;
            connection.Close();
        }

        private void personeligösterencombo()
        {
            connection = new MySqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM personeller";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            personellercmb.DisplayMember = "personelTC"; // ComboBox'ta görünen değeri marka sütunu olarak ayarla
            personellercmb.ValueMember = "personel_id"; // ComboBox'tan seçilen değeri id sütunu olarak ayarla
            personellercmb.DataSource = dt;
            connection.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];


                string kiralama_id = selectedRow.Cells["kiralama_id"].FormattedValue.ToString();

                string connectionString = "Server=localhost;Database=rentacar;Uid=root;Pwd=admin;";
                MySqlConnection connection = new MySqlConnection(connectionString);

                try
                {
                    connection.Open();

                    string query = "DELETE FROM kiralamalar WHERE kiralama_id = @kiralama_id";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@kiralama_id", kiralama_id);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Kiralama başarıyla silindi.");
                        arabalarıgösterencombo();
                        dataGridView1.Rows.Remove(selectedRow);
                        string selectQuery = "SELECT * FROM kiralamalar";
                        MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("Silme işlemi başarısız oldu.");
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
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz satırı seçin.");
            }

        }
       
        private void araclarcmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        public void BindKiralamaTableToDataGridView()
        {
           
            string query = "SELECT * FROM kiralamalar";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }

        private void teslimtarihi_ValueChanged(object sender, EventArgs e)
        {
            teslimtarihi.MinDate = kiralanmatarihi.Value.AddDays(1);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string query = "SELECT * FROM kiralamagecmisi";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM kiralamalar";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }
    }
}
