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
    
    public partial class Evento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Evento()
        {
            this.Grupo_Evento = new HashSet<Grupo_Evento>();
            this.Alerta = new HashSet<Alerta>();
            this.Configuracion_Alerta = new HashSet<Configuracion_Alerta>();
            this.Mensaje_Aplicativo = new HashSet<Mensaje_Aplicativo>();
            this.Mensaje_Correo = new HashSet<Mensaje_Correo>();
        }
    
        public int codigo_evento { get; set; }
        public string descripcion { get; set; }
        public bool estado { get; set; }
        public Nullable<System.DateTime> fecha_inicio { get; set; }
        public Nullable<System.DateTime> fecha_fin { get; set; }
        public string tipo_evento { get; set; }
        public string tipo_plantilla { get; set; }
        public string plantilla { get; set; }
        public string sentencia { get; set; }
        public string datos_plantilla { get; set; }
        public string asunto { get; set; }
        public string url_navegacion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Grupo_Evento> Grupo_Evento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Alerta> Alerta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Configuracion_Alerta> Configuracion_Alerta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mensaje_Aplicativo> Mensaje_Aplicativo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mensaje_Correo> Mensaje_Correo { get; set; }
    }
}
