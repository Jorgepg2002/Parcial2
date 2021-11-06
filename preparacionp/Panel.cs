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
namespace preparacionp
{
    public partial class Form1 : Form
    {

        private string tipo = "";
        private string placa = "";
        private string marca = "";
        private string dueno = " ";// cedula para driver
        public string Tipo { get => tipo; set => tipo = value; }
        public string Placa { get => placa; set => placa = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Dueno { get => dueno; set => dueno = value; }

        public Form1()
        {
            InitializeComponent();
            

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
    }
    
}
