using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MySql
{
    public partial class Form1 : Form
    {
        string connectString = "server=127.0.0.1;database=programbarang;uid=root;pwd=;";
        MySqlConnection myConnection;
        public Form1()
        {
            InitializeComponent();
        }

        private bool MySqlConnect()
        {
            myConnection = new MySqlConnection(connectString);
            try
            {
                myConnection.Open();
                return true;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                return false;
            }
        }

        private void MySqlDisconnect()
        {
            myConnection.Close();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (MySqlConnect())
            {
                MessageBox.Show("Terkoneksi");
            }
        }

        private void btnShowdata_Click(object sender, EventArgs e)
        {
            listResult.Items.Clear();
            if (MySqlConnect())
            {
                string query = "SELECT * FROM barangdata";
                var cmd = new MySqlCommand(query, myConnection);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    uint idBarang = reader.GetUInt32(0);
                    string namaBarang = reader.GetString(1);
                    uint beratBarang = reader.GetUInt32(2);
                    uint hargaBarang = reader.GetUInt32(3);
                    DateTime TanggalDimasukan = reader.GetDateTime(4);
                    DateTime TanggalEdit = reader.GetDateTime(5);
                    listResult.Items.Add("-------------------------------------------------------------------------------------------------------------------------");
                    listResult.Items.Add("|  " + idBarang + "  |  " + namaBarang + "  |  " + beratBarang + "  |  " + hargaBarang + "  |  " + TanggalDimasukan + "  |  " + TanggalEdit + "  |"
                        );
                }
                MySqlDisconnect();
            }
        }

        private void btnAdditems_Click(object sender, EventArgs e)
        {
            string getNama = txtNama.Text;
            uint getBerat = uint.Parse(txtBerat.Text);
            uint getHarga = uint.Parse(txtHarga.Text);
            if (MySqlConnect())
            {
                string query = string.Format("INSERT INTO barangdata(namaBarang, beratBarang, hargaBarang, tanggalDimasukan, tanggalEdit) VALUES ('{0}','{1}','{2}','{3}','{4}')",
                    (object)getNama,
                    (object)getBerat,
                    (object)getHarga,
                    (object)DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    (object)DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                try
                {
                    var cmd = new MySqlCommand(query, myConnection);
                    cmd.ExecuteNonQuery();
                    txtNama.Text = "";
                    txtBerat.Text = "";
                    txtHarga.Text = "";
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error");
                }
                MySqlDisconnect();
            }
        }

        private void btnEdititems_Click(object sender, EventArgs e)
        {
            uint getIDBarang = (uint)numidbarang.Value;
            uint getBerat = uint.Parse(txtEditBerat.Text);
            uint getHarga = uint.Parse(txtEditHarga.Text);
            bool barangFound = false;

            if (MySqlConnect())
            {
                string queryCheck = "SELECT idBarang FROM barangdata WHERE idBarang='" + getIDBarang.ToString() + "'";
                try
                {
                    var cmdCheck = new MySqlCommand(queryCheck, myConnection);
                    var reader = cmdCheck.ExecuteReader();
                    if (reader.HasRows)
                    {
                        barangFound = true;
                    }
                    else
                    {
                        MessageBox.Show("Barang tidak dapat ditemukan");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error");
                }
            }

            if (MySqlConnect())
            {
                string query = string.Format("UPDATE barangdata SET beratBarang='{1}', hargaBarang='{2}', tanggalEdit='{3}' WHERE idBarang='{0}' ",
                    (object) getIDBarang,
                    (object) getBerat,
                    (object) getHarga,
                    (object) DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                try
                {
                    var cmd = new MySqlCommand(query, myConnection);
                    cmd.ExecuteNonQuery();
                    txtNama.Text = "";
                    txtBerat.Text = "";
                    txtHarga.Text = "";
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error");
                }
                MySqlDisconnect();
            }
        }
    }
}
