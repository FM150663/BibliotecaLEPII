//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Libreria
{
    using System;
    using System.Collections.Generic;
    
    public partial class UBICACION
    {
        public int idLibro { get; set; }
        public string pasillo { get; set; }
        public string estante { get; set; }
    
        public virtual LIBRO LIBRO { get; set; }
    }
}
