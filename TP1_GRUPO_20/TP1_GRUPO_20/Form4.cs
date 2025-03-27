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
    public partial class Ejercicio3 : Form
    {

        FormPrincipal formprincipal;
        public Ejercicio3(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            this.formprincipal = formPrincipal;
        }
        private void Ejercicio3_FormClosed(object sender, FormClosedEventArgs e)
        {
            formprincipal.Show();
        }
    }

}
