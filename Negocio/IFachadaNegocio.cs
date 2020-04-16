using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public interface IFachadaNegocio
    {
        List<Juego> ListarJuegos();

        List<OpcionJuego> ListarOpcionesJuego();
    }
}
