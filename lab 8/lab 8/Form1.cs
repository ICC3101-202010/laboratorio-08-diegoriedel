using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_8
{
    public partial class Form1 : Form
    {

        public class Persona
        {
            public string Nombre { get; set; }
        }

        List<string> listaTiendas = new List<string>();


       
            

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
            panel3.Visible = true;
        }

        private void volver1_Click(object sender, EventArgs e)
        {
            VerLocales.Visible = false;
        }

        private void Tienda_Click(object sender, EventArgs e)
        {
            Tienda.Visible = true;

           // tiendas.Text = listaTiendas;
        }

        private void volverTienda_Click(object sender, EventArgs e)
        {
            Tienda.Visible = false;
        }

        private void tiendas_Click(object sender, EventArgs e)
        {

        }

        private void restaurantes_Click(object sender, EventArgs e)
        {
            restaurante.Visible = true;
        }

        private void volver3_Click(object sender, EventArgs e)
        {
            restaurante.Visible = false;
        }

        private void cine_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void volver4_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void recreacional_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void Volver5_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void nuevoLocal_TextChanged(object sender, EventArgs e)
        {
            if (nuevoLocal.Text == "tienda")
            {
                //crear nombre local, nombre dueño, id y horario de atencion
            }
            else if (nuevoLocal.Text == "restaurante")
            {
                //crear nombre restaurant, dueño, id, horario
            }
            else if (nuevoLocal.Text == "cine")
            {
                //crear nombre cine, dueño, id, horario, cantidad de salas
            }
        }

        private void Volver6_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void Volver8_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
        }
    }
}
