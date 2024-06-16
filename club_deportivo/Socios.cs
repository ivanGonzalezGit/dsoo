using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Club_deportivo_EV
{
    internal class Socios
    {
        // atributos
        public int dni;
        public string nombre;
        public string apellido;
        public bool inscripcion = false;
        public bool cuota = false;
        public string act1 = "";
        public string act2 = "";
        public string act3 = "";
        public int cantidad_actividades = 0;

        // constructor
        public Socios(int dni, string nombre_socio, string apellido_socio)
        {
            this.dni = dni;
            this.nombre = nombre_socio;
            this.apellido = apellido_socio;
    }

        // getters y setters
        public int Dni { get { return dni; } set { dni = value; } }

        public string Nombre { get { return nombre; } set { nombre = value; } }

        public string Apellido { get { return apellido; } set { apellido = value; } }

        public bool Inscipcion { get { return inscripcion ; } set { inscripcion = value; } }

        public bool Cuota { get { return cuota; } set { cuota = value; } }

        public string Act1 { get { return act1; } set { act1 = value; } }

        public string Act2 { get { return act2; } set { act2 = value; } }

        public string Act3 { get { return act3; } set { act3 = value; } }


        //métodos
        public override string ToString()
        {
            return "DNI: " + Dni + "; Nombre: " + Nombre + "; Apellido: " + Apellido;
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
