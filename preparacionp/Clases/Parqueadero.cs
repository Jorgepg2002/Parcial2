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

        private int entrada;
        private bool spot1 = true;
        private bool spot2 = true;
        private bool spot3 = true;
        private bool spot4 = true;
        private bool spot5 = true;
        private bool spot6 = true;
        private bool spot7 = true;
        private bool spot8 = true;
        private bool spot19 = true;
        private bool spot10 = true ;

        public void AgregarCarro(Vehicle v)
        {
            carrosEnParqueadero.Add(v);
        }

        public void EliminarCarrro(Vehicle v)
        {
            carrosEnParqueadero.Remove(v);
        }
    }
}
