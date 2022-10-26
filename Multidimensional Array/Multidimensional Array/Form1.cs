using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multidimensional_Array
{
    public partial class Form1 : Form
    {
        int[,] arraynilai;
        int berapabaris, berapakolom;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int baris = int.Parse(textBox1.Text);
            int kolom = int.Parse(textBox2.Text);
            berapabaris = baris;
            berapakolom = kolom;

            arraynilai = new int[baris, kolom];

            for (int i = 0; i < baris; i += 1)
            {
                comboBox1.Items.Add(i + 1);
            }
            for (int i = 0; i < kolom; i += 1)
            {
                comboBox2.Items.Add(i + 1);
            }

            for (int i = 0; i < baris; i += 1)
            {
                string strbaris = "";
                for (int j = 0; j < kolom; j += 1)
                {
                    strbaris += arraynilai[i, j].ToString() + "\t";
                }
                listBox1.Items.Add(strbaris);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int nampilbariske = int.Parse(textBox4.Text)-1;
            string strbaris = "";

            listBox1.Items.Clear();
            for (int j = 0; j < berapakolom; j += 1)
            {
                strbaris += arraynilai[nampilbariske, j].ToString() + "\t";
            }
            listBox1.Items.Add(strbaris);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int nilai = int.Parse(textBox3.Text);

            int bariske = int.Parse(comboBox1.Text)-1;
            int kolomke = int.Parse(comboBox2.Text)-1;

            arraynilai[bariske, kolomke] = nilai;

            listBox1.Items.Clear();
            for (int i = 0; i < berapabaris; i += 1)
            {
                string strbaris = "";
                for (int j = 0; j < berapakolom; j += 1)
                {
                    strbaris += arraynilai[i, j].ToString() + "\t";
                }
                listBox1.Items.Add(strbaris);
            }
        }
    }
}
