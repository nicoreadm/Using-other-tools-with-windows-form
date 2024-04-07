using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp2_NicoRead
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int h_normales = Convert.ToInt32(textBox1.Text);
            int h_extras = Convert.ToInt32(textBox2.Text);                               //Extraer los datos de las TextBox y convertirlos a enteros
            int ph_normales = Convert.ToInt32(textBox3.Text);
            int ph_Extras = Convert.ToInt32(textBox4.Text);
            int num_hijos = Convert.ToInt32(numericUpDown1.Text);
            int bonificacion = (num_hijos * 20);
            Boolean verificacion = Convert.ToBoolean(this.checkBox1.Checked);           //Creo una variable Boolean para verificar si la ceckbox fue seleccionada

            int sueldo_bruto = (h_normales * ph_normales) + (h_extras * ph_Extras);     //Calcular el sueldo bruto
            int sueldo_neto = sueldo_bruto;
            


            if (verificacion == true)
            {
                sueldo_neto = sueldo_neto + bonificacion;

            }

            textBox6.Text = Convert.ToString(sueldo_bruto);
            textBox5.Text = Convert.ToString(sueldo_neto);
            textBox7.Text = Convert.ToString(bonificacion);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            textBox6.Text = null;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
