using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using preparacionp.Clases;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace preparacionp
{
    public partial class Form1 : Form
    {
        IFirebaseConfig Config = new FirebaseConfig()
        {
            AuthSecret = "ZQWlfGXQ3a2OC1WwVIBzkwwFAJMPh04JCzPnTmsB",
            BasePath = "https://parcial-ef1b7-default-rtdb.firebaseio.com/"

        };
        IFirebaseClient client;
        /*Datos temporales los cuales se usaran para ser asignados a las clases */
        private string tipo = "";
        private string placa = "";
        private string marca = "";
        private string cedula = "";
        private string sexo = " ";
        private string afiliado = " ";
        private int horaEntrada;
        private int minutosEntrada;
        private int minutosSalida;
        private int horaSalida;

        public string Tipo { get => tipo; set => tipo = value; }
        public string Placa { get => placa; set => placa = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Afiliado { get => afiliado; set => afiliado = value; }
        public string Cedula { get => cedula; set => cedula = value; }

        Parqueadero parqueadero = new Parqueadero();
        public Form1()
        {
            InitializeComponent();
            client = new FireSharp.FirebaseClient(Config);


        }


        private void administrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Administrar Administrar = new Administrar();
            Administrar.ShowDialog();
        }

        private void afiliarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Afiliar Afiliar = new Afiliar();
            Afiliar.ShowDialog();

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            asignarVariables();
            // Verificar si falta algun valor.
            if (txtCedula.Text == "" || Convert.ToString(cmbSexo.SelectedItem) == "" || Convert.ToString(cmbAfiliado.SelectedItem) == "")

                MessageBox.Show("Faltan datos del Conductor");

            else if (txtPlaca.Text == "" || Convert.ToString(cmbTipo.SelectedItem) == "" || txtMarca.Text == "")

                MessageBox.Show("Faltan datos del Vehiculo ");

            else if (horaEntrada > 23 || minutosEntrada > 59)
            {
                MessageBox.Show("Hora no Valida");
                txtHorasEntrada.Text = "00";
                txtMinutosEntrada.Text = "00";
            }
                
            else if (tipo == "Por definir")
            {
                cmbTipo.SelectedIndex = 4;

            }
            else if (afiliado == "Por establecer")
            {
                cmbAfiliado.SelectedIndex = 3;

            }
            else if (txtHoraDeSalida.Text != "00" || txtMinutosDeSalida.Text != "00")
            {
                MessageBox.Show("La hora de salida solo aplica al retirar un carro");
                txtHoraDeSalida.Text = "00";
                txtMinutosDeSalida.Text = "00";
            }
            else
            {

                Driver d = CrearDriver();

                Vehicle v = CrearVehiculo();

                parqueadero.AgregarCarro(v);

                client.Set("Historia/" + cedula, d);
                client.Update("Historia/" + cedula, v);


                client.Set("ClientesActuales/" + cedula, d);
                client.Set("ClientesActuales/" + Placa, d);

                client.Set("Carros en parqueadero/" + placa, v);
                client.Set("Carros en parqueadero/" + cedula, v);

                MessageBox.Show("Carro Ingresado");
                limpiar();

            }






        }
        private void retirar_Click(object sender, EventArgs e)
        {
            //eliminar de la bs con la cedula que se busco
            // actualizar en el historia que ya no esta en el parqueadero

            // Buscar si existe el servicio que se queire sacar
            //buscar cliente
            FirebaseResponse bucarClienteConCedula = client.Get("ClientesActuales/" + txtCedula.Text);
            Driver driverC = bucarClienteConCedula.ResultAs<Driver>();
            FirebaseResponse buscarClienteConPlaca = client.Get("ClientesActuales/" + txtPlaca.Text);
            Driver driverP = buscarClienteConPlaca.ResultAs<Driver>();

            FirebaseResponse buscarCarrroConCedula = client.Get("Carros en parqueadero/" + txtCedula.Text);
            Vehicle vehicleC = buscarCarrroConCedula.ResultAs<Vehicle>();

            FirebaseResponse buscarCarroConPlaca = client.Get("Carros en parqueadero/" + txtPlaca.Text);
            Vehicle vehicleP = buscarCarroConPlaca.ResultAs<Vehicle>();

            if(driverC == null || driverP == null || vehicleC == null || vehicleP == null)
            {
                MessageBox.Show("No se encuentra vehiculo a retirar verifique si este vehiculo existe en el apartado buscar");
            }
            else
            {
                // Retirar cliente
                FirebaseResponse DriverC = client.Delete("ClientesActuales/" + txtCedula.Text);
                Driver d = DriverC.ResultAs<Driver>();

                FirebaseResponse DriverP = client.Delete("ClientesActuales/" + txtPlaca.Text);
                Driver dr = DriverP.ResultAs<Driver>();

                //Retirar Carro
                FirebaseResponse VehiculoC = client.Delete("Carros en parqueadero/" + txtCedula.Text);
                Vehicle v = VehiculoC.ResultAs<Vehicle>();

                FirebaseResponse VehiculoP = client.Delete("Carros en parqueadero/" + txtPlaca.Text);
                Vehicle ve = VehiculoP.ResultAs<Vehicle>();

                MessageBox.Show("Carro retirado");

            }





            //actualizar la historia donde se encuentra el cliento, donde ahora el carro tenga como estado retirado
            //client.Update("Historia/" + cedula, v);
            // cliente.update("Historia/" + cedula, d);

           
        }
        private Vehicle CrearVehiculo()
        {
            Vehicle v = new Vehicle(tipo, placa, marca, horaEntrada, minutosEntrada, horaSalida, minutosSalida);

            if (v.MinutosSalida == 00)
            {
                v.Estado = "En el parqueadero";

            }
            else
            {
                v.Estado = " Retirado";
            }
            
            return v;

        }
        private Driver CrearDriver()
        {
            Driver d = new Driver(sexo, afiliado, cedula);
            return d;
        }
        public void limpiar()
        {
            txtPlaca.Text = "";
            txtCedula.Text = "";
            txtMarca.Text = "";
            cmbAfiliado.SelectedIndex = 0;
            cmbSexo.SelectedIndex= 0;
            cmbTipo.SelectedIndex = 0;



        }

     


        private void asignarVariables()
        {

            // Valors de pantalla en variables.
            tipo = Convert.ToString(cmbTipo.SelectedItem);
            placa = txtPlaca.Text;
            Marca = txtMarca.Text;
            Cedula = txtCedula.Text;
            afiliado = Convert.ToString(cmbAfiliado.SelectedItem);
            sexo = Convert.ToString(cmbSexo.SelectedItem);

            horaEntrada = int.Parse(txtHorasEntrada.Text);
            minutosEntrada = int.Parse(txtMinutosEntrada.Text);
            horaSalida = int.Parse(txtHoraDeSalida.Text);
            minutosSalida = int.Parse(txtMinutosDeSalida.Text);
        }
        private void buscar()
        {

        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = client.Get("ClientesActuales/" + txtBuscar.Text);
            Driver d = response.ResultAs<Driver>();

            FirebaseResponse respons = client.Get("Carros en parqueadero/" + txtBuscar.Text);
            Vehicle v = respons.ResultAs<Vehicle>();

            if (d != null)
            {
                txtCedula.Text = d.Cedula;
                if (d.Afiliado == "SI")
                {
                    cmbAfiliado.SelectedIndex = 1;
                }
                else
                {
                    cmbAfiliado.SelectedIndex = 2;
                }
                if(d.Sexo == "Hombre")
                {
                    cmbSexo.SelectedIndex = 1;
               
                }
                else
                {
                    cmbSexo.SelectedIndex = 2;
                }

            }
            else
            {
                MessageBox.Show("No se encontro cliente");
            }

            if (v != null)
            {
                txtPlaca.Text = v.Placa;
                txtMarca.Text = v.Marca;
                if (v.Tipo == "Camioneta")
                {
                    cmbTipo.SelectedIndex = 1;
                }
                else if(v.Tipo == "Microbus")
                {
                    cmbTipo.SelectedIndex = 2;
            
                }
                else
                {
                    cmbTipo.SelectedIndex = 3;
                }

             
            }
            else
            {
                MessageBox.Show("No se encontro vehiculo");
            }
        }   



        //public void mostrarCliente()
        //{
        //    // c sera el carro que se busco con el metodo 
        //    foreach (Driver c in parqueadero.CarrosEnParqueadero)
        //    {
        //        // prueba.Text = c.Cedula ;              
        //        c.Cedula = txtMarca.Text;
        //    }

        //}


    }
    
}
