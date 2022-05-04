using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Movie
    {
        public string ImdbId { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public string RatingRestriction { get; set; }
        public DateTime Released { get; set; }
        public string Duration { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public string Writer { get; set; }
        public string Actors { get; set; }
        public string Plot { get; set; }
        public string Language { get; set; }
        public string Awards { get; set; }
        public string ImgUrl { get; set; }
        public string ImdbRating { get; set; }
        public string ImdbVotes { get; set; }
        public string Type { get; set; }
    }
}
