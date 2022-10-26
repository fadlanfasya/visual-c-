using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Hitung_Pangkat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_hitung_Click(object sender, EventArgs e)
        {
            double a, b, c;

            bool check_a = double.TryParse(txt_a.Text, out a);
            bool check_b = double.TryParse(txt_b.Text, out b);
            bool check_c = double.TryParse(txt_c.Text, out c);

            if (check_a && check_b && check_c)
            {
                double hasil = Math.Pow(a / b, b * c);
                txt_hasil.Text = hasil.ToString();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_a.Text = "";
            txt_b.Text = "";
            txt_c.Text = "";
            txt_hasil.Text = "";
        }
    }
}
