using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public class Cliente
    {
        private string nombre;
        private string apellido;
        private int dni;
        private int edad;
        private TipoPuesto tipoPuesto;
        private Computadora computadora;
        public Telefono telefono;
        private string asignacion;

        private static Dictionary<string, Periferico> mapaPeriferico;
        private static Dictionary<string, Software> mapaSoftware;
        private static Dictionary<string, Juego> mapaJuego;

        static Cliente()
        {
            mapaSoftware = new Dictionary<string, Software>()
            { { "Office", Software.OFFICE }, { "Messenger", Software.MESSENGER }, { "Icq", Software.ICQ }, { "Ares", Software.ARES } };
            mapaPeriferico = new Dictionary<string, Periferico>()
            { { "Camara", Periferico.CAMARA }, { "Microfono", Periferico.MICROFONO }, { "Auriculares", Periferico.AURICULARES} };
            mapaJuego = new Dictionary<string, Juego>()
            { { "Diablo II", Juego.DIABLO }, { "Counter Strike", Juego.COUNTER_STRIKE }, { "Lineage II", Juego.LINEAGE} };
        }

        public Cliente(
                        string nombre,
                        string apellido,
                        string strDNI,
                        decimal dEdad,
                        List<string> softwares,
                        List<string> perifericos,
                        List<string> juegos,
                        TipoPuesto tipoPuesto,
                        string asignacion
            )
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = validarDNI(strDNI);
            this.edad = (int)dEdad;
            this.computadora = new Computadora(ValidarSoftware(softwares), ValidarPeriferico(perifericos), ValidarJuego(juegos));
            this.TipoPuesto = tipoPuesto;
            this.asignacion = asignacion;
        }

        public Cliente(
                string nombre,
                string apellido,
                string strDNI,
                decimal dEdad,
                Telefono telefono, 
                TipoPuesto tipoPuesto,
                string asignacion
    )
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = validarDNI(strDNI);
            this.edad = (int)dEdad;
            this.telefono = telefono;
            this.TipoPuesto = tipoPuesto;
            this.asignacion = asignacion;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Dni { get => dni; set => dni = value; }
        public int Edad { get => edad; set => edad = value; }
        public TipoPuesto TipoPuesto { get => tipoPuesto; set => tipoPuesto = value; }
        public string Asignacion { get => asignacion; set => asignacion = value; }
        public Computadora Computadora { get => computadora; }

        public static bool operator ==(Cliente cliente1, Cliente cliente2)
        {
            if (cliente1 is not null && cliente2 is not null) 
            {
                return cliente1.Dni == cliente2.Dni;
            }

            return false;
        }

        public static bool operator !=(Cliente cliente1, Cliente cliente2)
        {
            return !(cliente1 == cliente2);
        }

        private static List<Software> ValidarSoftware(List<string> software) 
        {
            List<Software> listaSoftware = new List<Software>();

            if (software is not null) 
            {
                foreach (string item in software)
                {
                    listaSoftware.Add(mapaSoftware.GetValueOrDefault(item));
                }
            }
            return listaSoftware;
        }

        private static List<Periferico> ValidarPeriferico(List<string> periferico)
        {
            List<Periferico> listaPeriferico = new List<Periferico>();

            if (periferico is not null)
            {
                foreach (string item in periferico)
                {
                    listaPeriferico.Add(mapaPeriferico.GetValueOrDefault(item));
                }
            }
            return listaPeriferico;
        }

        private static List<Juego> ValidarJuego(List<string> juego)
        {
            List<Juego> listaJuegos = new List<Juego>();

            if (juego is not null)
            {
                foreach (string item in juego)
                {
                    listaJuegos.Add(mapaJuego.GetValueOrDefault(item));
                }
            }
            return listaJuegos;
        }


        private int validarDNI(string strDNI) 
        {
            return !int.TryParse(strDNI, out int dni) || strDNI is null ? 0 : dni;
        }

        public static string Mostrar(Cliente cliente) 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}, {1} -> Puesto: {2}", cliente.Apellido, cliente.Nombre, cliente.TipoPuesto);
            return sb.ToString();
        }

        public override bool Equals(Object obj)
        {
            Cliente cliente = obj as Cliente;
            return cliente != null && this == cliente;
        }

        /// <summary>
        /// Sobrecarga del metodo GetHashCode()
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return asignacion.GetHashCode();
        }
    }
}
