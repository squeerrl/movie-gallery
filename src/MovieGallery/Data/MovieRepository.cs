using MovieGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieGallery.Data
{
    public class MovieRepository
    {
        //private static:
        //there is only one instance of the array.So, every time we want to access the _movie array, we don't have to create a new instance of MovieRepository
        private static Movie[] _movies = new Movie[]
        {
            new Movie()
            {
                Id = 1,
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
            },
            new Movie()
            {
                Id=2,
                MovieTitle = "Boyhood",
                Year = 2014,
                DescriptionHtml = "<p>The life of Mason, from early childhood to his arrival at college.",
                Artists = new Artist[]
               {
                    new Artist() {Name = "Richard Linklater", Role = "Director"},
                    new Artist() {Name = "Ellar Coltrane", Role = "Actor"},
                    new Artist() {Name = "Ethan Hawke", Role = "Actor"},
                    new Artist() {Name = "Patricia Arquette", Role = "Actor"},
                    new Artist() {Name = "Richard Linklater", Role = "Writing"}
               }
            },
            new Movie()
            {
                MovieTitle = "Victoria",
                Year = 2015,
                DescriptionHtml = "<p>A young Spanish woman who has newly moved to Berlin finds her flirtation with a local guy turn potentially deadly as their night out with his friends reveals a dangerous secret.",
                Artists = new Artist[]
               {
                    new Artist() {Name = "Sebastian Schipper", Role = "Director"},
                    new Artist() {Name = "Laia Costa", Role = "Actor"},
                    new Artist() {Name = "Frederick Lau", Role = "Actor"},
                    new Artist() {Name = "Franz Rogowski", Role = "Actor"},
                    new Artist() {Name = "Sebastian Schipper", Role = "Writing"}
               }
            },
            new Movie()
            {
                MovieTitle = "Suffragette",
                Year = 2015,
                DescriptionHtml = "The foot soldiers of the early feminist movement, women who were forced underground to pursue a dangerous game of cat and mouse with an increasingly brutal State.",
                Artists = new Artist[]
               {
                    new Artist() {Name = "Sarah Gavron", Role = "Director"},
                    new Artist() {Name = "Carey Mulligan", Role = "Actor"},
                    new Artist() {Name = "Anne-Marie Duff", Role = "Actor"},
                    new Artist() {Name = "Abi Morgan", Role = "Writing"}
               }
            },


        };
        public Movie GetMovie(int id)
        {
            Movie movieToReturn = null;

            foreach (var movie in _movies)
            {
                if(movie.Id == id)
                {
                    movieToReturn = movie;
                    break;
                }
            }
            
             return movieToReturn;
        }

        public Movie[] GetMovies()
        {
            return _movies;
        }
    }
}