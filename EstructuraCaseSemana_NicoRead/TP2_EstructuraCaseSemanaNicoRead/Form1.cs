using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2_EstructuraCaseSemanaNicoRead
{
    public partial class Form1 : Form
    {

        string[] dias = new string[] {"Lunes","Martes","Miercoles","Jueves","Viernes","Sabado","Domingo" } ;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(textBox1.Text);
            if (numero>=1 & numero<=7 ){
                textBox2.Text = Convert.ToString(dias[numero-1]);
            }

            else
            {
                Form2 mensaje = new Form2();
                mensaje.Show();
            }
           
            


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
