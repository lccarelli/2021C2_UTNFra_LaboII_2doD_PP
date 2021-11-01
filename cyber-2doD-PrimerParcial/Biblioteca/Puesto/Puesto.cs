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

        public TipoPuesto TipoPuesto { get => tipoPuesto; set => tipoPuesto = value; }
        public Estado Estado { get => estado; set => estado = value; }
        public DateTime HoraInicio { get => horaInicio; set => horaInicio = value; }
        public DateTime HoraFin { get => horaFin; set => horaFin = value; }
        public string Identificaficador { get => identificaficador; set => identificaficador = value; }

        public Puesto(string identificador, string identificaficador = null)
        {
            this.identificaficador = identificador;
            this.estado = Estado.LIBRE;
            this.identificaficador = identificaficador;
        }

        public void IniciarSesion()
        {
            this.estado = Estado.EN_USO;
            this.horaInicio = DateTime.Now;
        }

        public void FinalizarSesion()
        {
            this.estado = Estado.LIBRE;
            this.horaFin = DateTime.Now;
        }

        public abstract int CalcularDuracion();
        public abstract Double CalcularCosto();

        public static bool operator ==(Puesto puesto1, Puesto puesto2)
        {
            return puesto1.identificaficador == puesto2.identificaficador ? true : false;
        }

        public static bool operator !=(Puesto puesto1, Puesto puesto2)
        {
            return !(puesto1 == puesto2);
        }

        public static bool ValidarPuesto(Cliente cliente, Computadora computadora) 
        {
            if (cliente is not null && computadora is not null) 
            {
                if (cliente.Computadora == computadora) 
                {
                    return true;
                }
            }
            return false;
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

        public override bool Equals(Object obj)
        {
            Puesto puesto = obj as Puesto;
            return puesto != null && this == puesto;
        }

        /// <summary>
        /// Sobrecarga del metodo GetHashCode()
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return identificaficador.GetHashCode();
        }

    }
}
