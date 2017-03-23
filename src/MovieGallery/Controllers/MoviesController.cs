using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieGallery.Models;
using MovieGallery.Data;

namespace MovieGallery.Controllers
{
    public class MoviesController : Controller
    {
        private MovieRepository _movieRepository = null;

        public MoviesController()
        {
            _movieRepository = new MovieRepository();
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            var movie = _movieRepository.GetMovie((int)id);
            
            return View(movie);
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