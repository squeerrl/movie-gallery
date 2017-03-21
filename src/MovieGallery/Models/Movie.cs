using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieGallery.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string MovieTitle { get; set; }
        public int Year { get; set; }
        public string DescriptionHtml { get; set; }
        public Artist[] Artists { get; set; }
        public bool Favorite { get; set; }

        public string DisplayText
        {
            get
            {
                return MovieTitle + " (" + Year +")";
            }
        }

        // Bildname: movie-year.jpg
        public string CoverImageFileName
        {
            get
            {
                //The Sunshine wird mittels replace(,) zu the-sunshine
                return MovieTitle.Replace(" ", "-").ToLower() + "-" + Year + ".jpg";
            }
        }


    }
}