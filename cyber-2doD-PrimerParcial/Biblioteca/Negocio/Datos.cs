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

        public static List<Puesto> GenerarPuestosComputadora() 
        {
            return new List<Puesto>
            {
                new Computadora(
                    Indexador.C01_001.ToString(),
                    new List<Software>(){ Software.OFFICE },
                    new List<Periferico>(){ Periferico.AURICULARES },
                    new List<Juego>(){ Juego.LINEAGE }
                    ),
                new Computadora(
                    Indexador.C02_001.ToString(),
                    new List<Software>(){ Software.ARES },
                    new List<Periferico>(){ Periferico.MICROFONO },
                    new List<Juego>(){ Juego.DIABLO }
                    ),
                new Computadora(
                    Indexador.C03_001.ToString(),
                    new List<Software>(){ Software.OFFICE },
                    new List<Periferico>(){ Periferico.AURICULARES },
                    new List<Juego>(){ Juego.LINEAGE }
                    ),
                new Computadora(
                    Indexador.C04_001.ToString(),
                    new List<Software>(){ Software.ARES },
                    new List<Periferico>(){ Periferico.MICROFONO },
                    new List<Juego>(){ Juego.DIABLO }
                    ),
                new Computadora(
                    Indexador.C05_001.ToString(),
                    new List<Software>(){ Software.OFFICE },
                    new List<Periferico>(){ Periferico.AURICULARES },
                    new List<Juego>(){ Juego.LINEAGE }
                    ),
                new Computadora(
                    Indexador.C06_001.ToString(),
                    new List<Software>(){ Software.ARES },
                    new List<Periferico>(){ Periferico.MICROFONO },
                    new List<Juego>(){ Juego.DIABLO }
                    ),
                new Computadora(
                    Indexador.C07_001.ToString(),
                    new List<Software>(){ Software.OFFICE },
                    new List<Periferico>(){ Periferico.AURICULARES },
                    new List<Juego>(){ Juego.LINEAGE }
                    ),
                new Computadora(
                    Indexador.C08_001.ToString(),
                    new List<Software>(){ Software.ARES },
                    new List<Periferico>(){ Periferico.MICROFONO },
                    new List<Juego>(){ Juego.DIABLO }
                    ),
                new Computadora(
                    Indexador.C09_001.ToString(),
                    new List<Software>(){ Software.OFFICE },
                    new List<Periferico>(){ Periferico.AURICULARES },
                    new List<Juego>(){ Juego.LINEAGE }
                    ),
                new Computadora(
                    Indexador.C10_001.ToString(),
                    new List<Software>(){ Software.ARES },
                    new List<Periferico>(){ Periferico.MICROFONO },
                    new List<Juego>(){ Juego.DIABLO }
                    )
            };
        }

        public static List<Cliente> GenerarListaClientes()
        {
            return new List<Cliente>()
            {
                new Cliente(
                    "Sherlock",
                    "Holmes",
                    "305678345",
                    23,
                    new List<string>(){ "ARES"}, 
                    new List<string>(){ "MICROFONO" },
                    new List<string>(){ "DIABLO" },
                    TipoPuesto.COMPUTADORA
                    ),
                new Cliente(
                    "Joan",
                    "Watson",
                    "3265789",
                    21,
                    new List<string>(){ "OFFICE"}, 
                    new List<string>(){ "CAMARA" },
                    new List<string>(){ "LINEAGE" },
                    TipoPuesto.COMPUTADORA
                    ),
                new Cliente(
                    "Mycroft",
                    "Holmes",
                    "27568975",
                    20,
                    new List<string>(){ "MESSENGER"}, 
                    new List<string>(){ "MICROFONO" },
                    new List<string>(){ "COUNTER_STRIKE" },
                    TipoPuesto.COMPUTADORA
                    ),
                new Cliente(
                    "Daria",
                    "Morgendorffer",
                    "204567896",
                    35,
                    new List<string>(){ "ICQ"}, 
                    new List<string>(){ "CAMARA" },
                    new List<string>(){ "LINEAGE" },
                    TipoPuesto.COMPUTADORA
                    ),
                new Cliente( 
                    "Ozzy", 
                    "Osbourne", 
                    "45678987", 
                    25,                    
                    new List<string>(){ "ARES"}, 
                    new List<string>(){ "AURICULARES" },
                    new List<string>(){ "LINEAGE" },
                    TipoPuesto.COMPUTADORA
                    ),
                new Cliente( 
                    "Robert", 
                    "Plant", 
                    "34567876", 
                    27,                     
                    new List<string>(){ "OFFICE" }, 
                    new List<string>(){ "CAMARA" },
                    new List<string>(){ "DIABLO" },
                    TipoPuesto.COMPUTADORA
                    ),
                new Cliente( 
                    "Jimmy", 
                    "Page", 
                    "31567345", 
                    28,
                    new List<string>(){ "OFFICE", "MESSENGER" },
                    new List<string>(){ "CAMARA" },
                    new List<string>(){ "DIABLO" },
                    TipoPuesto.COMPUTADORA
                    ),
                new Cliente( 
                    "John", 
                    "Bonham", 
                    "29457295", 
                    26,
                    new List<string>(){ "ARES", "MESSENGER" },
                    new List<string>(){ "CAMARA" },
                    new List<string>(){ "DIABLO" },
                    TipoPuesto.COMPUTADORA
                    ),
                new Cliente( 
                    "John Paul", 
                    "Jones", 
                    "34567153", 
                    22,
                    new List<string>(){ "ARES", "MESSENGER" },
                    new List<string>(){ "CAMARA" },
                    new List<string>(){ "DIABLO" },
                    TipoPuesto.COMPUTADORA
                     ),
                new Cliente( 
                    "Phil", 
                    "Collins", 
                    "35916836", 
                    21,
                    new List<string>(){ "OFFICE", "MESSENGER" },
                    new List<string>(){ "CAMARA", "MICROFONO" },
                    new List<string>(){ "DIABLO", "LINEAGE" },
                    TipoPuesto.COMPUTADORA
                    )
            };
        }
    }
}
