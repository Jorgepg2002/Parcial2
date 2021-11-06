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
    public partial class Administrar : Form
    {
        public Administrar()
        {
            InitializeComponent();
        }

        private void ingresosYRetirosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 IngresosYRetiros = new Form1();
            IngresosYRetiros.ShowDialog();
        }

        private void afiliarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Afiliar Afiliar = new Afiliar();
            Afiliar.ShowDialog();

        }
    }
}
