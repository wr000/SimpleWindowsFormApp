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
    public partial class Form2 : Form
    {
        public Form2(List<String> texts)
        {
            InitializeComponent();

            //Логіка розрахунку
            textBox1.Text = texts[0];
            textBox2.Text = texts[1];
            textBox3.Text = texts[2];
            textBox4.Text = texts[3];
            string result = Convert.ToString((Convert.ToDouble(texts[4]) + Convert.ToDouble(texts[5])) / 2);
            textBox5.Text = result;//result.Substring(0, result.IndexOf('.') + 1);
            textBox6.Text = texts[6];
            textBox7.Text = texts[7];
            textBox9.Text = texts[8];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<String> texts = new List<string>();
            texts.Add(textBox1.Text);
            texts.Add(textBox2.Text);
            texts.Add(textBox3.Text);
            texts.Add(textBox4.Text);
            texts.Add(textBox5.Text);
            texts.Add(textBox6.Text);
            texts.Add(textBox7.Text);
            texts.Add(textBox9.Text);
            Form3 form3 = new Form3(texts);
            form3.Show();
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
