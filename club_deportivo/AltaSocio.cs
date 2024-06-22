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
    public partial class frmAltaSocio : Form
    {
        public frmAltaSocio()
        {
            InitializeComponent();
        }

        private void btnAltaSocio_Click(object sender, EventArgs e)
        {
            /*int dni = int.Parse(txtDni.Text);*/


            if(txtDni.Text == "" || txtNombre.Text == "" || txtApellido.Text == "")
            {
                MessageBox.Show("Debe completar los datos marcados con *");
            }
            else
            {
                string respuesta;

                //se instancia los getters y setters de la clase E_Socios que se usan en la clase Socios
                E_Socios Soc = new E_Socios();
                Soc.dni_socio = Convert.ToInt32(txtDni.Text);
                Soc.nombre = txtNombre.Text;
                Soc.apellido = txtApellido.Text;

                //Se instancia Socios para llamar al método que dispara el procedure, sino no pasa nada
                Datos.Socios socio = new Datos.Socios();
                respuesta = socio.Nuevo_socio(Soc);

                bool esnumero = int.TryParse(respuesta, out int codigo);

                if(esnumero)
                {
                    if (codigo == 1)
                    {
                        MessageBox.Show("El socio ya existe");
                    }
                    else
                    {
                        MessageBox.Show("El socio se ha agregado exitosamente");
                    }
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDni.Text = ""; 
;           txtNombre.Text = "";
            txtApellido.Text = "";
        }
    }
}
