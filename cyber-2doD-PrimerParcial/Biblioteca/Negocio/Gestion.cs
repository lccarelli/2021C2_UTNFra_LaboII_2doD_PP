using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public abstract class Gestion
    {
        private static List<Puesto> listaPuestos;
        private static Queue<Cliente> colaClientesEspera;



        static Gestion()
        {
            listaPuestos = new List<Puesto>();
            colaClientesEspera = new Queue<Cliente>();
        }

        public static List<Puesto> ListaPuestos 
        {
            get 
            {
                return listaPuestos;
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

        public static void AsignarPuesto(Puesto puesto) 
        {
            if (ListarPuestosLibres().Count > 0 && puesto is not null) 
            {
                foreach (Puesto item in ListarPuestosLibres())
                {
                    if (puesto.TipoPuesto == item.TipoPuesto) 
                    {
                        puesto.IniciarSesion();
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
            List<Puesto> listaPuestosLibres = new List<Puesto>();

            foreach (Puesto item in ListaPuestos)
            {
                if (item.Estado is Estado.LIBRE) 
                {
                    listaPuestosLibres.Add(item);
                }
            }

            return listaPuestosLibres;
        }


        public string MostrarComputadorasEnUso() 
        {
            StringBuilder sb = new();

            sb.AppendLine("DNI  ---  NOMBRE  ---  APELLIDO  ---  EDAD");

            return sb.ToString();
        }

    }
}
