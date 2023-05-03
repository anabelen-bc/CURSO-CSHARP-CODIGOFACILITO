using clasesAbstractas;

namespace Presentacion8
{
    class Program
    {
        static void Main(string[] args) 
        {
            clsClientesConContacto cliente = new clsClientesConContacto(0, "Marcos Hernandez", "001", "HEHM", 1, "Marcos Hernandez", "254584", "45233687", "mh@hotmail.com", "Av tigre","145", "458", "La cueva", "Tuxtla", "Chiaps", "1619");
        
            Console.Write(cliente.Clave + " " + cliente.Nombre);
            Console.WriteLine(cliente.TipoRegimen);
            Console.WriteLine(cliente.RFC);
            Console.ReadKey();
        }
    }
}//Clases abstractas no se pueden instanciar - solo decimos las propiedades que va a tener esa y otras clases(estructura base)