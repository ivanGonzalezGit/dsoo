using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace socios
{
    internal class Socios
    {
        // atributos
        public int nro_identificacion;
        public string nombre;
        public string apellido;
        public int cantidad_actividades = 0;

        // constructor
        public Socios(int nro_identificacion, string nombre_socio, string apellido_socio)
        {
            this.nro_identificacion = nro_identificacion;
            this.nombre = nombre_socio;
            this.apellido = apellido_socio;
        }

        // getters y setters
        public int NroSocio { get { return nro_identificacion; } set { nro_identificacion = value; } }

        public string Nombre { get { return nombre; } set { nombre = value; } }

        public string Apellido { get { return apellido; } set { apellido = value; } }


        //métodos
        public override string ToString()
        {
            return "nro_identificación: " + NroSocio + "; Nombre: " + Nombre + "; Apellido: " + Apellido;
        }

        public bool TopeActividades()
        {
            bool permitido = false;
            if (cantidad_actividades < 3)
            {
                cantidad_actividades += 1;
                permitido = true;
            }
            return permitido;
        }
    }
}
