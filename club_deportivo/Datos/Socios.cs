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
    internal class Socios
    {
        public string Nuevo_socio (E_Socios Soc)
        {
            string? salida;

            // instancia un objeto de la clase mysqlconnection y lo guarda en la variable sqlcon
            MySqlConnection sqlCon = new MySqlConnection();

            // bloque try para pedirle que ejecute las órdenes y manejar si la respuesta da error, para que no rompa el programa.
            try
            {   //llama a la clase Conexion que crea la Conexión con sql y maneja el error. Tiene las credenciales de acceso a sql y el nombre de la base de datos.
                sqlCon = Conexion.getInstancia().CrearConexion();

                //Genera le comando que es el llamado al procedure de sql, dándole los argumentos de los parámetros que requiere
                //Llamo al procedure con el nombre que le puse en sql
                MySqlCommand comando = new MySqlCommand("IngresarSocio", sqlCon);

                comando.CommandType = CommandType.StoredProcedure;

                //Envío los argumentos para mi sql procedure
                comando.Parameters.Add("d", MySqlDbType.Int64).Value = Soc.dni_socio;
                comando.Parameters.Add("n", MySqlDbType.VarChar).Value = Soc.nombre;
                comando.Parameters.Add("a", MySqlDbType.VarChar).Value = Soc.apellido;

                //Genero variable que va a tomar el parámetro out de la salida del procedure
                //la llamo parcodigo por que va a ser el parámetro desde la salida del procedure hacia el código
                MySqlParameter ParCodigo = new MySqlParameter();
                ParCodigo.ParameterName = "rta";
                ParCodigo.MySqlDbType = MySqlDbType.Int32;
                ParCodigo.Direction = ParameterDirection.Output;
                comando.Parameters.Add(ParCodigo);

                sqlCon.Open();
                //ejecuta sentencias sql que no devuelven resultados, como insert, update, delete, create o alter table
                //la conexion debe estar abierta y luego cerrarla
                comando.ExecuteNonQuery();

                //variable que elegí para la salida
                //la convierte al tipo elegido
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
