
namespace Presentacion2
{
    class Program
    { 
static void Main (string[] args)
{
    int i = 0; //Entero 
    decimal num = 0.0m; //Decimal 
    float num1 = 0.0F; //Decimal
    double num2 = 0.0D; //Decimal
    string cadena = "cadena de texto";
    bool bandera = false; //Valores boleanos true o false 
    DateTime fecha = DateTime.MinValue; //Guarda la fecha o la hora
    Console.WriteLine("El valor de i es: {0}", i);
    Console.WriteLine("El valor de num es: {0:C}", num); ;
    Console.WriteLine("El valor de num1 es: {0:f2}", num1);
    Console.WriteLine("El valor de num2 es: {0:f2}", num2);
    Console.WriteLine("El valor de cadena es: " + cadena);
    Console.WriteLine("El valor de bandera es: " + bandera.ToString());
    Console.WriteLine("El valor de fecha es: " + fecha.ToShortDateString());
    Console.ReadKey();

}
    }
}
