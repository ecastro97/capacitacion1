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
    
    public partial class ErrorLogs
    {
        public int Error_Log_Id { get; set; }
        public string Source { get; set; }
        public System.DateTime Date { get; set; }
        public string Message { get; set; }
        public string Error { get; set; }
    }
}
