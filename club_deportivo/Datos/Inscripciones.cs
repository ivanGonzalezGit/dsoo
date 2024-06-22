using Club_deportivo_EV.Entidades;
using DisenioLogin.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Club_deportivo_EV.Datos
{
    internal class Inscripciones
    {
        public string NuevaInscripcion(E_Inscripciones Insc)
        {
            string? salida;

            MySqlConnection sqlCon = new MySqlConnection();

            try
            {   
                sqlCon = Conexion.getInstancia().CrearConexion();

                MySqlCommand comando = new MySqlCommand("PagarInscripcion", sqlCon);

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("m", MySqlDbType.Int64).Value = Insc.monto;
                comando.Parameters.Add("d", MySqlDbType.Int64).Value = Insc.dni_socio;

                MySqlParameter ParCodigo = new MySqlParameter();
                ParCodigo.ParameterName = "rta";
                ParCodigo.MySqlDbType = MySqlDbType.Int32;
                ParCodigo.Direction = ParameterDirection.Output;
                comando.Parameters.Add(ParCodigo);

                sqlCon.Open();

                comando.ExecuteNonQuery();

                salida = Convert.ToString(ParCodigo.Value);

            }
            catch (Exception ex)
            {
                salida = ex.Message;
            }

            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); };
            }
            return salida;
        }
    }
}
