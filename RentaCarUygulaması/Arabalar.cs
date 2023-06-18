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
using System.Xml;
using MySql.Data.MySqlClient;

namespace RentaCarUygulaması
{
    public partial class Arabalar : Form
    {
        string connectionString = "Server=localhost;Database=rentacar;Uid=root;Pwd=admin;";
        public Arabalar()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            try
            {
                

                string marka = markatxt.Text;
                string model = modeltxt.Text;
                int yil;
                if (!int.TryParse(yıltxt.Text, out yil))
                {
                    MessageBox.Show("Geçerli bir yıl giriniz.");
                    return;
                }
                string plaka = plakatxt.Text;
                string renk = renkcmb.Text;
                string yakitTuru = yakıtcmb.Text;
                decimal fiyat;
                if (!decimal.TryParse(fiyattxt.Text, out fiyat))
                {
                    MessageBox.Show("Geçerli bir fiyat giriniz.");
                    return;
                }

                if (string.IsNullOrEmpty(marka) || string.IsNullOrEmpty(model) || string.IsNullOrEmpty(plaka) ||
                    string.IsNullOrEmpty(renk) || string.IsNullOrEmpty(yakitTuru))
                {
                    MessageBox.Show("Tüm alanları doldurunuz.");
                    return;
                }

                string query = "INSERT INTO arabalar (marka, model, yıl, plaka, renk, yakıt_türü, fiyat) " +
                               "VALUES (@marka, @model, @yil, @plaka, @renk, @yakitTuru, @fiyat)";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@marka", marka);
                command.Parameters.AddWithValue("@model", model);
                command.Parameters.AddWithValue("@yil", yil);
                command.Parameters.AddWithValue("@plaka", plaka);
                command.Parameters.AddWithValue("@renk", renk);
                command.Parameters.AddWithValue("@yakitTuru", yakitTuru);
                command.Parameters.AddWithValue("@fiyat", fiyat);

                command.ExecuteNonQuery();

                MessageBox.Show("Veri başarıyla kaydedildi.");
                string selectQuery = "SELECT * FROM arabalar";
                MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: Başarılı Kayıt edilemedi. " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void Arabalar_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM arabalar";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
            adapter.Dispose();
            command.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            try
            {
                

                string marka = markatxt.Text;
                string model = modeltxt.Text;
                string yil =yıltxt.Text;             
                string plaka = plakatxt.Text;
                string renk = renkcmb.Text;
                string yakitTuru = yakıtcmb.Text;

                string query = "SELECT * FROM arabalar WHERE ";
                bool isFirstCondition = true;

                if (!string.IsNullOrEmpty(marka))
                {
                    query += "marka = @marka";
                    isFirstCondition = false;
                }

                if (!string.IsNullOrEmpty(model))
                {
                    if (!isFirstCondition)
                        query += " AND ";

                    query += "model = @model";
                    isFirstCondition = false;
                }

                if (!string.IsNullOrEmpty(yil))
                {
                    if (!isFirstCondition)
                        query += " AND ";

                    query += "yıl = @yil";
                    isFirstCondition = false;
                }               

                if (!string.IsNullOrEmpty(plaka))
                {
                    if (!isFirstCondition)
                        query += " AND ";

                    query += "plaka = @plaka";
                    isFirstCondition = false;
                }

                if (!string.IsNullOrEmpty(renk))
                {
                    if (!isFirstCondition)
                        query += " AND ";

                    query += "renk = @renk";
                    isFirstCondition = false;
                }

                if (!string.IsNullOrEmpty(yakitTuru))
                {
                    if (!isFirstCondition)
                        query += " AND ";

                    query += "yakıt_türü = @yakitTuru";
                    isFirstCondition = false;
                }

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@marka", marka);
                command.Parameters.AddWithValue("@model", model);       
                command.Parameters.AddWithValue("@yil", yil);
                command.Parameters.AddWithValue("@plaka", plaka);
                command.Parameters.AddWithValue("@renk", renk);
                command.Parameters.AddWithValue("@yakitTuru", yakitTuru);

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

        private void guncelleme_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                string plaka = plakatxt.Text;
                string yeniMarka = markatxt.Text;
                string yeniModel = modeltxt.Text;
                string yeniYil = yıltxt.Text;
                string yeniRenk = renkcmb.Text;
                string yeniYakitTuru = yakıtcmb.Text;
                string yeniFiyat = fiyattxt.Text;

                string query = "UPDATE arabalar SET ";
                bool isFirstCondition = true;

                if (!string.IsNullOrEmpty(yeniMarka))
                {
                    query += "marka = @yeniMarka";
                    isFirstCondition = false;
                }

                if (!string.IsNullOrEmpty(yeniModel))
                {
                    if (!isFirstCondition)
                        query += ", ";

                    query += "model = @yeniModel";
                    isFirstCondition = false;
                }

                if (!string.IsNullOrEmpty(yeniYil))
                {
                    if (!isFirstCondition)
                        query += ", ";

                    query += "yıl = @yeniYil";
                    isFirstCondition = false;
                }

                if (!string.IsNullOrEmpty(yeniRenk))
                {
                    if (!isFirstCondition)
                        query += ", ";

                    query += "renk = @yeniRenk";
                    isFirstCondition = false;
                }

                if (!string.IsNullOrEmpty(yeniYakitTuru))
                {
                    if (!isFirstCondition)
                        query += ", ";

                    query += "yakıt_türü = @yeniYakitTuru";
                    isFirstCondition = false;
                }

                if (!string.IsNullOrEmpty(yeniFiyat))
                {
                    if (!isFirstCondition)
                        query += ", ";

                    query += "fiyat = @yeniFiyat";
                }

                query += " WHERE plaka = @plaka";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@yeniMarka", yeniMarka);
                command.Parameters.AddWithValue("@yeniModel", yeniModel);
                command.Parameters.AddWithValue("@yeniYil", yeniYil);
                command.Parameters.AddWithValue("@yeniRenk", yeniRenk);
                command.Parameters.AddWithValue("@yeniYakitTuru", yeniYakitTuru);
                command.Parameters.AddWithValue("@yeniFiyat", yeniFiyat);
                command.Parameters.AddWithValue("@plaka", plaka);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Araç başarıyla güncellendi.");

                    string selectQuery = "SELECT * FROM arabalar";
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                markatxt.Text = row.Cells["marka"].Value.ToString();
                modeltxt.Text = row.Cells["model"].Value.ToString();
                yıltxt.Text = row.Cells["yıl"].Value.ToString();
                plakatxt.Text = row.Cells["plaka"].Value.ToString();
                renkcmb.Text = row.Cells["renk"].Value.ToString();
                yakıtcmb.Text = row.Cells["yakıt_türü"].Value.ToString();
                fiyattxt.Text = row.Cells["fiyat"].Value.ToString();
            }
        }

        private void sil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                
                string plaka = selectedRow.Cells["plaka"].FormattedValue.ToString();

                string connectionString = "Server=localhost;Database=rentacar;Uid=root;Pwd=admin;";
                MySqlConnection connection = new MySqlConnection(connectionString);

                try
                {
                    connection.Open();

                    string query = "DELETE FROM arabalar WHERE plaka = @plaka";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@plaka", plaka);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Araç başarıyla silindi.");                    
                        dataGridView1.Rows.Remove(selectedRow);
                        string selectQuery = "SELECT * FROM arabalar";
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
    }
}
