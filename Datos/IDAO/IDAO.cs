﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Datos
{
    interface IDAO
    {
        List<DTOJuego> recogeJuego();

        List<DTOOpciones_Juego> recogeOpciones();
    }
}
