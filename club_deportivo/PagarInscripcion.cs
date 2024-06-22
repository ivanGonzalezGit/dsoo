using System;
using System.Collections.Generic;
using Club_deportivo_EV.Entidades;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Club_deportivo_EV
{
    public partial class frmPagarInscripcion : Form
    {
        public frmPagarInscripcion()
        {
            InitializeComponent();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            /*int dni = int.Parse(txtDni.Text);*/


            if (txtMonto.Text == "" || txtDniSocio.Text == "")
            {
                MessageBox.Show("Debe completar los datos marcados con *");
            }
            else
            {
                string respuesta;

                //se instancia los getters y setters de la clase E_Socios que se usan en la clase Socios
                E_Inscripciones Insc = new E_Inscripciones();
                Insc.monto = Convert.ToInt32(txtMonto.Text);
                Insc.dni_socio  = Convert.ToInt32(txtDniSocio.Text);


                //Se instancia Socios para llamar al método que dispara el procedure, sino no pasa nada
                Datos.Inscripciones Inscripcion = new Datos.Inscripciones();
                respuesta = Inscripcion.NuevaInscripcion(Insc);

                if (int.TryParse(respuesta, out int salidaProcedure))
                {
                    switch (salidaProcedure)
                    {
                        case 0:
                            MessageBox.Show("El socio no existe");
                            break;

                        case 1:
                            MessageBox.Show("Se realizó la inscripción correctamente");
                            break;

                        case 2:
                            MessageBox.Show("Se realizó el pago de la nueva inscripción");
                            break;

                        case 3:
                            MessageBox.Show("El socio ya existe");
                            break;

                        default:
                            MessageBox.Show("Respuesta desconocida");
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Error al procesar la respuesta: " + respuesta);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtMonto.Text = "";
            txtDniSocio.Text = "";
        }
    }
}
