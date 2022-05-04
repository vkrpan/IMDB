using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;

namespace PresentationLayer
{
    public partial class RateAMovieForm : Form
    {
        private FavoriteMovieRepository favoriteMovieRepository = new FavoriteMovieRepository();
        private MovieRepository movieRepository = new MovieRepository();
        private User oUser;
        private string IMDbId;
        private LogRepository logRepository = new LogRepository();
        private string ImeFilma;
        public RateAMovieForm(string imdbID, User User)
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            Movie film = movieRepository.getMovie(imdbID);
            MakeUser(User, imdbID, film.Title);
            FavoriteMovie favoritFilm = favoriteMovieRepository.MovieToFavoriteMovie(film, oUser.UserID);
            MovieTitleLabel.Text = film.Title;
            if (film.ImgUrl != "N/A")
            {
                MoviePictureBox.Load(film.ImgUrl);
            }
            if (film.Year != "N/A")
            {
                YearLabel.Text = film.Year;
            }
            else
            {
                YearLabel.Text = "";
            }
            if (film.Duration != "N/A")
            {
                DurationLabel.Text = film.Duration;
            }
            else
            {
                DurationLabel.Text = "";
            }
            if (film.ImdbRating != "N/A")
            {
                imdbRatingLabel.Text = "Ocjena na IMDb: "+ film.ImdbRating + " /10";
            }
            if (film.ImdbVotes != "N/A")
            {
                imdbVotesLabel.Text = film.ImdbVotes;
            }
            if (film.Genre != "N/A")
            {
                GenreLabel.Text = film.Genre;
            }
            else
            {
                GenreLabel.Text = "";
            }
            if(favoritFilm.UserOcjena != null)
            {
                InputOcjTextBox.Text = favoritFilm.UserOcjena;
            }
            else
            {
                InputOcjTextBox.Text = "";
            }
        }
        private void MakeUser(User UserId, string imdbID, string naziv)
        {
            oUser = UserId;
            IMDbId = imdbID;
            ImeFilma = naziv;
        }
        private void UnosOcjButton_Click(object sender, EventArgs e)
        {
            string input = InputOcjTextBox.Text;
            float Ocjena;
            if(Single.TryParse(input, out Ocjena))
            {
                if(Ocjena>=1 && Ocjena <= 10)
                {
                    Ocjena = Convert.ToSingle(Math.Round(Ocjena, 2));
                    List<FavoriteMovie> listaFavorita = favoriteMovieRepository.GetFavoriteMovies().Where(x => x.UserID == oUser.UserID && x.ImdbId == IMDbId).ToList();
                    favoriteMovieRepository.RemoveFromFavorite(IMDbId, oUser.UserID);
                    favoriteMovieRepository.SaveFavorite(listaFavorita.FirstOrDefault(), oUser.UserID, Ocjena.ToString());
                    MessageBox.Show("Vaša ocjena je uspješno unesena!", "Unos ocjene", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logRepository.ZapisiLog("Korisnik " + oUser.Username + " je ocjenio film " + ImeFilma + " sa ocjenom " + Ocjena);
                }
                else
                {
                    MessageBox.Show("Svoju ocjenu morate unijeti u brojčanom obliku u rasponu od 1-10", "Registracija", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Svoju ocjenu morate unijeti u brojčanom obliku u rasponu od 1-10.\n Koristite , za odvajanje decimalnog mjesta!", "Registracija", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
