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
    public partial class MovieDetailsForm : Form
    {
        private FavoriteMovieRepository favoriteMovieRepository = new FavoriteMovieRepository();
        private MovieRepository movieRepository = new MovieRepository();
        private LogRepository logRep = new LogRepository();
        private User user;
        private string imdbID;
        private string movieName;
        public MovieDetailsForm(string imdbID, User korisnik)
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            IMDbIDLabel.Hide();
            Movie film = movieRepository.getMovie(imdbID);
            IMDbIDLabel.Text = imdbID;
            MakeMovieID(korisnik, imdbID, film.Title);
            if (user.Username == "ADMIN")
            {
                FavoriteButton.Hide();
            }
            if (film.ImgUrl != "N/A")
            {
                try
                {
                    MoviePictureBox.Load(film.ImgUrl);
                }
                catch
                {

                }
            }
            MovieTitleLabel.Text = film.Title;
            if (film.Year != "N/A")
            {
                YearLabel.Text = film.Year;
            }
            else
            {
                YearLabel.Text = "";
            }
            if (film.RatingRestriction != "N/A")
            {
                RatedLabel.Text = film.RatingRestriction;
            }
            else
            {
                RatedLabel.Text = "";
            }
            if (film.Duration != "N/A")
            {
                DurationLabel.Text = film.Duration;
            }
            else
            {
                DurationLabel.Text = "";
            }
            if (film.Genre != "N/A")
            {
                GenreLabel.Text = film.Genre;
            }
            else
            {
                GenreLabel.Text = "";
            }
            if (film.Plot != "N/A")
            {
                PlotLabel.Text = film.Plot;
            }
            else
            {
                PlotLabel.Text = "Nije moguće dohvatiti kratki sadržaj";
            }
            DirectorsLabel.Text ="Directors: "+ film.Director;
            WritersLabel.Text ="Writers: "+ film.Writer;
            ActorsLabel.Text ="Actors: "+ film.Actors;
            if(film.ImdbRating != "N/A")
            {
                imdbRatingLabel.Text = film.ImdbRating + " /10";
            }
            else
            {
                imdbRatingLabel.Text = "";
            }
            if(film.ImdbVotes != "N/A")
            {
                imdbVotesLabel.Text = film.ImdbVotes;
            }
            else
            {
                imdbVotesLabel.Text = "";
            }
            ReleasedLabel.Text ="Released: "+ film.Released.Day + "." + film.Released.Month + "." + film.Released.Year;
            if (film.Awards != "N/A")
            {
                AwardsLabel.Text = "Awards: " + film.Awards;
            }
            else
            {
                AwardsLabel.Text = "";
            }

        }
        private void MakeMovieID(User User, string IMDbID, string naziv)
        {
            user = User;
            imdbID = IMDbID;
            movieName = naziv;
        }

        private void FavoriteButton_Click(object sender, EventArgs e)
        {
            if(FavoriteButton.BackColor == Color.FromArgb(246, 199, 0))
            {
                foreach (FavoriteMovie fm in favoriteMovieRepository.GetFavoriteMovies())
                {
                    if(fm.UserID == user.UserID && IMDbIDLabel.Text==fm.ImdbId)
                    {
                        favoriteMovieRepository.RemoveFromFavorite(fm.ImdbId, fm.UserID);
                        FavoriteButton.BackColor = Color.FromArgb(39, 39, 58);
                        FavoriteButton.ForeColor = Color.Black;
                        logRep.ZapisiLog("Korisnik " + user.Username + " je uklonio je fim " + movieName + " iz svojih favorita");
                    }
                }
            }
            else if(FavoriteButton.BackColor == Color.FromArgb(39, 39, 58))
            {
                favoriteMovieRepository.SaveFavoriteMovie(movieRepository.getMovie(IMDbIDLabel.Text), user.UserID);
                FavoriteButton.BackColor = Color.FromArgb(246, 199, 0);
                FavoriteButton.ForeColor = Color.Black;
                logRep.ZapisiLog("Korisnik " + user.Username + " je dodao fim " + movieName + " u svoju kolekciju favorita");
            }
        }

        private void MovieDetailsForm_Load(object sender, EventArgs e)
        {
            foreach(FavoriteMovie fm in favoriteMovieRepository.GetFavoriteMovies())
            {
                if (fm.UserID == user.UserID && fm.ImdbId==imdbID)
                {
                    FavoriteButton.BackColor = Color.FromArgb(246, 199, 0);
                    FavoriteButton.ForeColor = Color.Black;
                }
            }
        }
    }
}
