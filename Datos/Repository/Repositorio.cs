using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Datos
{
    public class Repositorio
    {
        IMPDAO imDao = new IMPDAO();
        public List<DTOJuego> recogeJuego()
        {
            return imDao.recogeJuego();

        }

        public List<DTOOpciones_Juego> recogeOpcionesRepo() 
        {

            return imDao.recogeOpciones();
        
        }

    }
}
