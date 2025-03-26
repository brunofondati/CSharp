using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEscritorio1
{
    public partial class AppEscritorio1: Form
    {
        public AppEscritorio1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido " + txtNombre.Text, "Atención"); 
            //mjs de salida y titulo del mjs
            txtNombre.Text =string.Empty; 
            //dejar vacia la caja de txt
        }
    }
}
