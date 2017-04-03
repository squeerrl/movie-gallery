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

        public ActionResult Index()
        {
            var movies = _movieRepository.GetMovies();
            return View(movies);
        }

        public ActionResult GenreList(string genre__)
        {
            Movie[] movies = new Movie[_movieRepository.GetLength()];

            int realSizeMovie = 0;

            for(int iforMovie = 1; iforMovie <= _movieRepository.GetLength(); iforMovie++)
            {
                var movie = _movieRepository.GetMovie(iforMovie);

                for (int iforGenres=0; iforGenres < movie.Genre.Length; iforGenres++)
                {
                    if (genre__.ToLower() == movie.Genre[iforGenres].ToLower())
                    {
                        movies[realSizeMovie] = _movieRepository.GetMovie(iforMovie);
                        realSizeMovie++;
                    }
                }
                
            }
            
            Array.Resize(ref movies, realSizeMovie);
            
            return View(movies);
        }

        public ActionResult MustSeenList()
        {
            Movie[] movies = new Movie[_movieRepository.GetLength()];

            int realSizeMovie = 0;



            for (int i = 1; i <= _movieRepository.GetLength(); i++)
            {
                var movie = _movieRepository.GetMovie(i);

                if (movie.Favorite)
                {
                    movies[realSizeMovie] = _movieRepository.GetMovie(i);
                    realSizeMovie++;
                }
            }

            Array.Resize(ref movies, realSizeMovie);

            return View(movies);
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