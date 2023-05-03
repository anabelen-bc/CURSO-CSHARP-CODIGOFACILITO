using herencia;

namespace Presentacion7
{ 
class Program
    {
        static void Main(string[] args)
        {
            clsClientesVentas Cliente;
            Cliente = new clsClientesVentas();
            Cliente.IdCliente = 123;
            Cliente.Apellido = "Hernandez Hernandez";
            Cliente.Nombre = "Marcos";
            Cliente.RFC = "HEHM";
            Cliente.Direccion = "Av Tigre 119";
            Cliente.Colonia = "La cueva del jaguar";
            Cliente.Municipio = "Tuxtla Gutierrez";
            Cliente.EsCredito = true;
            Console.WriteLine(Cliente.Apellido + " " + Cliente.Nombre);
            Console.WriteLine(Cliente.Direccion + " " + Cliente.Colonia + " " + Cliente.Municipio);
            Console.WriteLine(Cliente.RFC);
            if (Cliente.EsCredito)
                Console.WriteLine("El cliente tiene credito");
            else
                Console.WriteLine("El cliente no tiene credito");

        }
    }
}