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
    
    public partial class Grupo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Grupo()
        {
            this.Grupo_Bandeja = new HashSet<Grupo_Bandeja>();
            this.Grupo_Evento = new HashSet<Grupo_Evento>();
            this.Solicitud_Enrolamiento_Detalle = new HashSet<Solicitud_Enrolamiento_Detalle>();
            this.Usuario_Grupo = new HashSet<Usuario_Grupo>();
            this.Control = new HashSet<Control>();
        }
    
        public int codigo_grupo { get; set; }
        public string nombre_grupo { get; set; }
        public string descripcion_corta { get; set; }
        public string descripcion { get; set; }
        public bool estado { get; set; }
        public System.DateTime fecha_hora_creacion { get; set; }
        public Nullable<System.DateTime> fecha_hora__modificacion { get; set; }
        public int codigo_usuario_creacion { get; set; }
        public Nullable<int> codigo_usuario_modificacion { get; set; }
        public string ambito { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Grupo_Bandeja> Grupo_Bandeja { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Grupo_Evento> Grupo_Evento { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Usuario Usuario1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Solicitud_Enrolamiento_Detalle> Solicitud_Enrolamiento_Detalle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Usuario_Grupo> Usuario_Grupo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Control> Control { get; set; }
    }
}