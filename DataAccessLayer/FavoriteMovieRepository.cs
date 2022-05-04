using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DataAccessLayer
{
    public class FavoriteMovieRepository
    {
        readonly string SqlConnectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
        public List<FavoriteMovie> GetFavoriteMovies()
        {
            List<FavoriteMovie> lista = new List<FavoriteMovie>();
            //string sSqlConnectionString = @"Data Source=193.198.57.183,1433;Network Library=DBMSSOCN;Initial Catalog=STUDENTI_PIN;User ID=pin;Password=Vsmti1234!;";
            using (DbConnection oConnection = new SqlConnection(SqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "SELECT * FROM Krpan_FavoriteMovies";
                oConnection.Open();
                using(DbDataReader reader = oCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new FavoriteMovie()
                        {
                            ImdbId = reader["Id"].ToString(),
                            Title = reader["Title"].ToString(),
                            RatingRestriction = reader["Rated"].ToString(),
                            Released = Convert.ToDateTime(reader["Released"]),
                            Duration = reader["Duration"].ToString(),
                            Genre = reader["Genre"].ToString(),
                            Director = reader["Director"].ToString(),
                            Writer = reader["Writer"].ToString(),
                            Actors = reader["Actors"].ToString(),
                            Plot = reader["Plot"].ToString(),
                            Language = reader["Language"].ToString(),
                            Awards = reader["Awards"].ToString(),
                            ImgUrl = reader["Img"].ToString(),
                            ImdbRating = reader["imdbRating"].ToString(),
                            ImdbVotes = reader["imdbVotes"].ToString(),
                            Type = reader["Type"].ToString(),
                            UserOcjena = reader["UserOcjena"].ToString(),
                            UserID = Convert.ToInt32(reader["UserId"])
                        });
                    }
                }
            }
            return lista;
        }
        public void RemoveFromFavorite(string imdbID, int userID)
        {
            //string sSqlConnectionString = @"Data Source=193.198.57.183,1433;Network Library=DBMSSOCN;Initial Catalog=STUDENTI_PIN;User ID=pin;Password=Vsmti1234!;";
            using(DbConnection oConnection = new SqlConnection(SqlConnectionString))
            using(DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "DELETE FROM Krpan_FavoriteMovies WHERE Id = '" + imdbID + "' AND UserId='" + userID + "'";
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }

        }
        public void SaveFavoriteMovie(Movie movie, int UserID)
        {
            //string sSqlConnectionString = @"Data Source=193.198.57.183,1433;Network Library=DBMSSOCN;Initial Catalog=STUDENTI_PIN;User ID=pin;Password=Vsmti1234!;";
            SqlConnection con = new SqlConnection(SqlConnectionString);
            string Query = "INSERT INTO Krpan_FavoriteMovies VALUES (@Id, @Title, @Rated, @Released, @Duration, @Genre, @Director, @Writer, @Actors, @Plot, @Language, @Awards, @Img, @imdbRating, @imdbVotes, @Type, @UserOcjena, @UserId)";
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlParameter[] param = new SqlParameter[18];
            param[0] = new SqlParameter("@Id", movie.ImdbId);
            param[1] = new SqlParameter("@Title", movie.Title);
            param[2] = new SqlParameter("@Rated", movie.RatingRestriction);
            param[3] = new SqlParameter("@Released", movie.Released);
            param[4] = new SqlParameter("@Duration", movie.Duration);
            param[5] = new SqlParameter("@Genre", movie.Genre);
            param[6] = new SqlParameter("@Director", movie.Director);
            param[7] = new SqlParameter("@Writer", movie.Writer);
            param[8] = new SqlParameter("@Actors", movie.Actors);
            param[9] = new SqlParameter("@Plot", movie.Plot);
            param[10] = new SqlParameter("@Language", movie.Language);
            param[11] = new SqlParameter("@Awards", movie.Awards);
            param[12] = new SqlParameter("@Img", movie.ImgUrl);
            param[13] = new SqlParameter("@imdbRating", movie.ImdbRating);
            param[14] = new SqlParameter("@imdbVotes", movie.ImdbVotes);
            param[15] = new SqlParameter("@Type", movie.Type);
            param[16] = new SqlParameter("@UserId", UserID);
            param[17] = new SqlParameter("@UserOcjena", DBNull.Value);
            cmd.Parameters.AddRange(param);
            con.Open();
            cmd.ExecuteScalar();
            con.Close();
        }
        public void SaveFavorite(FavoriteMovie movie, int UserID, string UserOcjena)
        {
            //string sSqlConnectionString = @"Data Source=193.198.57.183,1433;Network Library=DBMSSOCN;Initial Catalog=STUDENTI_PIN;User ID=pin;Password=Vsmti1234!;";
            SqlConnection con = new SqlConnection(SqlConnectionString);
            string Query = "INSERT INTO Krpan_FavoriteMovies VALUES (@Id, @Title, @Rated, @Released, @Duration, @Genre, @Director, @Writer, @Actors, @Plot, @Language, @Awards, @Img, @imdbRating, @imdbVotes, @Type, @UserOcjena, @UserId)";
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlParameter[] param = new SqlParameter[18];
            param[0] = new SqlParameter("@Id", movie.ImdbId);
            param[1] = new SqlParameter("@Title", movie.Title);
            param[2] = new SqlParameter("@Rated", movie.RatingRestriction);
            param[3] = new SqlParameter("@Released", movie.Released);
            param[4] = new SqlParameter("@Duration", movie.Duration);
            param[5] = new SqlParameter("@Genre", movie.Genre);
            param[6] = new SqlParameter("@Director", movie.Director);
            param[7] = new SqlParameter("@Writer", movie.Writer);
            param[8] = new SqlParameter("@Actors", movie.Actors);
            param[9] = new SqlParameter("@Plot", movie.Plot);
            param[10] = new SqlParameter("@Language", movie.Language);
            param[11] = new SqlParameter("@Awards", movie.Awards);
            param[12] = new SqlParameter("@Img", movie.ImgUrl);
            param[13] = new SqlParameter("@imdbRating", movie.ImdbRating);
            param[14] = new SqlParameter("@imdbVotes", movie.ImdbVotes);
            param[15] = new SqlParameter("@Type", movie.Type);
            param[16] = new SqlParameter("@UserId", UserID);
            param[17] = new SqlParameter("@UserOcjena", UserOcjena);
            cmd.Parameters.AddRange(param);
            con.Open();
            cmd.ExecuteScalar();
            con.Close();
        }

        public FavoriteMovie MovieToFavoriteMovie(Movie film, int UserId)
        {
            List<FavoriteMovie> listaFavorita = GetFavoriteMovies().Where(x => x.UserID == UserId && x.ImdbId == film.ImdbId).ToList();
            return listaFavorita.FirstOrDefault();
        }
    }
}
