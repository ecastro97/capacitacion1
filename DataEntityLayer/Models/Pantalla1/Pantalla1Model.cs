using System;
using System.ComponentModel.DataAnnotations;

namespace DataEntityLayer.Models.Pantalla1
{
    public class Pantalla1Model
    {
        [Required(ErrorMessage = "Ingrese su Nombre")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Ingrese su Apellido")]
        [Display(Name = "Apellido")]
        public string Apellido { get; set; }

        [Display(Name = "Edad")]
        public int Edad { get; set; }

        [Display(Name = "Identidad")]
        public string Identidad { get; set; }

        [Display(Name = "Cónyuge")]
        public string Conyuge { get; set; }

        [Display(Name = "Fecha Inicial")]
        public DateTime Fecha_Inicial { get; set; }
        
        [Display(Name = "Fecha Final")]
        public DateTime Fecha_Final { get; set; }
    }
}
