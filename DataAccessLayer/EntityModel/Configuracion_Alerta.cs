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
    
    public partial class Configuracion_Alerta
    {
        public int codigo_alerta { get; set; }
        public int codigo_evento { get; set; }
        public int codigo_tipo_notificacion { get; set; }
        public Nullable<int> plazo { get; set; }
        public string tipo_plazo { get; set; }
        public string tipo_alerta { get; set; }
        public string antes_despues { get; set; }
        public bool es_plazo_dinamico { get; set; }
        public bool estado { get; set; }
    
        public virtual Tipo_Notificacion Tipo_Notificacion { get; set; }
        public virtual Evento Evento { get; set; }
    }
}
