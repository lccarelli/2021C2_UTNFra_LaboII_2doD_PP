namespace Biblioteca
{
    public class Espera
    {
        internal Puesto puesto;
        internal TipoPuesto tipoPuesto;


        public Espera(Cliente cliente, TipoPuesto tipoPuesto)
        {
            this.tipoPuesto = tipoPuesto;
        }

        // yo tengo que devolver una espera, y esa espera tiene un metodo Mostrar() que devuelve un string para mostrar en el listBox
        //public static string EsperarComputadora(Cliente cliente, Puesto puesto)
        //{ // string builder para devolver el estring para mostrar en la cola
          //  if (cliente.TipoPuesto == TipoPuesto.COMPUTADORA) 
            //{

            //}
        //}
    }
}