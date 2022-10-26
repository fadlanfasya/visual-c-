using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Hitung_Diskon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_hitung_Click(object sender, EventArgs e)
        {
            int numPrice = 0;
            int numDiscount = 0;
            bool isnumPrice = int.TryParse(txt_price.Text, out numPrice);
            bool isnumDiscount = int.TryParse(txt_discount.Text, out numDiscount);

            if (isnumPrice && isnumDiscount)
            {
                int realprice = (int)((double)numDiscount / 100.0 * (double)numPrice);
                int sisauang = numPrice - realprice;
                txt_realprice.Text = sisauang.ToString();
             }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_discount.Text = "";
            txt_price.Text = "";
            txt_realprice.Text = "";
        }
    }
}
