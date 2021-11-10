using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace preparacionp.Clases
{
    class Vehicle
    {
        private string tipo;
        private string placa;
        private string marca;
        private int horaEntrada;
        private int minutosEntrada;
        private int horaSalida;
        private int minutosSalida;
        private string estado;
     

        public int HoraEntrada { get => horaEntrada; set => horaEntrada = value; }
        public int MinutosEntrada { get => minutosEntrada; set => minutosEntrada = value; }
        public int MinutosSalida { get => minutosSalida; set => minutosSalida = value; }
        public int HoraSalida { get => horaSalida; set => horaSalida = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Placa { get => placa; set => placa = value; }
        public string Marca { get => marca; set => marca = value; }

        Form1 p = new Form1();

        public Vehicle(string Tipo, string Placa, string Marca, int horaDeEntrada, int minutosDeEntrada, int horaDeSalida, int minutosDeSalida)
        {
            this.Tipo = Tipo;
            this.Placa = Placa;
            this.Marca = Marca;
            HoraEntrada = horaDeEntrada;
            MinutosEntrada = minutosDeEntrada;
            HoraSalida = horaDeSalida;
            MinutosSalida = minutosDeSalida;

        }

       
    }
}
