using System.Configuration;
using System.Collections.Specialized;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class MovieRepository
    {
        readonly string apiLink = ConfigurationManager.ConnectionStrings["link"].ConnectionString;
        readonly string apiKey = ConfigurationManager.ConnectionStrings["ApiKey"].ConnectionString;
        public Movie getMovie(string imdbID)
        {
            string url = apiLink+"i=" + imdbID + "&apikey="+apiKey;
            string sJson = CallRestMethod(url);
            JObject json = JObject.Parse(sJson);
            if (json["Released"].ToString() == "N/A")
            {
                Movie film = new Movie()
                {
                    ImdbId = json["imdbID"].ToString(),
                    Title = json["Title"].ToString(),
                    Year = json["Year"].ToString(),
                    RatingRestriction = json["Rated"].ToString(),
                    Released = new DateTime(),
                    Duration = json["Runtime"].ToString(),
                    Genre = json["Genre"].ToString(),
                    Director = json["Director"].ToString(),
                    Writer = json["Writer"].ToString(),
                    Actors = json["Actors"].ToString(),
                    Plot = json["Plot"].ToString(),
                    Language = json["Language"].ToString(),
                    Awards = json["Awards"].ToString(),
                    ImgUrl = json["Poster"].ToString(),
                    ImdbRating = json["imdbRating"].ToString(),
                    ImdbVotes = json["imdbVotes"].ToString(),
                    Type = json["Type"].ToString()
                };   
            }
            else
            {
                Movie film = new Movie()
                {
                    ImdbId = json["imdbID"].ToString(),
                    Title = json["Title"].ToString(),
                    Year = json["Year"].ToString(),
                    RatingRestriction = json["Rated"].ToString(),
                    Released = Convert.ToDateTime(json["Released"]),
                    Duration = json["Runtime"].ToString(),
                    Genre = json["Genre"].ToString(),
                    Director = json["Director"].ToString(),
                    Writer = json["Writer"].ToString(),
                    Actors = json["Actors"].ToString(),
                    Plot = json["Plot"].ToString(),
                    Language = json["Language"].ToString(),
                    Awards = json["Awards"].ToString(),
                    ImgUrl = json["Poster"].ToString(),
                    ImdbRating = json["imdbRating"].ToString(),
                    ImdbVotes = json["imdbVotes"].ToString(),
                    Type = json["Type"].ToString()
                };
                return film;
            }

            return new Movie();
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
       
    }
}
