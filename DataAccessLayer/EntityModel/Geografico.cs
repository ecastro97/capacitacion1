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
    
    public partial class Geografico
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Geografico()
        {
            this.Informe_Auditoria = new HashSet<Informe_Auditoria>();
            this.Entidad = new HashSet<Entidad>();
        }
    
        public int codigo_geografico { get; set; }
        public int departamento { get; set; }
        public int municipio { get; set; }
        public int nivel { get; set; }
        public string nombre { get; set; }
        public bool estado { get; set; }
        public System.DateTime fecha_hora_creacion { get; set; }
        public int codigo_usuario_creacion { get; set; }
        public Nullable<System.DateTime> fecha_hora_modificacion { get; set; }
        public Nullable<int> codigo_usuario_modificacion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Informe_Auditoria> Informe_Auditoria { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Entidad> Entidad { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Usuario Usuario1 { get; set; }
    }
}
