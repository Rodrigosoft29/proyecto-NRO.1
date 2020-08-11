using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adminFacturas
{
    public partial class factIndividual : Form
    {

        Validacion val = new Validacion();

        public factIndividual()
        {
            InitializeComponent();
        }
        private void Comprobar()
        {
            if (textBox43.Text == "")
            {
                errorProvider1.SetError(textBox43, "Ingrese porcentaje de I.V.A");
                textBox43.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(textBox43, "");
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {

            Comprobar();
            

            int num1 = int.Parse(textBox17.Text);
            int num2 = int.Parse(textBox12.Text);
            int num3 = int.Parse(textBox27.Text);
            int num4 = int.Parse(textBox22.Text);
            int num5 = int.Parse(textBox37.Text);
            int num6 = int.Parse(textBox32.Text);
            int num7 = int.Parse(textBox43.Text);


            int totalN;
            int totalF;

            totalN = (num1 + num2 + num3 + num4 + num5 + num6);

            textBox44.Text = totalN.ToString();

            totalF = totalN + ((totalN * num7) / 100);

            textBox42.Text = totalF.ToString();

        }

        private void factIndividual_Load(object sender, EventArgs e)
        {
            textBox44.Enabled = false;
            textBox42.Enabled = false;

           

        }

        

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoloLetras(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoloLetras(e);

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoloNumeros(e);
        }

        private void textBox44_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox43_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Limpiar lm = new Limpiar();

            lm.Borrar(this);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            conIngreso frm1 = new conIngreso();

            DialogResult r = MessageBox.Show("¿Desea salir de formulario?", "", MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)

                

                frm1.ShowDialog();

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoloNumeros(e);

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoloNumeros(e);
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoloNumeros(e);
        }

        private void textBox27_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoloNumeros(e);
        }

        private void textBox22_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoloNumeros(e);
        }

        private void textBox37_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoloNumeros(e);
        }

        private void textBox32_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoloNumeros(e);
        }

        private void textBox43_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoloNumeros(e);
        }
    }
}
