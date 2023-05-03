namespace modularizacionYEncapsulamiento
{
    public class clsEmpleados1 
    {
        public clsEmpleados1()
    {
        Nombre = "";
        SueldoDiario = 0.0m;
        Edad = 0;
    }

    private string _Nombre;

    public string Nombre
    {
        get { return Nombre1; }
        set { Nombre1 = value; }
    }

        public string Nombre1 { get => _Nombre; set => _Nombre = value; 
       }

        public decimal SueldoDiario { get; set; }
        public int Edad { get; set; }

        public decimal CalculaSalario(int NumeroDias)
        {
            return SueldoDiario * NumeroDias;
        }

    }
}
