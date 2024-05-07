using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividades
{
    internal class Actividades
    {
        // atributos
        public string nombre;
        private int cupo = 5;

        // constructor
        public Actividades(string nom)
        {
            this.nombre = nom;
        }

        // getters y setters
        public string Nombre { get { return nombre; } set { nombre = value; } }

        //métodos
        public override string ToString()
        {
            return "Nombre Actividad: " + Nombre;
        }

        public void DisminuirCupo()
        {
            if (cupo > 0)
            {
                cupo -= 1;
            }
        }
    }
}
