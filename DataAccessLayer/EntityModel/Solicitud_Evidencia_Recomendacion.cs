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
    
    public partial class Solicitud_Evidencia_Recomendacion
    {
        public int codigo_solicitud_evidencia { get; set; }
        public int codigo_informe_auditoria { get; set; }
        public int codigo_informe_seguimiento { get; set; }
        public int codigo_recomendacion { get; set; }
        public string descripcion { get; set; }
        public bool solicitada { get; set; }
    
        public virtual Informe_Auditoria Informe_Auditoria { get; set; }
        public virtual Recomendacion_Informe_Auditoria Recomendacion_Informe_Auditoria { get; set; }
        public virtual Informe_Seguimiento Informe_Seguimiento { get; set; }
        public virtual Solicitud_Evidencia Solicitud_Evidencia { get; set; }
    }
}
