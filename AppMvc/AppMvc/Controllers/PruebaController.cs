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
            ViewBag.Mensaje = "Este año ganamos todooo!!";
            return View();
            //return View("~/Views/Home/Index.cshtml"); //El cosito ese ~ es para ir para atras creo..
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
        //Solo para que me deje probal el ejemplo del ,libro, no iria aca esto..
        

        public ActionResult Lista()

        {
          
            return View();
        }
    }
}