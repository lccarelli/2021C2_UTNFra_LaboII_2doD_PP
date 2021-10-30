using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public abstract class Gestion
    {
        private static List<Puesto> listaPuestos;
        private static Queue<Cliente> colaClientesEspera;
        private static List<Puesto> listaPuestosLibre;

        static Gestion()
        {
            listaPuestos = new List<Puesto>();
            colaClientesEspera = new Queue<Cliente>();
            listaPuestosLibre = new List<Puesto>();
        }

        public static List<Puesto> ListaPuestos 
        {
            get 
            {
                return listaPuestos;
            }
        }

        public static List<Puesto> ListaPuestosLibres
        {
            get 
            {
                return ListaPuestosLibres;
            }
        }

        public static Queue<Cliente> ColaClientesEspera 
        {
            get 
            {
                return colaClientesEspera;
            }
        }

        public static void CargarPuestos(Puesto puesto) 
        {
            if (puesto is not null) 
            {
                listaPuestos.Add(puesto);
            }
        }

        /// <summary>
        /// Ingresa cliente a cola de espera, si este no está repetido 
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns>true -> cliente cargado</returns>
        /// <returns>false -> cliente duplicado</returns>
        public static bool ColocarClienteAEspera(Cliente cliente) 
        {
            if (cliente is not null) 
            {
                colaClientesEspera.Enqueue(cliente);
                return true;
            }
            return false;
        }

        public static void AsignarPuesto() 
        {
            if (ListarPuestosLibres().Count > 0) 
            {
                Cliente cliente = colaClientesEspera.Peek();

                foreach (Puesto item in ListarPuestosLibres())
                {
                    if (cliente.TipoPuesto == item.TipoPuesto) 
                    {
                        item.IniciarSesion();
                        colaClientesEspera.Dequeue();
                    }
                }
                
            }
        }

        public static void LiberarPuesto(Puesto puesto) 
        {
            if (puesto is not null && puesto.Estado == Estado.EN_USO) 
            {
                puesto.FinalizarSesion();
            }     
        }

        /// <summary>
        /// Genera una nueva lista de puestos libres cada vez que se la invoca.
        /// </summary>
        /// <returns>Lista de puestos en estado LIBRE</returns>
        private static  List<Puesto> ListarPuestosLibres() 
        { 
            foreach (Puesto item in ListaPuestos)
            {
                if (item.Estado is Estado.LIBRE) 
                {
                    listaPuestosLibre.Add(item);
                }
            }

            return listaPuestosLibre;
        }


        public string MostrarComputadorasEnUso() 
        {
            StringBuilder sb = new();

            sb.AppendLine("DNI  ---  NOMBRE  ---  APELLIDO  ---  EDAD");

            return sb.ToString();
        }

    }
}
