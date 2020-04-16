using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class FachadaNegocio : IFachadaNegocio
    {

        IDAO dao = new Datos.IMPDAO();
        public List<Juego> ListarJuegos()
        {
            List<DTOJuego> listaJuegosDao = dao.recogeJuego();

            return listaJuegosDao.ConvertAll(delegate (DTOJuego dto)
            {
                return new Juego()
                {
                    ID = dto.ID,
                    Nombre = dto.Nombre,
                };
            });
        }

        public List<OpcionJuego> ListarOpcionesJuego()
        {
            List<DTOOpciones_Juego> listaOpcionesDao = dao.recogeOpciones();

            return listaOpcionesDao.ConvertAll(delegate (DTOOpciones_Juego dto)
            {
                return new OpcionJuego()
                {
                    Juego = dto.Juego,
                    enabled = dto.enabled,
                    nombreOpcion1 = dto.nombreOpcion1,
                    nombreOpcion2 = dto.nombreOpcion2,
                };
            });
        }
    }
}
