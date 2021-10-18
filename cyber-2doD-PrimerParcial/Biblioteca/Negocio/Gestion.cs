using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public abstract class Gestion
    {
        protected List<Computadora> puestosComputadora;
        protected List<Telefono> puestosTelefono;
        protected Queue<Espera> colaEsperaComputadora;
        protected Queue<Espera> colaEsperaTelefono;

        public List<Computadora> PuestosComputadora { get => puestosComputadora; set => puestosComputadora = value; }
        public List<Telefono> PuestosTelefono { get => puestosTelefono; set => puestosTelefono = value; }
        public Queue<Espera> ColaEsperaComputadora { get => colaEsperaComputadora; set => colaEsperaComputadora = value; }
        public Queue<Espera> ColaEsperaTelefono { get => colaEsperaTelefono; set => colaEsperaTelefono = value; }

        private Gestion()
        {
            this.puestosComputadora = new List<Computadora>();
            this.puestosTelefono = new List<Telefono>();
            this.colaEsperaComputadora = new Queue<Espera>();
            this.colaEsperaTelefono = new Queue<Espera>();
        }

        public Gestion(List<Computadora> puestosComputadora, List<Telefono> puestosTelefono)
        {
            PuestosComputadora = puestosComputadora;
            PuestosTelefono = puestosTelefono;
        }

        public static bool operator +(Gestion gestion, Cliente cliente)
        {
            //primero tengo que chequear que haya una computadora con las caracteristicas
            //luego fijarme si esta disponible o no
            //luego asignarle o ponerlo en espera
            if (cliente.TipoPuesto == TipoPuesto.COMPUTADORA)
            {
                foreach (Computadora item in gestion.PuestosComputadora)
                {
                    if (cliente.computadora == item) // && chequear estado 
                    {
                        gestion.colaEsperaComputadora.Enqueue(new Espera(cliente, TipoPuesto.COMPUTADORA));
                    }
                }

            }
            return false;
        }

        public static bool operator -(Gestion gestion, Cliente cliente)
        {
            return false;
        }




        public string MostrarComputadorasEnUso() 
        {
            StringBuilder sb = new();

            sb.AppendLine("DNI  ---  NOMBRE  ---  APELLIDO  ---  EDAD");

            return sb.ToString();
        }

    }
}
