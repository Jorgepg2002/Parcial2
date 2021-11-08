using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace preparacionp.Clases
{
    class Vehicle
    {
        private string cedula;
        private string sexo;
        private string afiliado;
     
       


        public string Cedula { get => cedula; set => cedula = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Afiliado { get => afiliado; set => afiliado = value; }
        
        public Vehicle(string cedula, string sexo, string afiliado)
        {
            Cedula = cedula;
            Sexo = sexo;
            Afiliado = afiliado;
            
            


        }
      


    }
}
