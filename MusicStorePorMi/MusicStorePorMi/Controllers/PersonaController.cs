using MusicStorePorMi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStorePorMi.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Post(Persona model) //Recibe directamente el modelo
        {
            return View();
        }

        [HttpGet] // Redundante porque toda accion ya es un get
        public ActionResult Persona() //Para el get, no tiene parametros
        {
            return View();
        }

        [HttpPost]
        //[ValidateAntiForgeryToken] //Como que controla que me mande el cliente lo que yo le pido, y en la vista tamb va algo
        public ActionResult Persona(Persona model) //Yame llega el objeto armado con todas las propiedades adentro
        {
            return View(model);
        }

    }
}