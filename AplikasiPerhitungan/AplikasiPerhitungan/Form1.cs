using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiPerhitungan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_hasil_Click(object sender, EventArgs e)
        {
            int numA = 0;
            int numB = 0;

            //check validation int
            bool isnumA = int.TryParse(value_a.Text, out numA);
            bool isnumB = int.TryParse(value_b.Text, out numB);

            // app work if the input is int
            if (isnumA && isnumB)
            {
                int hasil = numA + numB;
                value_plus.Text = hasil.ToString();
            }
            // exception
            else
            {
                MessageBox.Show("Masukan Angka Saja Plis", "Salah Input");
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            value_a.Text = "";
            value_b.Text = "";
            value_plus.Text = "";
        }
    }
}
