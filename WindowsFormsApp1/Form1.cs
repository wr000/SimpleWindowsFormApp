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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //data transfer
            List<String> texts = new List<String>();
            texts.Add(maskedTextBox1.Text);
            texts.Add(maskedTextBox2.Text);
            texts.Add(maskedTextBox3.Text);
            texts.Add(maskedTextBox4.Text);
            texts.Add(maskedTextBox5.Text);
            texts.Add(maskedTextBox6.Text);
            texts.Add(maskedTextBox7.Text);
            texts.Add(maskedTextBox8.Text);
            texts.Add(maskedTextBox9.Text);

            //checking and formatting
            bool error = false;
            for (int i = 0; i < texts.Count; i++)
            {
                if (texts[i].First() == '.') texts[i] = (String)"0".Concat(texts[i]);
                if (texts[i].First() != '0')
                {
                    if (texts[i].First() != '1')
                        error = true;
                    else
                        if (texts[i].Last() != '0') error = true;
                    //if (error == true) this.Controls.Find("maskedTextBox", false)[0].ForeColor = Color.Red;
                }
            }
            if (error)
            {
                MessageBox.Show("Введіть значення від 0 до 1");
            }
            else
            {
                Form2 form2 = new Form2(texts);
                form2.Show();
                //this.Close();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "1.0";
            maskedTextBox1.Text = "0.5";
            maskedTextBox1.Text = "1.0";
            maskedTextBox1.Text = "0.4";
            maskedTextBox1.Text = "0.3";
            maskedTextBox1.Text = "0.2";
            maskedTextBox1.Text = "0.1";
            maskedTextBox1.Text = "0.5";
            maskedTextBox1.Text = "1.0";
            maskedTextBox1.Text = "0.3";
            maskedTextBox1.Text = "0.4";
        }
    }
}
