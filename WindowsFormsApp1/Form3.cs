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
    public partial class Form3 : Form
    {
        public Form3(List<String> texts)
        {
            InitializeComponent();
            textBox1.Text = Convert.ToString((Double.Parse(texts[0]) + Double.Parse(texts[1]))/ 2);
            textBox2.Text = Convert.ToString((Double.Parse(texts[2]) + Double.Parse(texts[3]) + Double.Parse(texts[4])) / 3);
            textBox3.Text = Convert.ToString((Double.Parse(texts[5]) + Double.Parse(texts[6]) + Double.Parse(texts[7])) / 3);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
