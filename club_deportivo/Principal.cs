using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Club_deportivo_EV
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnAltaSocio_Click(object sender, EventArgs e)
        {

            Form altaSocio = new frmAltaSocio();
            altaSocio.Show();
        }

        private void btnListarMorosos_Click(object sender, EventArgs e)
        {
            Form listaMorosos = new frmListadoMorosos();
            listaMorosos.Show();
        }

        private void btnListarSocios_Click(object sender, EventArgs e)
        {
            Form listaSocios = new frmListadoSocios();
            listaSocios.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form listaActividades = new frmListadoActividades();
            listaActividades.Show();
        }
    }
}
