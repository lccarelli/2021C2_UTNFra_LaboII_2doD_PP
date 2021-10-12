using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Datos
    {
        public enum Indexador
        {
            C01_001,
            C02_001,
            C03_001,
            C04_001,
            C05_001,
            C06_001,
            C07_001,
            C08_001,
            C09_001,
            C10_001
        }

        public List<Computadora> datoListaComputadoras() 
        {
            return new List<Computadora>
            {
                new Computadora(
                    Indexador.C01_001.ToString(),
                    new List<Computadora.Software>(){ Computadora.Software.OFFICE },
                    new List<Computadora.Periferico>(){ Computadora.Periferico.AURICULARES },
                    new List<Computadora.Juego>(){ Computadora.Juego.LINEAGE }
                    ),
                new Computadora(
                    Indexador.C02_001.ToString(),
                    new List<Computadora.Software>(){ Computadora.Software.ARES },
                    new List<Computadora.Periferico>(){ Computadora.Periferico.MICROFONO },
                    new List<Computadora.Juego>(){ Computadora.Juego.DIABLO }
                    ),
                new Computadora(
                    Indexador.C03_001.ToString(),
                    new List<Computadora.Software>(){ Computadora.Software.OFFICE },
                    new List<Computadora.Periferico>(){ Computadora.Periferico.AURICULARES },
                    new List<Computadora.Juego>(){ Computadora.Juego.LINEAGE }
                    ),
                new Computadora(
                    Indexador.C04_001.ToString(),
                    new List<Computadora.Software>(){ Computadora.Software.ARES },
                    new List<Computadora.Periferico>(){ Computadora.Periferico.MICROFONO },
                    new List<Computadora.Juego>(){ Computadora.Juego.DIABLO }
                    ),
                new Computadora(
                    Indexador.C05_001.ToString(),
                    new List<Computadora.Software>(){ Computadora.Software.OFFICE },
                    new List<Computadora.Periferico>(){ Computadora.Periferico.AURICULARES },
                    new List<Computadora.Juego>(){ Computadora.Juego.LINEAGE }
                    ),
                new Computadora(
                    Indexador.C06_001.ToString(),
                    new List<Computadora.Software>(){ Computadora.Software.ARES },
                    new List<Computadora.Periferico>(){ Computadora.Periferico.MICROFONO },
                    new List<Computadora.Juego>(){ Computadora.Juego.DIABLO }
                    ),
                new Computadora(
                    Indexador.C07_001.ToString(),
                    new List<Computadora.Software>(){ Computadora.Software.OFFICE },
                    new List<Computadora.Periferico>(){ Computadora.Periferico.AURICULARES },
                    new List<Computadora.Juego>(){ Computadora.Juego.LINEAGE }
                    ),
                new Computadora(
                    Indexador.C08_001.ToString(),
                    new List<Computadora.Software>(){ Computadora.Software.ARES },
                    new List<Computadora.Periferico>(){ Computadora.Periferico.MICROFONO },
                    new List<Computadora.Juego>(){ Computadora.Juego.DIABLO }
                    ),
                new Computadora(
                    Indexador.C09_001.ToString(),
                    new List<Computadora.Software>(){ Computadora.Software.OFFICE },
                    new List<Computadora.Periferico>(){ Computadora.Periferico.AURICULARES },
                    new List<Computadora.Juego>(){ Computadora.Juego.LINEAGE }
                    ),
                new Computadora(
                    Indexador.C10_001.ToString(),
                    new List<Computadora.Software>(){ Computadora.Software.ARES },
                    new List<Computadora.Periferico>(){ Computadora.Periferico.MICROFONO },
                    new List<Computadora.Juego>(){ Computadora.Juego.DIABLO }
                    )
            };
        }

        public List<Cliente> datosListaClientes() 
        {
            return new List<Cliente>()
            {
                new Cliente( "Sherlock", "Holmes", "305678345", 23),
                new Cliente( "Joan", "Watson", "3265789", 21),
                new Cliente( "Mycroft", "Holmes", "27568975", 20),
                new Cliente( "Daria", "Morgendorffer", "204567896", 35),
                new Cliente( "Ozzy", "Osbourne", "45678987", 25),
                new Cliente( "Robert", "Plant", "34567876", 27),
                new Cliente( "Jimmy", "Page", "31567345", 28),
                new Cliente( "John", "Bonham", "29457295", 26),
                new Cliente( "John Paul", "Jones", "34567153", 22),
                new Cliente( "Phil", "Collins", "35916836", 21),
            };
        }
    }
}
