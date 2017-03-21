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