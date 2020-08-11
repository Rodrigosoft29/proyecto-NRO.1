using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adminFacturas
{
    public partial class masiva : Form
    {

        
        public masiva()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog();

            if (buscar.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = buscar.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Limpiar lm = new Limpiar();

            lm.Borrar(this);

            MessageBox.Show("Archivos ingresados");


            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Desea salir de la aplicacion?", "", MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)
                Application.Exit();
        }
    }
}
