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
    public partial class RatedMovieInfoForm : Form
    {
        private User oUser;
        private FavoriteMovieRepository FavoriteMovieRepository = new FavoriteMovieRepository();
        private string ImdbId;
        private MovieRepository movieRep = new MovieRepository();
        private FavoriteMovieRepository favMovieRep = new FavoriteMovieRepository();
        public RatedMovieInfoForm(User korisnik, string IMDbId)
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            MakeUser(korisnik, IMDbId);
            float ocj = 0;
            float prosjOcj;
            int cntrNeOcj = 0;
            int cntrOcj = 0;
            List<FavoriteMovie> listSpec = FavoriteMovieRepository.GetFavoriteMovies().Where(x => x.ImdbId == IMDbId).ToList();
            Movie film = movieRep.getMovie(IMDbId);
            FavoriteMovie favoritFilm = favMovieRep.MovieToFavoriteMovie(film, oUser.UserID);
            foreach (var favM in listSpec)
            {
                float vrijednost;
                if(Single.TryParse(favM.UserOcjena, out vrijednost))
                {
                    ocj += vrijednost;
                    cntrOcj++;
                }
                else
                {
                    cntrNeOcj++;
                }
                 
            }
            if (ocj<1)
            {
                UkOcjLabel.Hide();
                pictureBoxStar.Hide();
            }
            else
            {
                if((ocj / (listSpec.Count - cntrNeOcj) %1) == 0)
                {
                    UkOcjLabel.Text = "Prosječna ocjena ocjena svih korisnika je: " + ocj / (listSpec.Count - cntrNeOcj) + "/10";
                }
                else
                {
                    UkOcjLabel.Text = "Prosječna ocjena ocjena svih korisnika je: " + ocj / (listSpec.Count - cntrNeOcj) + "/10";
                    pictureBoxStar.Location = new Point(470, 296);
                }
                
            }
            if (cntrOcj == 0)
            {
                BrOcjLabel.Text = "Niti jedan korisnik nije ocijenio "+ film.Title;
            }
            else
            {
                BrOcjLabel.Text = "Ukupno " + cntrOcj + " korisnika je ocijenilo " + film.Title;
            }

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
                imdbRatingLabel.Text = "Ocjena na IMDb: " + film.ImdbRating + " /10";
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
        }

        private void MakeUser(User user, string imdbid)
        {
            oUser = user;
            ImdbId = imdbid;
        }
    }
}
