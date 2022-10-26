using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int plus(int nilaiA, int nilaiB)
        {
            int jumlah = nilaiA + nilaiB;
            richTextBox1.Text = jumlah.ToString();
            return int.Parse(richTextBox1.Text);
        }

        private int minus(int nilaiA, int nilaiB)
        {
            int jumlah = nilaiA - nilaiB;
            richTextBox1.Text = jumlah.ToString();
            return int.Parse(richTextBox1.Text);
        }

        private int kali(int nilaiA, int nilaiB)
        {
            int jumlah = nilaiA * nilaiB;
            richTextBox1.Text = jumlah.ToString();
            return int.Parse(richTextBox1.Text);
        }

        private int bagi(int nilaiA, int nilaiB)
        {
            int jumlah = nilaiA / nilaiB;
            richTextBox1.Text = jumlah.ToString();
            return int.Parse(richTextBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "+")
            {
                int A = int.Parse(textBox1.Text);
                int B = int.Parse(textBox2.Text);
                plus(A, B);
            }
            else if (comboBox1.SelectedItem.ToString() == "-") 
            {
                int A = int.Parse(textBox1.Text);
                int B = int.Parse(textBox2.Text);
                minus(A, B);
            }
            else if (comboBox1.SelectedItem.ToString() == "*")
            {
                int A = int.Parse(textBox1.Text);
                int B = int.Parse(textBox2.Text);
                kali(A, B);
            }
            else
            {
                int A = int.Parse(textBox1.Text);
                int B = int.Parse(textBox2.Text);
                bagi(A, B);
            }
        }
    }
}
