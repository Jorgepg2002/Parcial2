using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace preparacionp.Clases
{
    class Parqueadero
    {
        private List<Vehicle> carrosEnParqueadero = new List<Vehicle>();
        public List<Vehicle> CarrosEnParqueadero { get => carrosEnParqueadero; set => carrosEnParqueadero = value; }


        public void AgregarCarro(Vehicle v)
        {
            carrosEnParqueadero.Add(v);
        }
    }
}
