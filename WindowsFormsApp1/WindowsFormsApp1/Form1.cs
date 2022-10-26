using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label_kesimpulan.Visible = true;
            label_kesimpulan.Text = "Nama = " + form_nama.Text + "\nMakanan Favorit = " + form_food.Text + "\nMinuman Favorit =" + form_drink.Text;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            form_nama.Text = "";
            form_food.Text = "";
            form_drink.Text = "";
            label_kesimpulan.Text = "";
        }
    }
}
