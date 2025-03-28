using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_GRUPO_20
{
    public partial class Ejercicio1 : Form
    {
        FormPrincipal formPrincipal;
        public Ejercicio1(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Ejercicio1_FormClosed(object sender, FormClosedEventArgs e)
        {
            formPrincipal.Show();
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtBoxNombre.Text.Trim() != "")
            {
                string nuevoNombre = txtBoxNombre.Text.Trim().ToUpper();

                bool existe = lstBoxIzquierda.FindStringExact(nuevoNombre) != -1;

                if (!existe)
                {
                    lstBoxIzquierda.Items.Add(txtBoxNombre.Text.Trim());
                    txtBoxNombre.Text = "";
                }
                else
                {
                    MessageBox.Show("El nombre ya fue ingresado","Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSimple_Click(object sender, EventArgs e)
        {
            if (lstBoxIzquierda.SelectedIndex != -1) 
            {
                string seleccionado = lstBoxIzquierda.SelectedItem.ToString();
                lstBoxDerecha.Items.Add(seleccionado); 
                lstBoxIzquierda.Items.Remove(seleccionado);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un item para moverlo.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDoble_Click(object sender, EventArgs e)
        {
            if (lstBoxIzquierda.Items.Count > 0)
            {
                foreach (string nombres in lstBoxIzquierda.Items)
                {
                    lstBoxDerecha.Items.Add(nombres);
                }

                    lstBoxIzquierda.Items.Clear();
            }
            else
            {
                MessageBox.Show("No hay items para mover.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

