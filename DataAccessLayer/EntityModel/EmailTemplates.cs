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
    
    public partial class EmailTemplates
    {
        public string Template_Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Template_Type_Id { get; set; }
        public string HTML_Content { get; set; }
        public bool Status { get; set; }
    
        public virtual EmailTemplatesTypes EmailTemplatesTypes { get; set; }
    }
}
