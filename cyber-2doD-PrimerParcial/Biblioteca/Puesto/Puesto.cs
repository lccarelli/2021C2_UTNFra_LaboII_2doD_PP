using System;
using System.Text;


namespace Biblioteca
{
    public abstract class Puesto
    {
        protected string identificaficador;
        protected DateTime horaInicio;
        protected DateTime horaFin;
        protected TipoPuesto tipoPuesto;
        protected Estado estado;

        public Puesto(string identificador) 
        {
            this.identificaficador = identificador;
        }

        private void IniciarSesion()
        {
            this.estado = Estado.EN_USO;
            this.horaInicio = DateTime.Now;
        }

        private void FinalizarSesion()
        {
            this.estado = Estado.LIBRE;
            this.horaFin = DateTime.Now;
        }

        public abstract Double CalcularCosto();

        public static bool operator ==(Puesto puesto1, Puesto puesto2)
        {
            return puesto1.identificaficador == puesto2.identificaficador ? true : false;
        }

        public static bool operator !=(Puesto puesto1, Puesto puesto2)
        {
            return !(puesto1 == puesto2);
        }

        /// <summary>
        /// Convierte un objeto de tipo Espacio a tipo string
        /// </summary>
        /// <param name="p"></param>
        public static explicit operator string(Puesto puesto)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("ID: {0}\r\n", puesto.identificaficador);
            //sb.AppendFormat("TIPO : {0}\r\n", puesto.tipo);
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        /// <summary>
        /// Publica todos los datos del Espacio.
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            return (string)this;
        }

    }
}
