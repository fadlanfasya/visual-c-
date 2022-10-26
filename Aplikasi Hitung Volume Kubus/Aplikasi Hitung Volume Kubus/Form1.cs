using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Hitung_Volume_Kubus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label_volume_Click(object sender, EventArgs e)
        {
    
        }

        private void txt_volume_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void btn_hitung_Click(object sender, EventArgs e)
        {
            int sisi;

            bool check_sisi = int.TryParse(txt_sisi.Text, out sisi);

            if (check_sisi)
            {
                double volume = Math.Pow(sisi, 3);
                txt_volume.Text = volume.ToString();
                label_volume.Visible = true;
                txt_volume.Visible = true;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_sisi.Text = "";
            txt_volume.Text = "";
            label_volume.Visible = false;
            txt_volume.Visible = false;
        }
    }
}
