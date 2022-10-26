using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label_min_Click(object sender, EventArgs e)
        {

        }

        private void btn_pick_Click(object sender, EventArgs e)
        {
            int numMin = 0;
            int numMax = 0;

            //check validation int
            bool isnumMin = int.TryParse(value_min.Text, out numMin);
            bool isnumMax = int.TryParse(value_max.Text, out numMax);

            // app work if the input is int
            if (isnumMin && isnumMax)
            {
                if (numMax > numMin)
                {
                    Random rand = new Random();
                    int pickednum = rand.Next(numMin, numMax);
                    value_rand.Text = pickednum.ToString();
                }
                else
                {
                    MessageBox.Show("Angka Minimal Harus Lebih Kecil Dari Maksimal", "Salah Input");
                }
            }
            // exception
            else
            {
                MessageBox.Show("Masukan Angka Saja Plis", "Salah Input");
            }
        }
    }
}
