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
    }
}
