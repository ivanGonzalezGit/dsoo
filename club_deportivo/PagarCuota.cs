using Club_deportivo_EV.Entidades;
using Club_deportivo_EV.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DisenioLogin.Datos;
using MySql.Data.MySqlClient;

namespace Club_deportivo_EV
{
    public partial class frmPagarCuota : Form
    {
        public frmPagarCuota()
        {
            InitializeComponent();
        }

        frmImprimir imprimir = new frmImprimir();

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (txtMonto.Text == "" || txtDniSocio.Text == "")
            {
                MessageBox.Show("Debe completar los datos marcados con *");
            }
            else
                {
                string respuesta;

                E_Cuotas Cuot = new E_Cuotas();
                Cuot.monto = Convert.ToInt32(txtMonto.Text);
                Cuot.dni_socio = Convert.ToInt32(txtDniSocio.Text);

                Datos.Cuotas Cuota= new Datos.Cuotas();
                respuesta = Cuota.NuevaCuota(Cuot);

                if (int.TryParse(respuesta, out int salidaProcedure))
                    {
                    switch (salidaProcedure)
                    {
                        case 0:
                            MessageBox.Show("No existe el socio");
                            this.Close();
                            break;

                        case 1:
                            MessageBox.Show("Se realizó correctamente el pago de la cuota");

                            MySqlConnection sqlCon = new MySqlConnection();
                            try
                            {
                                string query;
                                sqlCon = Conexion.getInstancia().CrearConexion();

                                query = "select c.n_cuota, s.nombre, s.apellido, c.f_pago, c.f_vto, c.monto from cuotas as c inner join socios as s where s.dni = " + txtDniSocio.Text + ";";

                                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                                comando.CommandType = CommandType.Text;
                                sqlCon.Open();

                                MySqlDataReader reader;
                                reader = comando.ExecuteReader();

                                if (reader.HasRows)
                                {
                                    reader.Read();

                                    imprimir.cuota = reader.GetInt32(0);
                                    imprimir.dicotomia = "n° Cuota";
                                    imprimir.nombre = reader.GetString(1);
                                    imprimir.apellido = reader.GetString(2);
                                    imprimir.f_pago = reader.GetDateTime(3);
                                    imprimir.f_vto = reader.GetDateTime(4);
                                    imprimir.monto = Cuot.monto;
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
                            MessageBox.Show("Se realizó correctamente el pago de la cuota");

                            MySqlConnection sqlCon2 = new MySqlConnection();
                            try
                            {
                                string query;
                                sqlCon2 = Conexion.getInstancia().CrearConexion();

                                query = "select c.n_cuota, s.nombre, s.apellido, c.f_pago, c.f_vto, c.monto from cuotas as c inner join socios as s where s.dni = " + txtDniSocio.Text + ";";

                                MySqlCommand comando = new MySqlCommand(query, sqlCon2);
                                comando.CommandType = CommandType.Text;
                                sqlCon2.Open();

                                MySqlDataReader reader;
                                reader = comando.ExecuteReader();

                                if (reader.HasRows)
                                {
                                    reader.Read();

                                    imprimir.cuota = reader.GetInt32(0);
                                    imprimir.dicotomia = "n° Cuota";
                                    imprimir.nombre = reader.GetString(1);
                                    imprimir.apellido = reader.GetString(2);
                                    imprimir.f_pago = reader.GetDateTime(3);
                                    imprimir.f_vto = reader.GetDateTime(4);
                                    imprimir.monto = Cuot.monto;
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
                            MessageBox.Show("La cuota no está vencida");
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
    }
}
