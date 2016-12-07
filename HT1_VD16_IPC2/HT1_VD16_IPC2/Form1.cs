using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HT1_VD16_IPC2
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

        private void button2_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            c = int.Parse(textBox3.Text);
            double raiz1 = (double)((b * -1) + ((b * b) - (4 * c * a)) ^ (1 / 2)) / (2 * a);
            double raiz2 = (double)((b * -1) - ((b * b) - (4 * c * a)) ^ (1 / 2)) / (2 * a);
            double x = raiz1 + raiz2;
            MessageBox.Show("Las raices son: " + raiz1 +" y " + raiz2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int var1, var2, var3;
            double promedio;

            var1 = int.Parse(textBox1.Text);
            var2 = int.Parse(textBox2.Text);
            var3 = int.Parse(textBox3.Text);
            promedio = (var1 + var2 + var3) / 3;
            var1 = var2;
            MessageBox.Show("El promedio es: "+promedio);
        }
    }
}
