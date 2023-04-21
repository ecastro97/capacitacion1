using DataAccessLayer.EntityModel;
using DataEntityLayer.Models;
using DataEntityLayer.Models.Pantalla1;
using DevExpress.DataAccess.Native.Web;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Mvc;

namespace ProyectoNcapas.Controllers
{
    public class Pantalla1Controller : BaseController
    {
        public ActionResult Index()
        {
            return View("~/Views/Pantalla1/Index.cshtml");
        }

        public ActionResult GetPersonas(DataSourceLoadOptions loadOptions)
        {
            CustomJsonResult response = new CustomJsonResult();
            try
            {
                List<Pantalla1Model> ListaPersonas = new List<Pantalla1Model>
                {
                    new Pantalla1Model
                    {
                        Nombre = "José",
                        Apellido = "Chavez",
                        Edad = 30,
                        Identidad = "0501199709267",
                        Conyuge = "Conyuge",
                        Fecha_Inicial = DateTime.Now, 
                        Fecha_Final = DateTime.Now.AddDays(1)
                    },
                    new Pantalla1Model
                    {
                        Nombre = "Moisés",
                        Apellido = "Inestroza",
                        Edad = 31,
                        Identidad = "0501199709888",
                        Conyuge = "Conyuge",
                        Fecha_Inicial = DateTime.Now,
                        Fecha_Final = DateTime.Now.AddDays(4)
                    },
                    new Pantalla1Model
                    {
                        Nombre = "Arnold",
                        Apellido = "Colindres",
                        Edad = 26,
                        Identidad = "0501199709999",
                        Conyuge = "Conyuge",
                        Fecha_Inicial = DateTime.Now,
                        Fecha_Final = DateTime.Now.AddDays(3)
                    },
                    new Pantalla1Model
                    {
                        Nombre = "Alejandro",
                        Apellido = "Contreras",
                        Edad = 21,
                        Identidad = "0501199709444",
                        Conyuge = "Conyuge",
                        Fecha_Inicial = DateTime.Now,
                        Fecha_Final = DateTime.Now.AddDays(2)
                    },
                    new Pantalla1Model
                    {
                        Nombre = "Eduardo",
                        Apellido = "Castro",
                        Edad = 25,
                        Identidad = "0501199709222",
                        Conyuge = "Conyuge",
                        Fecha_Inicial = DateTime.Now,
                        Fecha_Final = DateTime.Now.AddDays(3)
                    },
                };

                response.result = DataSourceLoader.Load(ListaPersonas, loadOptions);                
            }
            catch (Exception e)
            {
                response.typeResult = 1;
                response.message = $"Error: {e.Message}, Fuente: {e.Source}";
            }
            return Content(JsonConvert.SerializeObject(response.result), "application/json");
        }

        public ActionResult FormAgregar()
        {
            return PartialView("~/Views/Pantalla1/_Formulario.cshtml");
        }

        public ActionResult GuardarPersona(Pantalla1Model modelo)
        {
            CustomJsonResult response = new CustomJsonResult();
            try
            {
                response.codeResult = 0;
                response.typeResult = 0;
                response.message = "Persona guardada con éxito.";
            }
            catch (Exception e)
            {
                response.typeResult = 1;
                response.message = $"Error: {e.Message}, Fuente: {e.Source}";
            }
            return Content(JsonConvert.SerializeObject(response), "application/json");
        }
    }
}