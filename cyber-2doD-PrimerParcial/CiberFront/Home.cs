using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace CiberFront
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InicializarPuestos();
            lstBoxEsperaComputadora.Items.Add("laura");
            llstBoxEsperaTelefono.Items.Add("Nelida");

            lblPuesto_C01_001.Text = "Laura";
        }

        private void CargarClienteEnEspera() 
        {
            lstBoxEsperaComputadora.Items.Add("");
        }

        private void bttnAlta_Click(object sender, EventArgs e)
        {
            Alta formAlta = new Alta();
            formAlta.Show();
        }

        private void InicializarPuestos() 
        {
            foreach (Puesto p in Datos.GenerarPuestosComputadora())
            {
                Gestion.CargarPuestos(p);
            }
        }

        private void MostrarClienteEspera() 
        {
            foreach (Cliente item in Gestion.ColaClientesEspera)
            {
                lstBoxEsperaComputadora.Items.Add(Cliente.Mostrar(item));
            }
        }

        private void Home_Activated(object sender, EventArgs e)
        {
            MostrarClienteEspera();
        }
    }
}
