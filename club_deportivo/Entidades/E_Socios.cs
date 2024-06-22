using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Club_deportivo_EV.Entidades
{
    public class E_Socios
    {
        public int dni_socio { get; set; }
        public string? nombre { get; set; }
        public string? apellido { get; set; }
        public int cdad_act { get; set; }
        public bool soc_nsoc { get; set; }
        public bool cuota_moroso { get; set; }
    }
}
