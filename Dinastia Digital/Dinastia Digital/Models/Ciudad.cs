//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dinastia_Digital.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ciudad
    {
        public int idCiudad { get; set; }
        public Nullable<int> idDepartamento { get; set; }
        public string Ciudad1 { get; set; }
    
        public virtual Ciudad Ciudad11 { get; set; }
        public virtual Ciudad Ciudad2 { get; set; }
    }
}
