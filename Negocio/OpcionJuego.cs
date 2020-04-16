using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class OpcionJuego
    {
        public int Juego { get; set; }
        public string nombreOpcion1 { get; set; }
        public string nombreOpcion2 { get; set; }
        public bool? enabled { get; set; }

    }
}
