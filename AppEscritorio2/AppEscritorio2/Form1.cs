using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEscritorio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbColores.Items.Add("Rojo");
            cmbColores.Items.Add("Azul");
            cmbColores.Items.Add("Naranja");
            cmbColores.Items.Add("Violeta");
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int seleccion = cmbColores.SelectedIndex + 1;
            if (cmbColores.SelectedIndex != -1) { 
            MessageBox.Show("El elemento es " + cmbColores.SelectedItem + " con el orden "+ seleccion);
            }
            else
            {
                MessageBox.Show("Seleccione un Item");
            }
        }
    }
}
