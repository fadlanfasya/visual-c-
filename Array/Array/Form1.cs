using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numA = int.Parse(textBox1.Text);
            int numB = int.Parse(textBox2.Text);
            int hasilJumlah = numA + numB;
            listBox1.Items.Add(hasilJumlah.ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int numA = int.Parse(textBox1.Text);
            int numB = int.Parse(textBox2.Text);
            int hasilBagi = (numA + numB)/2;
            listBox1.Items.Add(hasilBagi.ToString());
        }

        List<int> listNum = new List<int>();
        private void list()
        {
            listNum.Add(5);
            listNum.Add(1000);
        }

        private void showlist()
        {
            foreach (int num in listNum)
            {
                listBox1.Items.Add(num);
            }
        }
    }
}
