namespace Presentacion3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            float x = 12.2f;
            bool bandera = false;
            // string cadena = string.Empty(es cuando decimos que la variable cadena esta vacia);
            string cadena = "1234";
            DateTime fecha = DateTime.MinValue;
            //x = i; //Conversion implicita - no se especificaron los tipos.
            i = (int)x; //Conversion explicita, a traves de case, ya que si no le indicamos en que queremos convertir el dato, no se va a poder.
            i = Convert.ToInt32(bandera);
            i = Convert.ToInt32(cadena); //Cuando el string son numeros si podemos pasarlo a la variable de i, de lo contrario no se podria    
            Console.WriteLine("El valor de i es: {0}", i);
            Console.WriteLine("El valor de x es: {0:c}", x);
            Console.WriteLine("El valor de bandera es: " + bandera.ToString());
            Console.WriteLine("El valor de cadena es: "+ cadena);
            Console.WriteLine("El valor de fecha es: " + fecha.ToShortDateString());
            Console.ReadKey();
        }
    }
}