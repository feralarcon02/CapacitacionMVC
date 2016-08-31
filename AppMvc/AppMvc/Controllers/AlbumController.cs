using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppMvc.Controllers
{
    public class AlbumController : Controller
    {
        // GET: Album
        public class Album
        {
            public string Title { get; set; }
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Lista()
        {
            var albums = new List<Album>();
            for (int i = 0; i < 10; i++)
            {
                albums.Add(new Album { Title = "Product " + i });
            }
            ViewBag.Albums = albums;
            return View();
        }
    }
}