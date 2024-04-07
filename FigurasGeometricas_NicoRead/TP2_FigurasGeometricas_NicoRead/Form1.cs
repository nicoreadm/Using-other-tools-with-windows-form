using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2_FigurasGeometricas_NicoRead
{
    public partial class Form1 : Form
    {
        int Area = 0;
        int Perimetro = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;

            pictureBox1.Image = TP2_FigurasGeometricas_NicoRead.Properties.Resources.Flag_Blank_svg;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int lado_A = Convert.ToInt32(textBox2.Text);
            int lado_B = Convert.ToInt32(textBox1.Text);

   

            if (lado_A == lado_B)
            {
                 pictureBox1.Image = TP2_FigurasGeometricas_NicoRead.Properties.Resources.rojo1_d056292a69ad317cd116141122853698_640_0;
            }

            else
            {
                pictureBox1.Image = TP2_FigurasGeometricas_NicoRead.Properties.Resources.Bandera_San_Benito;
            }

            Area = lado_A * lado_B;
            Perimetro = (lado_A + lado_B) * 2;

            textBox3.Text = Convert.ToString(Area);
            textBox4.Text = Convert.ToString(Perimetro);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
