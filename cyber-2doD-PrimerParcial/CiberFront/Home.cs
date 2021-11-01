using System;
using System.Windows.Forms;
using Biblioteca;

namespace CiberFront
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            InicializarPuestos();
            InicializarClientesEspera();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void bttnAlta_Click(object sender, EventArgs e)
        {
            Alta formAlta = new Alta();
            formAlta.Show();
        }

        private void InicializarPuestos() 
        {
            foreach (Computadora c in Datos.GenerarPuestosComputadora())
            {
                Gestion.CargarPuestos(c);
            }
        }

        private void Home_Activated(object sender, EventArgs e)
        {
            MostrarClienteEspera();
        }

        private void InicializarClientesEspera() 
        {
            foreach (Cliente c in Datos.GenerarListaClientes()) 
            {
                Gestion.ColocarClienteAEspera(c);
            }
        }

        private void MostrarClienteEspera() 
        {
            lstBoxEsperaComputadora.Items.Clear();

            foreach (Cliente item in Gestion.ColaClientesEspera)
            {
                lstBoxEsperaComputadora.Items.Add(Cliente.Mostrar(item));
            }
        }


        private void bttnAsignarPuesto_Click(object sender, EventArgs e)
        {   
            Gestion.AsignarPuesto();
            MostrarClienteEspera();
        }


        private void bttnCerrar_Click(object sender, EventArgs e)
        {
            Puesto puesto = Gestion.LiberarPuesto(((Button)sender).Name);
            MessageBox.Show(Gestion.MostrarFactura(puesto));
        }
    }
}
