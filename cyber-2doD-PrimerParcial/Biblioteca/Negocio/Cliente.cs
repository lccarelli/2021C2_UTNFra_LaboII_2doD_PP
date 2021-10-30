
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
        public Computadora computadora;

        public Cliente(
                        string nombre, 
                        string apellido, 
                        string strDNI, 
                        decimal dEdad, 
                        List<string> softwares, 
                        List<string> perifericos, 
                        List<string> juegos, 
                        TipoPuesto tipoPuesto
            )
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = validarDNI(strDNI);
            this.edad = (int)dEdad;
            this.computadora = new Computadora(ValidarSoftware(softwares), ValidarPeriferico(perifericos), ValidarJuego(juegos));
            this.TipoPuesto = tipoPuesto;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Dni { get => dni; set => dni = value; }
        public int Edad { get => edad; set => edad = value; }
        public TipoPuesto TipoPuesto { get => tipoPuesto; set => tipoPuesto = value; }

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

        private List<Software> ValidarSoftware(List<string> software) 
        {
            List<Software> lista = new List<Software>();
            Dictionary<string, Software> mapaSoftware = new Dictionary<string, Software>() 
            { { "Office", Software.OFFICE }, { "Messenger", Software.MESSENGER }, { "Ares", Software.ARES}, { "Icq", Software.ICQ} };
            if (software is not null) 
            {
                foreach (string item in software)
                {
                    lista.Add(mapaSoftware.GetValueOrDefault(item));
                }
            }
            return lista;
        }

        private List<Periferico> ValidarPeriferico(List<string> periferico)
        {
            List<Periferico> lista = new List<Periferico>();
            Dictionary<string, Periferico> mapaPeriferico = new Dictionary<string, Periferico>()
            { { "Camara", Periferico.CAMARA }, { "Microfono", Periferico.MICROFONO }, { "Auriculares", Periferico.AURICULARES} };
            if (periferico is not null)
            {
                foreach (string item in periferico)
                {
                    lista.Add(mapaPeriferico.GetValueOrDefault(item));
                }
            }
            return lista;
        }

        private List<Juego> ValidarJuego(List<string> juego)
        {
            List<Juego> lista = new List<Juego>();
            Dictionary<string, Juego> mapaJuego = new Dictionary<string, Juego>()
            { { "Diablo II", Juego.DIABLO }, { "Counter Strike", Juego.COUNTER_STRIKE }, { "Lineage II", Juego.LINEAGE}, { "Sims", Juego.SIMS} };
            if (juego is not null)
            {
                foreach (string item in juego)
                {
                    lista.Add(mapaJuego.GetValueOrDefault(item));
                }
            }
            return lista;
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
    }
}
