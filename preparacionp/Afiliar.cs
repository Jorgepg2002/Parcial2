using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace preparacionp
{
    public partial class Afiliar : Form
    {
        public Afiliar()
        {
            InitializeComponent();
        }

        private void ingresoYRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 IngresosYRetiro = new Form1();
            IngresosYRetiro.ShowDialog();
        }

        private void administrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Administrar Administrar = new Administrar();
            Administrar.ShowDialog();

        }
    }
}
