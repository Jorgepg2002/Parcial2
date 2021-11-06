using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace preparacionp.Clases
{
    class Driver
    {
        private int Cedula;
        private string Sexo;
        private string Afiliado;
        private Vehicle Carro = null;

        Form1 p = new Form1();
        public Driver(int cedula, string sexo, string afiliado)
        {
            Cedula = cedula;
            Sexo = sexo;
            Afiliado = afiliado;
            Carro = new Vehicle(p.Tipo,p.Placa,p.Marca,p.Dueno);

        }
    }
}
