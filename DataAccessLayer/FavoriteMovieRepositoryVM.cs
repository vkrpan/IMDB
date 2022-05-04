using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class FavoriteMovieRepositoryVM
    {
        private FavoriteMovieRepository repositoryVM = new FavoriteMovieRepository();
        public List<FavoriteMovieVM> getFavoriteMoviesVM()
        {
            List<FavoriteMovieVM> listaFavorita = new List<FavoriteMovieVM>();
            var favoriti = repositoryVM.GetFavoriteMovies();
            foreach(FavoriteMovie movie in favoriti)
            {
                listaFavorita.Add(new FavoriteMovieVM()
                {
                    IMDbId = movie.ImdbId,
                    Title = movie.Title,
                    Year = movie.Released.Year.ToString(),
                    Duration = movie.Duration,
                    Genre = movie.Genre,
                    Type = movie.Type,
                    UserOcjena = movie.UserOcjena,
                    UserID = movie.UserID
                });
            }
            return listaFavorita;
        }
        
    }
}
