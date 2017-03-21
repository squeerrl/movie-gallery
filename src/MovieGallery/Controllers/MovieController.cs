using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieGallery.Controllers
{
    public class MovieController : Controller
    {
        public  ActionResult Detail()
        {
            ViewBag.Movietitle = "Sunshine";
            ViewBag.Movieyear = 2007;
            ViewBag.Descripion = "<p>Lot of fun, at the end <b>drunk</b>! Why?";
            ViewBag.Artists = new string[] {
                "Director: Danny Boyle",
                "Writer: Alex Garland",
                "Star: Cillian Murphy",
                "Star: Rose Byrne",
                "Star: Chris Evans"
            };


            return View();
            //return Redirect("/"); <-- weiterleitung zur startseite 
            
            //return Content("Hallo hallo ich hier");
            /*=return new ContentResult()
            {
                Content = "Hallo hallo ich bina"
            };
            */
        }
    }
}