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
    
    public partial class Clasificacion_Entidad
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Clasificacion_Entidad()
        {
            this.Entidad = new HashSet<Entidad>();
        }
    
        public int codigo_clasificacion_entidad { get; set; }
        public string codigo_clasificacion { get; set; }
        public string descripcion { get; set; }
        public bool estado { get; set; }
        public int codigo_usuario_creacion { get; set; }
        public System.DateTime fecha_hora_creacion { get; set; }
        public Nullable<int> codigo_usuario_modificacion { get; set; }
        public Nullable<System.DateTime> fecha_hora_modificacion { get; set; }
    
        public virtual Usuario Usuario { get; set; }
        public virtual Usuario Usuario1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Entidad> Entidad { get; set; }
    }
}
