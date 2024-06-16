using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Club_deportivo_EV
{
    internal class Actividades
    {
        // atributos
        public string codigo;
        public string nombre;
        private int cupo = 20;

        // constructor
        public Actividades(string cod, string nom)
        {
            this.codigo = cod;
            this.nombre = nom;
        }

        // getters y setters
        public string Codigo { get { return codigo; } set { nombre = value; } }

        public string Nombre { get { return nombre; } set { nombre = value; } }

        //métodos
        public override string ToString()
        {
            return "Código: " + Codigo + "Nombre Actividad: " + Nombre;
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
