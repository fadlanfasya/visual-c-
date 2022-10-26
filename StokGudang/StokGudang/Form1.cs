using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokGudang
{
    public partial class Form1 : Form
    {
        List<kardus> listKardus = new List<kardus>();
        public int KardusID = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void RefreshDataGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (kardus getKardus in listKardus)
            {
                string[] newRow = { "", "", "", "", "" };
                newRow[0] = getKardus.ID.ToString();
                newRow[1] = getKardus.Nama;
                newRow[2] = getKardus.Berat.ToString();
                newRow[3] = getKardus.Isi.ToString();
                newRow[4] = getKardus.Kadaluarsa.ToString();
                dataGridView1.Rows.Add(newRow);
            }
        }

        private void btnTambahDus_Click(object sender, EventArgs e)
        {
            kardus kardusBaru = new kardus();
            kardusBaru.Nama = txtNamaDus.Text;
            kardusBaru.Berat = (int)numBeratDus.Value;
            kardusBaru.Isi = (int)numIsiDus.Value;
            kardusBaru.Kadaluarsa = dateTimePicker1.Value;
            listKardus.Add(kardusBaru);
            RefreshDataGrid();
        }

        private void btnHapusDus_Click(object sender, EventArgs e)
        {
            int getID = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i += 1)
            {
                if (dataGridView1.Rows[i].Selected)
                {
                    getID = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                    break;
                }
            }
            foreach (kardus checkKardus in listKardus);
        }
    }
}