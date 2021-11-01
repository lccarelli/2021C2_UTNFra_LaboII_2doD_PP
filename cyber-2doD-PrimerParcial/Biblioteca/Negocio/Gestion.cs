using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public abstract class Gestion
    {
        private static List<Puesto> listaPuestos;
        private static List<Computadora> puestosComputadora;
        private static Queue<Cliente> colaClientesEspera;

        static Gestion()
        {
            listaPuestos = new List<Puesto>();
            colaClientesEspera = new Queue<Cliente>();
            puestosComputadora = new List<Computadora>();
        }


        public static Queue<Cliente> ColaClientesEspera 
        {
            get 
            {
                return colaClientesEspera;
            }
        }

        public static List<Computadora> PuestosComputadora { get => puestosComputadora; }


        public static void CargarPuestos(Computadora computadora) 
        {
            if (computadora is not null) 
            {
                puestosComputadora.Add(computadora);
            }
        }

        /// <summary>
        /// Ingresa cliente a cola de espera
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns>true</returns>
        /// <returns>false</returns>
        public static bool ColocarClienteAEspera(Cliente cliente) 
        {
            if (cliente is not null) 
            {
                colaClientesEspera.Enqueue(cliente);
                return true;
            }
            return false;
        }

        public static bool AsignarPuesto() 
        {
            if (ListarPuestosLibresComputadora().Count > 0) 
            {

                Cliente cliente = colaClientesEspera.Peek();

                if (cliente.TipoPuesto == TipoPuesto.COMPUTADORA) 
                {
                    foreach (Computadora item in ListarPuestosLibresComputadora())
                    {
                        if (Puesto.ValidarPuesto(cliente, item))
                        {
                            cliente.Asignacion = item.Identificaficador;
                            item.IniciarSesion();
                            colaClientesEspera.Dequeue();
                            return true;
                        }
                        else 
                        {
                            colaClientesEspera.Dequeue();
                            colaClientesEspera.Enqueue(cliente);
                            break;
                        }
                    }
                }
            }
            return false;
        }

        public static Puesto LiberarPuesto(string identificador) 
        {
            foreach (Computadora item in puestosComputadora)
            {
                if (item.Identificaficador == identificador && item.Estado == Estado.EN_USO) 
                {
                    item.FinalizarSesion();
                    return item;
                }
            }
            return null;
        }

        public static string MostrarFactura(Puesto puesto) 
        {
            StringBuilder sb = new StringBuilder();
            if (puesto is not null) 
            {
                sb.AppendLine($"Inicio -> {puesto.HoraInicio}");
                sb.AppendLine($"Fin -> {puesto.HoraFin}");
                sb.AppendLine($"Costo -> {puesto.CalcularCosto()}");
            }

            return sb.ToString();
        }

        /// <summary>
        /// Genera una nueva lista de puestos libres cada vez que se la invoca.
        /// </summary>
        /// <returns>Lista de puestos en estado LIBRE</returns>
        private static List<Computadora> ListarPuestosLibresComputadora() 
        {
            List<Computadora> listaPuestosLibreComputadora = new List<Computadora>();

            foreach (Computadora item in PuestosComputadora) 
            {
                if (item.Estado == Estado.LIBRE) 
                {
                    listaPuestosLibreComputadora.Add(item);
                }
            }

            return listaPuestosLibreComputadora;
        }


        public string MostrarComputadorasEnUso() 
        {
            StringBuilder sb = new();

            sb.AppendLine("DNI  ---  NOMBRE  ---  APELLIDO  ---  EDAD");

            return sb.ToString();
        }

    }
}
