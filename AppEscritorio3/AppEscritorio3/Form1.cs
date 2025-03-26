using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEscritorio3
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

        private void txtBoxNombreApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtBoxNombreApellido.Text.Trim() != "")
            {
            lbPersonas.Items.Add(txtBoxNombreApellido.Text.Trim()); //.trim() es para borra los espacios en blanco
            txtBoxNombreApellido.Text = ""; //es para limpiar el cuadro de txt
                //MessageBox.Show("Agregado"); es solo feedback

            }
            else
            {
                MessageBox.Show("Ingresar nombre y apellido. ");
            }
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El elemento seleccionado es: " + lbPersonas.SelectedItem);
        }
    }
}
