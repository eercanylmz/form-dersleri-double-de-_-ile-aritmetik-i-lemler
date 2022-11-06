using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_dersleri_double_değ__ile_aritmetik_işlemler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double number1, number2, canclasıon;
            number1 = Convert.ToDouble(textBox1.Text);
            number2 = Convert.ToDouble(textBox2.Text);
            canclasıon = number1 + number2;
            label4.Text = canclasıon.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double number1, number2, extraction;
            number1 = Convert.ToDouble(textBox4.Text);
            number2 = Convert.ToDouble(textBox3.Text);
            extraction = number1 - number2;
            label5.Text = extraction.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double number1, number2, impact;
            number1 = Convert.ToDouble(textBox6.Text);
            number2 = Convert.ToDouble(textBox5.Text);
            impact = number1 * number2;
            label9.Text = impact.ToString();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double number1, number2, divide;
            number1 = Convert.ToDouble(textBox8.Text);
            number2 = Convert.ToDouble(textBox7.Text);
            divide = number1 / number2;
            label17.Text = divide.ToString();
        }
    }
}
