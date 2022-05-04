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
    public partial class UserInfoForm : Form
    {
        private FavoriteMovieRepository favoriteMovieRepository = new FavoriteMovieRepository();
        private LoginRepository loginRepository = new LoginRepository();
        public UserInfoForm(User Userr)
        {
            InitializeComponent();
            if (Userr.Username == "ADMIN")
            {
                UkFavoritaLabel.Hide();
                UkOcjFilmovaLabel.Hide();
                ProsjecnaLabel.Hide();
            }
            UkFavoritaLabel.Text = "Ukupno filmova spremljeno u favorite: " + favoriteMovieRepository.GetFavoriteMovies().Where(x => x.UserID == Userr.UserID).ToList().Count;
            var ukFavorite = favoriteMovieRepository.GetFavoriteMovies().Where(x => x.UserID == Userr.UserID && x.UserOcjena.Length > 0).ToList().Count;
            UkOcjFilmovaLabel.Text = "Od toga ocjenjeni: " + ukFavorite;
            var ListaFavorita = favoriteMovieRepository.GetFavoriteMovies();
            float ocjena = 0;
            foreach(FavoriteMovie fM in ListaFavorita)
            {
                if (fM.UserID == Userr.UserID)
                {
                    if (fM.UserOcjena.Length >1)
                    {
                        ocjena += Convert.ToSingle(fM.UserOcjena);
                    }
                    
                }
            }
            ProsjecnaLabel.Text = "Prosječna ocjena vaših ocjenjenih filmova: " + (ocjena / ukFavorite).ToString();

            var listaUsera = loginRepository.GetUsers();
            foreach(User kor in listaUsera)
            {
                if(Userr.UserID == kor.UserID)
                {
                    LabelIme.Text = "Ime:" + kor.Name;
                    LabelPrezime.Text = "Prezime: " + kor.Surname;
                    EmailLabel.Text = "Email: " + kor.Email;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
