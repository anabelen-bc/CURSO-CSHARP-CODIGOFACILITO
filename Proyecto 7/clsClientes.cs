using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia
{
    public class clsClientes
    {
        private int _idCliente;
        public int IdCliente
        {
            get {return  _idCliente; }
            set { _idCliente = value; }
        }
        private string _Nombre;
        public string Nombre 
        {
            get { return _Nombre; }
            set { _Nombre = value; } 
        }
        private string _Apellido;
        public string Apellido 
        { 
            get { return _Apellido; }
            set { _Apellido = value; } 
        }



    }
}
