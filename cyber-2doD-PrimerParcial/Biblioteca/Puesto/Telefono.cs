using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Telefono : Puesto
    {
        private Modelo modeloTelefono;
        private Marca marcaTelefono;
        private TipoPuesto tipoPuesto;
        private int area;
        private int prefijo;
        private int numero;

        public Telefono(string id) : base(id)
        {
            this.tipoPuesto = TipoPuesto.TELEFONO;
        }

        public Telefono(string id, Modelo modeloTelefono, Marca marcaTelefono, int area, int prefijo, int numero)
            : base(id) 
        {
            this.identificaficador = id;
            this.modeloTelefono = modeloTelefono;
            this.marcaTelefono = marcaTelefono;
            this.area = area;
            this.prefijo = prefijo;
            this.numero = numero;
        }

        public Telefono(Modelo modeloTelefono, Marca marcaTelefono, int area, int prefijo, int numero) : this("")
        {
            this.modeloTelefono = modeloTelefono;
            this.marcaTelefono = marcaTelefono;
            this.area = area;
            this.prefijo = prefijo;
            this.numero = numero;
        }

        public override int CalcularDuracion()
        {
            return (int)(horaFin - horaInicio).TotalSeconds;
        }

        public override Double CalcularCosto()
        {
            return ((float)Math.Ceiling(CalcularDuracion() / 30F));
        }
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("CABINA:");
            sb.AppendLine("MODELO_TELEFONO: " + modeloTelefono);
            sb.AppendLine("MARCA_TELEFONO: " + marcaTelefono);
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
