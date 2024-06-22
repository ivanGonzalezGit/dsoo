using Club_deportivo_EV.Entidades;
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

        internal string? nomAdministrador;
        private void Form2_Load(object sender, EventArgs e)
        {
            lblNombreAdmin.Text = nomAdministrador.ToUpper();
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPagarInscripcion_Click(object sender, EventArgs e)
        {
            frmPagarInscripcion pagarInscripcion = new frmPagarInscripcion();
            pagarInscripcion.Show();

        }

        private void btnPagarCuota_Click(object sender, EventArgs e)
        {
            frmPagarCuota pagarCuota = new frmPagarCuota();
            pagarCuota.Show();
        }
    }
}
