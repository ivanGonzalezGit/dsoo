using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Club_deportivo_EV
{
    internal class ClubDeportivo
    {
        // crea la lista de los socios
        public static List<Socios> listaSocios = new List<Socios>();
        public static List<Actividades> listaActividades = new List<Actividades>();


        // registra socios nuevos en la lista de socios si ya no están registrados
        public static void AltaSocio(int nro_id, string nom, string ap)
        {
            if (ClubDeportivo.BuscarSocio(nro_id))
            {
                Console.WriteLine("EL NÚMERO DE IDENTIFICACIÓN YA PERTENECE A UN SOCIO ACTIVO");
            }
            else
            {
                Socios socio1 = new Socios(nro_id, nom, ap);
                listaSocios.Add(socio1);
                Console.WriteLine("INSCRIPCIÓN DE SOCIO EXITOSA");
            }
        }

        //registra las actividades
        public static void AltaActividad(string nCod, string nomActividad)
        {
            if (ClubDeportivo.BuscarActividad(nomActividad))
            {
                Console.WriteLine("LA ACTIVIDAD YA FUE CARGADA");
            }
            else
            {
                Actividades actividad1 = new Actividades(nCod, nomActividad);
                listaActividades.Add(actividad1);
                Console.WriteLine("ACTIVIDAD CARGADA CORRECTAMENTE");
            }
        }

        public static void InscribirActividad(int id_socio, string nomAct)
        {

            int indice = 0;
            for (int i = 0; i < listaSocios.Count; i++)
            {
                if (id_socio == listaSocios[i].dni)
                {
                    indice = i;
                }
            }

            Socios socio1 = listaSocios[indice];

            if (BuscarSocio(id_socio))
            {
                if (BuscarActividad(nomAct))
                {
                    if (socio1.TopeActividades())
                    {
                        Console.WriteLine("INSCRIPCIÓN EXITOSA");
                    }
                    else
                    {
                        Console.WriteLine("TOPE DE ACTIVIDADES ALCANZADO");
                    }
                }
                else
                {
                    Console.WriteLine("ACTIVIDAD INEXISTENTE");
                }
            }
            else
            {
                Console.WriteLine("SOCIO INEXISTENTE");
            }
        }

        // muestra todos los socios de la lista socios
        public static int j = 0;
        public static void MostrarTotalSocios()
        {
            foreach (Socios persona in listaSocios)
            {
                j += 1;
                Console.WriteLine(listaSocios[j - 1]);
            }
        }

        public static int k = 0;
        public static void MostrarTotalActividades()
        {
            foreach (Actividades actividad in listaActividades)
            {
                k += 1;
                Console.WriteLine(listaActividades[k - 1]);
            }
        }

        // busca los socios en la lista de socios por numero de identificacion y devuelve true si los encuentra
        public static bool BuscarSocio(int nro_identificacion)
        {
            bool existe = false;
            for (int i = 0; i < listaSocios.Count; i++)
            {
                Socios objetoSocio = listaSocios[i];
                if (nro_identificacion == objetoSocio.Dni)
                {
                    existe = true;
                    break;
                }
            }
            return existe;
        }

        public static bool BuscarActividad(string nomActividad)
        {
            bool existe = false;
            for (int i = 0; i < listaActividades.Count; i++)
            {
                Actividades objetoActividad = listaActividades[i];
                if (nomActividad == objetoActividad.Nombre)
                {
                    existe = true;
                    break;
                }
            }
            return existe;
        }
    }
}
