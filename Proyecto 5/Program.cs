using objetosYClases;

namespace Presentacion5
{
    class Program
    {
        static void Main(string[] args)
        {
            clsEmpleados empleado;
            empleado = new clsEmpleados(); //Instanciacion
            empleado.Edad = 25;
            empleado.Nombre = "Marcos Hernandez";
            empleado.SueldoDiario = 12.5m;
            decimal total;
            total = empleado.CalculaSalario(30);
            Console.WriteLine("El salario mensual del empleado es " + empleado.Nombre);
            Console.WriteLine("Es: " + total.ToString("C"));
            Console.ReadKey();
        }
    }
}