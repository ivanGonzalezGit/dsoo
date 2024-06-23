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
using DisenioLogin.Datos;
using MySql.Data.MySqlClient;
using Club_deportivo_EV.Datos;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Club_deportivo_EV
{
    public partial class frmPagarInscripcion : Form
    {
        public frmPagarInscripcion()
        {
            InitializeComponent();
        }

        frmImprimir imprimir = new frmImprimir();

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

                //se instancia los getters y setters de la clase E_Inscripciones que se usan en la clase Inscripciones
                E_Inscripciones Insc = new E_Inscripciones();
                Insc.monto = Convert.ToInt32(txtMonto.Text);
                Insc.dni_socio  = Convert.ToInt32(txtDniSocio.Text);

                //Se instancia Inscripciones para llamar al método que dispara el procedure, sino no pasa nada
                Datos.Inscripciones Inscripcion = new Datos.Inscripciones();
                respuesta = Inscripcion.NuevaInscripcion(Insc);

                if (int.TryParse(respuesta, out int salidaProcedure))
                {
                    switch (salidaProcedure)
                    {
                        case 0:
                            MessageBox.Show("El socio no existe");
                            this.Close();
                            break;

                        case 1:
                            MessageBox.Show("Se realizó la inscripción correctamente");

                            MySqlConnection sqlCon = new MySqlConnection();
                            try
                            {
                                string query;
                                sqlCon = Conexion.getInstancia().CrearConexion();

                                query = "select i.n_inscrip, s.nombre, s.apellido, i.f_pago, i.f_vto, i.monto from inscripciones as i inner join socios as s where s.dni = " + txtDniSocio.Text + ";";

                                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                                comando.CommandType = CommandType.Text;
                                sqlCon.Open();

                                MySqlDataReader reader;
                                reader = comando.ExecuteReader();

                                if (reader.HasRows)
                                {
                                    reader.Read();

                                    imprimir.cuota = reader.GetInt32(0);
                                    imprimir.dicotomia = "n° Inscripción";
                                    imprimir.nombre = reader.GetString(1);
                                    imprimir.apellido = reader.GetString(2);
                                    imprimir.f_pago = reader.GetDateTime(3);
                                    imprimir.f_vto = reader.GetDateTime(4);
                                    imprimir.monto = Insc.monto;
                                    imprimir.ShowDialog();
                                }

                            }

                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                            finally
                            {
                                if (sqlCon.State == ConnectionState.Open)
                                {
                                    sqlCon.Close();
                                }
                            }
                            this.Close();
                            break;

                        case 2:
                            MessageBox.Show("Se realizó el pago de la nueva inscripción");

                            // query

                            MySqlConnection sqlCon2 = new MySqlConnection();
                            try
                            {
                                string query;
                                sqlCon2 = Conexion.getInstancia().CrearConexion();

                                query = "select i.n_inscrip, s.nombre, s.apellido, i.f_pago, i.f_vto, i.monto from inscripciones as i inner join socios as s where s.dni = " + txtDniSocio.Text + ";";

                                MySqlCommand comando = new MySqlCommand(query, sqlCon2);
                                comando.CommandType = CommandType.Text;
                                sqlCon2.Open();

                                MySqlDataReader reader;
                                reader = comando.ExecuteReader();

                                if (reader.HasRows)
                                {
                                    reader.Read();

                                    imprimir.cuota = reader.GetInt32(0);
                                    imprimir.dicotomia = "n° Inscripción";
                                    imprimir.nombre = reader.GetString(1);
                                    imprimir.apellido = reader.GetString(2);
                                    imprimir.f_pago = reader.GetDateTime(3);
                                    imprimir.f_vto = reader.GetDateTime(4);
                                    imprimir.monto = Insc.monto;
                                    imprimir.ShowDialog();
                                }

                            }

                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }

                                finally
                                {
                                    if (sqlCon2.State == ConnectionState.Open)
                                {
                                    sqlCon2.Close();
                                }
                            }
                            this.Close();
                            break;

                        case 3:
                            MessageBox.Show("La inscripción está vigente, no se realizó el cobro");
                            this.Close();
                            break;

                        default:
                            MessageBox.Show("Respuesta desconocida");
                            this.Close();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Error al procesar la respuesta: " + respuesta);
                    this.Close();
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
