using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class FavoriteMovieVM
    {
        public string IMDbId { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public string Duration { get; set; }
        public string Genre { get; set; }
        public string Type { get; set; }
        public string UserOcjena { get; set; }
        public int UserID { get; set; }
    }
}
