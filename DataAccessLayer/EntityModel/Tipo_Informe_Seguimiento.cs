//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer.EntityModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tipo_Informe_Seguimiento
    {
        public int codigo_tipo_informe_seguimiento { get; set; }
        public string descripcion { get; set; }
        public bool estado { get; set; }
        public System.DateTime fecha_hora_creacion { get; set; }
        public int codigo_usuario_creacion { get; set; }
        public Nullable<System.DateTime> fecha_hora_modificacion { get; set; }
        public Nullable<int> codigo_usuario_modificacion { get; set; }
    
        public virtual Usuario Usuario { get; set; }
        public virtual Usuario Usuario1 { get; set; }
    }
}
