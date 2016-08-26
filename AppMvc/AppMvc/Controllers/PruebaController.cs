using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppMvc.Controllers
{
    public class PruebaController : Controller
    {
        // GET: Prueba
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index2()
        {
            return View("View");
        }

        public ActionResult AccionDeOtroControl()
        {
            //return View("../Home/Index
            //return RedirectToAction("Index", "Home", new {id = 1 }); //Para pasar parametros como objeto
            return RedirectToAction("Index", "Home");
        }
    }
}