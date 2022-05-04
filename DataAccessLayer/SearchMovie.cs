using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class SearchMovie
    {
        public string Title { get; set; }
        public string Year { get; set; }
        public string ImdbID { get; set; }
        public string Type { get; set; }
        public string ImgUrl { get; set; }
        public int TotalSearches { get; set; }
    }
}
