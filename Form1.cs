using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoubleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayı1, sayı2;
            double toplam, fark, çarpım, bölüm;
            sayı1 = Convert.ToDouble(textBox1.Text);
            sayı2 = Convert.ToDouble(textBox2.Text);

            toplam = sayı1 + sayı2;
            label6.Text = toplam.ToString();

            fark = sayı1 - sayı2;
            label5.Text = fark.ToString();

            çarpım = sayı1 * sayı2;
            label8.Text = çarpım.ToString();

            bölüm = sayı1 / sayı2;
            label10.Text = bölüm.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label6.Text = " ";
            label5.Text = " ";
            label8.Text = " ";
            label10.Text = " ";
        }
    }
}
