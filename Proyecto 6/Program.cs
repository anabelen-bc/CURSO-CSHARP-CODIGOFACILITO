using modularizacionYEncapsulamiento;

namespace Presentacion6
{
    class Program
    {
        static void Main(string[] args) 
        {
            clsEmpleados1 empleado;
            empleado = new clsEmpleados1();
            empleado.Edad = 25;
            empleado.Nombre = "Marcos Hernandez";
            empleado.SueldoDiario = 12.5m;
            decimal total;
            total = empleado.CalculaSalario(30);
            Console.WriteLine("El salario mensual del empleado "+ empleado.Nombre);
            Console.WriteLine("Es: " + total.ToString("C"));
            Console.ReadKey();


        }
    }
} //La modularidad nos indica que tenemos que dividir nuestro programa en elementos identificables, y que se puedan utilizar para obtener nuestra solucion. Esta queda cubierta a traves de la creacion de las clases que representan nuestros objetos
//Encapsulamiento(son campos), a traves de los metodos de propiedad, resguadamos las variables internas, y lo encapsulamos 
