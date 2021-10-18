using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Biblioteca;

namespace CiberFront
{
    public partial class Alta : Form
    {
        public Alta()
        {
            InitializeComponent();
        }

        private void bttnAceptar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(
                                            txtBxNombre.Text, 
                                            txtBxApellido.Text, 
                                            txtBxDNI.Text, 
                                            nmrcEdad.Value, BuscarSoftwares(), 
                                            BuscarPerifericos(), 
                                            BuscarJuegos(), 
                                            BuscarTipoPuesto(),
                                            new Telefono(txtBxArea.Text,
                                            txtBxPrefijo.Text,
                                            txtBxNumero.Text)
                                            );
        }

        private List<string> BuscarSoftwares() 
        {
            List<string> listaSoftwareSeleccionado = new List<string>();
            foreach (Control item in grpBxSoftware.Controls)
            {
                if (((CheckBox)item).CheckState == CheckState.Checked) 
                {
                    listaSoftwareSeleccionado.Add(item.Text);            
                }
            }
            return listaSoftwareSeleccionado;
        }

        private List<string> BuscarPerifericos()
        {
            List<string> listaPerifericoSeleccionado = new List<string>();
            foreach (Control item in grpBxPerifericos.Controls)
            {
                if (((CheckBox)item).CheckState == CheckState.Checked)
                {
                    listaPerifericoSeleccionado.Add(item.Text);
                }
            }
            return listaPerifericoSeleccionado;
        }

        private List<string> BuscarJuegos()
        {
            List<string> listaJuegoSeleccionado = new List<string>();
            foreach (Control item in grpBxJuegos.Controls)
            {
                if (((CheckBox)item).CheckState == CheckState.Checked)
                {
                    listaJuegoSeleccionado.Add(item.Text);
                }
            }
            return listaJuegoSeleccionado;
        }

        private TipoPuesto BuscarTipoPuesto() 
        {
            if (tgTipoComputadora.Checked)
            {
                return TipoPuesto.COMPUTADORA;
            }
            else if (tggTipoTelefono.Checked) 
            {
                return TipoPuesto.TELEFONO;
            }

            return TipoPuesto.NINGUNO;
        }
    }
}
