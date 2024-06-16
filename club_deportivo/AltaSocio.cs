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
    public partial class frmAltaSocio : Form
    {
        public frmAltaSocio()
        {
            InitializeComponent();
        }

        private void btnAltaSocio_Click(object sender, EventArgs e)
        {
            int dni = int.Parse(txtDni.Text);
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            ClubDeportivo.AltaSocio(dni, nombre, apellido);
            MessageBox.Show("socio: " + ClubDeportivo.listaSocios[0]);
            MessageBox.Show("El socio se incorporó exitosamente");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDni.Text = ""; 
;           txtNombre.Text = "";
            txtApellido.Text = "";
        }
    }
}
