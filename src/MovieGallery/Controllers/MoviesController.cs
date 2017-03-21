using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieGallery.Models;

namespace MovieGallery.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Detail()
        {
            var movie = new Movie()
            {
                MovieTitle = "Sunshine",
                Year = 2007,
                DescriptionHtml = "<p>Lot of fun, at the end <b>drunk</b>! Why?",
                Artists = new Artist[]
                {
                    new Artist() {Name = "Danny Boyle", Role = "Director"},
                    new Artist() {Name = "Cillian Murphy", Role = "Actor"},
                    new Artist() {Name = "Rose Byrne", Role = "Actor"},
                    new Artist() {Name = "Chris Evans", Role = "Actor"},
                    new Artist() {Name = "Alex Garland", Role = "Writing"}
                }

            };
            //movie.MovieTitle = "BlaBla";
            


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