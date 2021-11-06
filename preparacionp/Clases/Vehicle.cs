using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace preparacionp.Clases
{
    class Vehicle
    {
        private string Tipo;
        private string Placa;
        private string Marca;
        private string Dueno;

        
        public Vehicle(string tipo, string placa, string marca, string dueno)
        {
            Tipo = tipo;
            Placa = placa;
            Marca = marca;
            Dueno = dueno;
        }

        public void mostrar()
        {

        }
    }
}
