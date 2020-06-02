using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_8_bueno
{
    public partial class Form1 : Form
    {
        public class Local
        {
            public string NombreLocal { get; set; }
            public string NombreDueño { get; set; }
            public int idLocal { get; set; }

        }
        public class Cine
        {
            public string NombreLocal { get; set; }
            public string NombreDueño { get; set; }
            public int idLocal { get; set; }
            public int cantSalas { get; set; }

        }


        List<Local> listaTiendas = new List<Local>();
        List<Local> listaRestaurantes = new List<Local>();
        List<Cine> listaCines = new List<Cine>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTienda_Click(object sender, EventArgs e)
        {
            panelTiendas.Visible = true;
            //con este voy hacie las tiendas
            //Borramos todas las tiendas
            listViewListaTienda.Items.Clear();
            foreach (Local tienda in listaTiendas)
            {
                ListViewItem item = new ListViewItem();
                item = listViewListaTienda.Items.Add(tienda.NombreLocal);
            }
        }

        private void btnRestaurante_Click(object sender, EventArgs e)
        {
            panelRestaurante.Visible = true;
            listViewRestaurant.Items.Clear();
            foreach (Local tienda in listaRestaurantes)
            {
                ListViewItem item = new ListViewItem();
                item = listViewRestaurant.Items.Add(tienda.NombreLocal);
            }
        }
        
        private void bbtnCine_Click(object sender, EventArgs e)
        {
            panelCine.Visible = true;
            //con este voy hacie las tiendas
            //Borramos todas las tiendas
            listViewCine.Items.Clear();
            foreach (Cine tienda in listaCines)
            {
                ListViewItem item = new ListViewItem();
                item = listViewCine.Items.Add(tienda.NombreLocal);
            }
        }

        private void btnRecreacional_Click(object sender, EventArgs e)
        {
            panelRecreacional.Visible = true;
        }

        private void btnVolver1_Click(object sender, EventArgs e)
        {
            panelVerLocales.Visible = false;
        }

        private void volver2_Click(object sender, EventArgs e)
        {
            panelTiendas.Visible = false;
        }

        private void btnIrTienda_Click(object sender, EventArgs e)
        {
            panelTiendaElegida.Visible = true;
        }

        private void volver3_Click(object sender, EventArgs e)
        {
            panelTiendaElegida.Visible = false;
        }

        private void volver5_Click(object sender, EventArgs e)
        {
            panelCineElegido.Visible = false;
        }

        private void textIrRestaurante_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIrRestauElegido_Click(object sender, EventArgs e)
        {
            panelRestaurElegido.Visible = true;
        }

        private void volver6_Click(object sender, EventArgs e)
        {
            panelRestaurElegido.Visible = false;
        }

        private void textNomRest_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNomDueñoResta_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNumRest_TextChanged(object sender, EventArgs e)
        {

        }

        private void volver7_Click(object sender, EventArgs e)
        {
            panelRestaurante.Visible = false;
        }

        private void CrearLocal_Click(object sender, EventArgs e)
        {
            panelCrearLocal.Visible = true;
        }

        private void textCualCrear_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnIrACrear_Click(object sender, EventArgs e)
        {
            panelCreandoLocal.Visible = true;
        }

        private void volver8_Click(object sender, EventArgs e)
        {
            panelCrearLocal.Visible = false;
        }

        private void volver9_Click(object sender, EventArgs e)
        {
            panelCreandoLocal.Visible = false;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (textNuevoLocal.Text == "tienda")
            {
                //creado nombre local, nombre dueño, id y horario de atencion 
                Local tien = new Local();
                tien.NombreLocal = textCrearLocal.Text;
                tien.NombreDueño = textCrearDueño.Text;
                tien.idLocal = Convert.ToInt32(textCrearNumero.Text);
                listaTiendas.Add(tien);
                MessageBox.Show("Tienda agregada correctamente");
                textCrearLocal.Text = string.Empty;
                textCrearDueño.Text = string.Empty;
                textCrearNumero.Text = string.Empty;

            }
            else if (textNuevoLocal.Text == "restaurante")
            {
                //creado nombre restaurant, dueño, id, horario
                Local res = new Local();
                res.NombreLocal = textCrearLocal.Text;
                res.NombreDueño = textCrearDueño.Text;
                res.idLocal = Convert.ToInt32(textCrearNumero.Text);
                listaRestaurantes.Add(res);
                MessageBox.Show("Restaurante agregada correctamente");
                textCrearLocal.Text = string.Empty;
                textCrearDueño.Text = string.Empty;
                textCrearNumero.Text = string.Empty;
               

            }
            else if (textNuevoLocal.Text == "cine")
            {
                //creado nombre cine, dueño, id, horario, cantidad de salas
                Cine cin = new Cine();
                cin.NombreLocal = textCrearLocal.Text;
                cin.NombreDueño = textCrearDueño.Text;
                cin.idLocal = Convert.ToInt32(textCrearNumero.Text);
                cin.cantSalas = Convert.ToInt32(textCrearSalas.Text);
                listaCines.Add(cin);
                MessageBox.Show("Cine agregada correctamente");
                textCrearLocal.Text = string.Empty;
                textCrearDueño.Text = string.Empty;
                textCrearNumero.Text = string.Empty;
                textCrearSalas.Text = string.Empty;

            }
            panelCreandoLocal.Visible = false;
            panelCrearLocal.Visible = false;
        }

        private void listViewListaTienda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewRestaurant_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void VerLocales_Click(object sender, EventArgs e)
        {
            panelVerLocales.Visible = true;
        }

        private void volver10_Click(object sender, EventArgs e)
        {
            panelRecreacional.Visible = false;
        }

        private void Volver4_Click(object sender, EventArgs e)
        {
            panelCine.Visible = false;
        }
    }
}
