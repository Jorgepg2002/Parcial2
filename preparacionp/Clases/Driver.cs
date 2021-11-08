using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace preparacionp.Clases
{
    class Driver
    {
        private string sexo;
        private string afiliado;
        private string cedula;

       
        public string Afiliado { get => afiliado; set => afiliado = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Cedula { get => cedula; set => cedula = value; }

        public Driver(string Sexo, string Afiliado, string Cedula)
        {
            sexo = Sexo;
            afiliado = Afiliado;
            cedula = Cedula;
        }
    }
}
