using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Datos
{
    public class IMPDAO : IDAO
    {
        public List<DTOJuego> recogeJuego()
        {

            List<DTOJuego> listaSQLJuego;

            using (ModeloEntity.EjercicioG2T8Entities db = new ModeloEntity.EjercicioG2T8Entities())
            {

                listaSQLJuego = (from d in db.JUEGOS
                            select new DTOJuego
                            {
                                ID = d.ID,
                                Nombre = d.Nombre

                            }).ToList();

            }

            return listaSQLJuego;

        }

        public List<DTOOpciones_Juego> recogeOpciones()
        {

            List<DTOOpciones_Juego> listaSQLOpcionesJuego;

            using (ModeloEntity.EjercicioG2T8Entities db = new ModeloEntity.EjercicioG2T8Entities())
            {

                listaSQLOpcionesJuego = (from d in db.OPCION_JUEGO
                                 select new DTOOpciones_Juego
                                 {
                                    Juego = d.Juego,
                                    nombreOpcion1 = d.nombreOpcion1,
                                    nombreOpcion2 = d.nombreOpcion2,
                                    enabled = d.enabled

                                 }).ToList();

            }

            return listaSQLOpcionesJuego;
        }
    }
}
