using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public class Computadora : Puesto
    {
        private const float FRACCION_MINIMA = 0.5F;
        private List<Software> softwares;
        private List<Periferico> perifericos;
        private List<Juego> juegos;

        public List<Software> Softwares { get => softwares; }
        public List<Periferico> Perifericos { get => perifericos; }
        public List<Juego> Juegos { get => juegos; }

        public Computadora(string id) : base(id)
        {
            this.tipoPuesto = TipoPuesto.COMPUTADORA;
            this.softwares = new List<Software>();
            this.perifericos = new List<Periferico>();
            this.juegos = new List<Juego>();

        }

        public Computadora(string id,List<Software> softwares, List<Periferico> perifericos, List<Juego> juegos)
            : base(id)
        {
            this.identificaficador = id;
            this.softwares = softwares;
            this.perifericos = perifericos;
            this.juegos = juegos;
        }

        public Computadora(List<Software> softwares, List<Periferico> perifericos, List<Juego> juegos) : this("")
        {
            this.softwares = softwares;
            this.perifericos = perifericos;
            this.juegos = juegos;
        }



        public override Double CalcularCosto() 
        {
            return 0.6;
        }

        public static bool operator ==(Computadora instalados, Computadora alquiler)
        {
            bool softwareEncontrado = false;
            bool perifericoEncontrado = false;
            bool juegoEncontrado = false;

            foreach (Software item in alquiler.softwares)
            {
                if (EncontrarCaracteristica(instalados, item)) 
                {
                    softwareEncontrado = true;
                }
            }

            foreach (Periferico item in alquiler.perifericos)
            {
                if (EncontrarCaracteristica(instalados, item))
                {
                    perifericoEncontrado = true;
                }
            }

            foreach (Juego item in alquiler.juegos)
            {
                if (EncontrarCaracteristica(instalados, item))
                {
                    juegoEncontrado = true;
                }
            }

            if (softwareEncontrado && perifericoEncontrado && juegoEncontrado) 
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Computadora instalados, Computadora alquiler) 
        {
            return !(instalados == alquiler);
        }

        private static bool EncontrarCaracteristica(Computadora computadores, Software softwareBuscado) 
        {
            foreach (Software item in computadores.softwares)
            {
                if (item == softwareBuscado) 
                {
                    return true;
                }
            }
            return false;
        }

        private static bool EncontrarCaracteristica(Computadora computadores, Periferico perifericoBuscado)
        {
            foreach (Periferico item in computadores.perifericos)
            {
                if (item == perifericoBuscado)
                {
                    return true;
                }
            }
            return false;
        }

        private static bool EncontrarCaracteristica(Computadora computadores, Juego juegoBuscado)
        {
            foreach (Juego item in computadores.juegos)
            {
                if (item == juegoBuscado)
                {
                    return true;
                }
            }
            return false;
        }

        public override sealed string Mostrar() 
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("COMPUTADORA:");
            sb.AppendLine("Softwares intalados:");
            foreach (Software item in softwares)
            {
                sb.AppendLine(item.ToString());
            }

            sb.AppendLine("Perifericos intalados:");
            foreach (Periferico item in perifericos)
            {
                sb.AppendLine(item.ToString());
            }

            sb.AppendLine("Juegos intalados:");
            foreach (Juego item in juegos)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("---------------------");

            return sb.ToString();
        } 

    }
}
