using Club_deportivo_EV.Datos;
using DisenioLogin.Datos;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Cms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Club_deportivo_EV
{
    public partial class frmListadoMorosos : Form
    {
        public frmListadoMorosos()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListadoMorosos_Load(object sender, EventArgs e)
        {
            CargaGrilla();
        }

        public void CargaGrilla()
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
                query = "SELECT socios.dni, socios.nombre, socios.apellido FROM socios where cuota_moroso = true;";

                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();

                MySqlDataReader reader;
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int renglon = dtgvListadoMorosos.Rows.Add();
                        dtgvListadoMorosos.Rows[renglon].Cells[0].Value = reader.GetInt32(0);
                        dtgvListadoMorosos.Rows[renglon].Cells[1].Value = reader.GetString(1);
                        dtgvListadoMorosos.Rows[renglon].Cells[2].Value = reader.GetString(2);
                    }
                }
                else
                {
                    MessageBox.Show("NO HAY DATOS PARA LA CARGA DE LA GRILLA");
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
        }

        private void dtgvListadoMorosos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}