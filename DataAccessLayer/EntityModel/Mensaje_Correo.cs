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
    
    public partial class Mensaje_Correo
    {
        public int codigo_mensaje_correo { get; set; }
        public int codigo_evento { get; set; }
        public int codigo_usuario { get; set; }
        public System.DateTime fecha_hora_creacion { get; set; }
        public bool estado { get; set; }
        public string cuerpo_mensaje { get; set; }
        public Nullable<System.DateTime> fecha_hora_envio { get; set; }
    
        public virtual Usuario Usuario { get; set; }
        public virtual Evento Evento { get; set; }
    }
}