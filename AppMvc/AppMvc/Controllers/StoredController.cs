using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppMvc.Controllers
{
    public class StoredController : Controller
    {
        // GET: Stored
        public String Index()
        {
            return "Hola desde Stored.Index()";
        }

        public String Buscar(string genero)
        {
            string mensaje = HttpUtility.HtmlEncode("Stored.Buscar, Genero " + genero);
            return mensaje;
        }

        public String Detalles(string id)
        {
            string mensaje = "Srored.Detalles, ID = " + id;
            return mensaje;
        }
    }
}