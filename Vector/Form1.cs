using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vector
{
    public partial class Form1 : Form
    {
        Vector vector;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            vector = new Vector(Convert.ToInt32(txtSize.Text));
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            vector.llenar(Convert.ToInt32(txtNumber.Text));
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            txtContent.Text = vector.mostrar();
        }

        private void btnGirarArriba_Click(object sender, EventArgs e)
        {
            vector.girarArriba();
        }

        private void btnGirarAbajo_Click(object sender, EventArgs e)
        {
            vector.girarAbajo();
        }

        private void btnInvertir_Click(object sender, EventArgs e)
        {
            vector.invertir();
        }
    }
}
