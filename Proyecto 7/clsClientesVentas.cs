using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace herencia
{
    public class clsClientesVentas : clsClientes //Hereda las propiedades
    {
        private string _RFC;
        public string RFC { get => _RFC; set => _RFC = value; }

        private string _Direccion;
        public string Direccion { get => _Direccion; set => _Direccion = value; }

        private string _Colonia;
        public string Colonia { get => _Colonia; set => _Colonia = value; } 

        private string _Municipio;
        public string Municipio { get => _Municipio; set => _Municipio = value; }

        private bool _EsCredito; 
        public bool EsCredito { get => _EsCredito; set => _EsCredito = value; }
    }
}
