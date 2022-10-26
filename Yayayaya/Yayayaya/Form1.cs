using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yayayaya
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
            string buah = textBox1.Text;
            comboBox1.Items.Add(buah);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "Kamu Beli " + comboBox1.Text;

            listBox1.Items.Add("Kamu Beli " + comboBox1.Text + " Sebanyak " +numericUpDown1.Value.ToString()); 
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            button2.BackColor = Color.Black;
        }
    }
}
