//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos.ModeloEntity
{
    using System;
    using System.Collections.Generic;
    
    public partial class OPCION_JUEGO
    {
        public int Juego { get; set; }
        public string nombreOpcion1 { get; set; }
        public string nombreOpcion2 { get; set; }
        public Nullable<bool> enabled { get; set; }
    
        public virtual JUEGOS JUEGOS { get; set; }
    }
}
