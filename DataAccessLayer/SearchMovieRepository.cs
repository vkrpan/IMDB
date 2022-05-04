using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DataAccessLayer
{
    public class SearchMovieRepository
    {
        readonly string apiLink = ConfigurationManager.ConnectionStrings["link"].ConnectionString;
        readonly string apiKey = ConfigurationManager.ConnectionStrings["ApiKey"].ConnectionString;
        public List<SearchMovie> GetMoviesByTitleAndYear(string title, string year, string movie, string series)
        {
            List<SearchMovie> SearchMoviesREST = new List<SearchMovie>();
            string sJson = CallRestMethod(CreateURL(title, year, movie, series));
            JObject json = JObject.Parse(sJson);
            return MovieFound(json, SearchMoviesREST);
        }
        public List<SearchMovie> MovieFound(JObject json, List<SearchMovie> lista)
        {
            if (json["Response"].ToString() == "False")
            {
                return lista;
            }
            else
            {
                var SearchObjects = json["Search"].ToString();
                var totalSearches = Convert.ToInt32(json["totalResults"]);
                JArray Search = JArray.Parse(SearchObjects);
                foreach (JObject item in Search)
                {
                    lista.Add(new SearchMovie
                    {
                        Title = item.GetValue("Title").ToString(),
                        Year = item.GetValue("Year").ToString(),
                        ImdbID = item.GetValue("imdbID").ToString(),
                        Type = item.GetValue("Type").ToString(),
                        ImgUrl = item.GetValue("Poster").ToString(),
                        TotalSearches = totalSearches
                    }) ;
                }
                return lista;
            }
        }
        public List<SearchMovie> GetMoviesOnPage(int pageNumber, string title, string year, string movie, string series)
        {
            List<SearchMovie> SearchMoviesNew = new List<SearchMovie>();
            var noviURL = CreateURL(title, year, movie, series) + ReturnPageString(pageNumber);
            var sJson = CallRestMethod(noviURL);
            JObject json = JObject.Parse(sJson);
            return MovieFound(json, SearchMoviesNew);
            
        }
        public int GetNumberOfPages(List<SearchMovie> lista)
        {
            if (lista.Count != 0)
            {
                var ukupno = lista[0].TotalSearches;
                int brStranica = 1;
                if (ukupno % 10 != 0)
                {
                    brStranica = ukupno / 10 + 1;
                }
                else
                {
                    brStranica = ukupno / 10;
                }
                return brStranica;
            }
            return 1;
        }
        public string ReturnPageString(int pageNumber)
        {
            return "&page=" + pageNumber;
        }

        private string CreateURL(string title, string year, string movie, string series)
        {
            bool yPomocna = false;
            string type = "";
            if (title.Contains(" "))
            {
                title = title.Replace(" ", "+");
            }
            if (IsYear(year))
            {
                yPomocna = true;

            }
            if (movie != "" && series != "")
            {
                type = "";
            }
            else if (movie == "movie")
            {
                type = "movie";
            }
            else if (series == "series")
            {
                type = "series";
            }
            string url =apiLink+ "s=" + title + "&type="+type+"&apikey="+apiKey + (yPomocna ? "&y=" + year : "");
            return url;
        }
        private string CallRestMethod(string url)
        {
            HttpWebRequest webrequest = (HttpWebRequest)WebRequest.Create(url);
            webrequest.Method = "GET";
            webrequest.ContentType = "application/x-www-form-urlencoded";
            HttpWebResponse webresponse = (HttpWebResponse)webrequest.GetResponse();
            Encoding enc = System.Text.Encoding.GetEncoding("utf-8");
            StreamReader responseStream = new StreamReader(webresponse.GetResponseStream(), enc);
            string result = string.Empty;
            result = responseStream.ReadToEnd();
            webresponse.Close();
            return result;
        }

        private bool IsYear(string godina)
        {
            try
            {
                foreach (char c in godina)
                {
                    if (!Char.IsDigit(c))
                        return false;
                }
                if (Convert.ToInt32(godina) > 1800 && Convert.ToInt32(godina) < 2023)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

    }
}
