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
    
    public partial class Asignacion_Supervisor_Informe
    {
        public int codigo_asignacion { get; set; }
        public int codigo_usuario_supervisor { get; set; }
        public int codigo_informe_auditoria { get; set; }
        public System.DateTime fecha_asignacion { get; set; }
        public int numero_orden_trabajo { get; set; }
        public bool vigente { get; set; }
        public int codigo_usuario_creacion { get; set; }
        public System.DateTime fecha_hora_creacion { get; set; }
        public Nullable<int> codigo_usuario_modificacion { get; set; }
        public Nullable<System.DateTime> fecha_hora_modificacion { get; set; }
        public int codigo_plan_accion { get; set; }
        public int codigo_plan_accion_version { get; set; }
    
        public virtual Informe_Auditoria Informe_Auditoria { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Usuario Usuario1 { get; set; }
        public virtual Usuario Usuario2 { get; set; }
        public virtual Asignacion_Supervisor_Informe Asignacion_Supervisor_Informe1 { get; set; }
        public virtual Asignacion_Supervisor_Informe Asignacion_Supervisor_Informe2 { get; set; }
    }
}