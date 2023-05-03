namespace Presentacion4
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = 0, valor1 = 0;
            string cadena;
            Console.WriteLine("Dame el primer valor: "); //Se le pide numeros al usurio
            cadena = Console.ReadLine(); //Se leen los numeros que el usuario ingreso y se lo asigna a nuestra variable
            valor = Convert.ToInt32(cadena);
            Console.WriteLine("Dame el segundo valor: ");
            cadena = Console.ReadLine();
            valor1 = Convert.ToInt32(cadena);
            if (valor <= valor1)
                if (valor == valor1)
                {
                    Console.WriteLine("Son los dos valores iguales");
                } else
                {
                    Console.WriteLine("El valor1 es mayor");
                } else
            {
                Console.WriteLine("Valor es mayor");
            }
            Console.ReadKey();
        }
    }
}