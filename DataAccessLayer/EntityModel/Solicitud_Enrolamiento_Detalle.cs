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
    
    public partial class Solicitud_Enrolamiento_Detalle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Solicitud_Enrolamiento_Detalle()
        {
            this.Usuario1 = new HashSet<Usuario>();
        }
    
        public int codigo_solicitud_enrolamiento_detalle { get; set; }
        public int codigo_solicitud_enrolamiento { get; set; }
        public System.DateTime fecha_hora_creacion { get; set; }
        public Nullable<System.DateTime> fecha_hora_modificacion { get; set; }
        public Nullable<int> codigo_usuario_general { get; set; }
        public string nombre_general { get; set; }
        public string telefono_general { get; set; }
        public string identidad_general { get; set; }
        public string cargo_general { get; set; }
        public int codigo_rol_general { get; set; }
        public string correo_general { get; set; }
        public string correo_secundario_general { get; set; }
    
        public virtual Grupo Grupo { get; set; }
        public virtual Solicitud_Enrolamiento Solicitud_Enrolamiento { get; set; }
        public virtual Usuario Usuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Usuario> Usuario1 { get; set; }
    }
}
