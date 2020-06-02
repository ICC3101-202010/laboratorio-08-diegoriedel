using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void verLocal_Click(object sender, EventArgs e)
        {
            VerLocales.Visible = true;
        }

        private void crearLocal_Click(object sender, EventArgs e)
        {

        }

        private void volver1_Click(object sender, EventArgs e)
        {
            VerLocales.Visible = false;
        }

        private void lblTienda_Click(object sender, EventArgs e)
        {
            Tienda.Visible = true;
        }

        private void volverTienda_Click(object sender, EventArgs e)
        {
            Tienda.Visible = false;
        }
    }
}
